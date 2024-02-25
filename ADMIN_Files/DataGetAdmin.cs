using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;

namespace IOOP_GROUP_22
{
    internal class DataGetAdmin
    {
        private string subject;
        private string form;
        private DataGridView Tablemonthly;

        
        static SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public DataGridView Tablemonthly1 { get => Tablemonthly; set => Tablemonthly = value; }


        public DataGetAdmin(string form, string subject)
        {
            this.form = form;
            this.subject = subject;
        }

        public DataGetAdmin()
        {
        }

        public static string getmonthamount()// get the this month total amount from database
        {
            string month = DateTime.Now.ToString("MM");
            string Year = DateTime.Now.ToString("yyyy");
            Con.Open();
            SqlCommand cmd = new SqlCommand("select sum(Fee) from Make_Payment where Payment_status='Paid' and Month(Payment_Date)=" + month + "and Year(Payment_Date)=" + Year, Con);
            string sum = cmd.ExecuteScalar().ToString();
            Con.Close();
            return sum;

        }
        public static string gettotaluser()//get total user from database
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select count(*)from User_info", Con);
            string total = cmd.ExecuteScalar().ToString();
            Con.Close();
            return total;

        }
        public static DataTable getsubject()//get subject from database and return a datable for adding into combobox
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Subject_Name from Subject_Table", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            return dt;
        }

        public void Monthly_Income()//get all payment information from database and show by using properties
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *,(Select Subject_Name From Subject_Table Where Subject_id=Make_Payment.Subject_id)AS Subject_Name from Make_Payment", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Tablemonthly.DataSource = dt;
            Con.Close();
        }
        public static DataTable getYear() //get year from database and return a datatable for adding into combobox
        {
            Con.Open() ;
            SqlDataAdapter da = new SqlDataAdapter("Select distinct Year(Payment_Date) from Make_Payment ", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();
            return dt;
        }
        public static DataTable Search_Monthly_Income(string month,string form,string subject,string Year,string generator)//searching in payment information by using different query
        {
            DataTable dgv = new DataTable();
            string query= ("select *,(Select Subject_Name From Subject_Table Where Subject_id=Make_Payment.Subject_id)AS Subject_Name from Make_Payment");
            if (month!=""&& form==""&&subject=="")
            {
                query+= " where MONTH(Payment_Date)=" +month;
            }
            else if(month == "" && form != "" && subject == "")
            {
                query += " where Form='" + form + "'";
            }
            else if (month == "" && form == "" && subject != "") query += " where Subject_id=(Select Subject_id from Subject_Table where Subject_Name='" + subject+"')";
            else if (month != "" && form != "" && subject == "") query += " where MONTH(Payment_Date)=" + month+"and Form='" + form+"'";
            else if (month != "" && form == "" && subject != "") query += " where MONTH(Payment_Date)=" + month + "and Subject_id=(Select Subject_id from Subject_Table where Subject_Name='" + subject+"')";
            else if (month == "" && form != "" && subject != "") query += " where Form='" + form + "'and Subject_id=(Select Subject_id from Subject_Table where Subject_Name='" + subject + "')";
            else if (month != "" && form != "" && subject != "") query += " where MONTH(Payment_Date)=" + month + " and Form='" + form + "'and Subject_id=(Select Subject_id from Subject_Table where Subject_Name='" + subject + "')";

            if (month == "" && form == "" && subject == "" && Year != "")
            {
                query +=" where YEAR(Make_Payment.Payment_Date) = " + Year;
            }
            else if(month != "" || form != "" || subject != "")if(Year!="") query+= " AND YEAR(Make_Payment.Payment_Date) = " + Year;
            if (generator != "")
            {
                if(month == "" && form == "" && subject == "" && Year == "")
                {
                    query += " where Payment_status='Paid'";
                }
                else
                {
                    query += " and Make_Payment.Payment_status='Paid'";
                }
            }
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.Fill(dgv);
            Con.Close();
            return dgv;


        }
        public DataTable Search_User(string user)//search user by using their different role
        {
            string query = "Select * from User_info ";
            if (user !="")
            {
                query += "where User_role='" + user + "'";
            }
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable da=new DataTable();
            sda.Fill(da);
            Con.Close();
            return da;
        }
        public DataTable Search_with_name(string name)//serch user by using their name
        {
            string query = "Select * from User_info ";
            if (name != "")
            {
                query += "where Name like '%" + name + "%'";
            }
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable da = new DataTable();
            sda.Fill(da);
            Con.Close();
            return da;
        }
        public static List<string> gettutorsubject(string id)// get tutor subject name by using their userid
        {
            List<string> subject = new List<string>();
            Con.Open();
            SqlDataAdapter sda =new SqlDataAdapter("Select Subject_id from Tutor_subject where userid='"+id+"'", Con); 
            DataTable data= new DataTable();
            DataTable data2 = new DataTable();
            sda.Fill(data);
            Con.Close();
            foreach(DataRow row in data.Rows) 
            {
                Con.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("Select Subject_Name from Subject_Table where Subject_id='" + row[0].ToString() + "'", Con);
                sda2.Fill(data2);
                Con.Close();
            }
            //string[] subject = { };
            foreach(DataRow row1 in data2.Rows)
            {
                subject.Add(row1[0].ToString());
            }
            return subject;
        }
        public static List<string> gettutorform(string id)//get tutor from by using their userid
        {
            List<string> form = new List<string>();
            Con.Open();
            SqlDataAdapter sda= new SqlDataAdapter("Select Form from Tutor_Form where Userid='"+id+"'",Con);
            DataTable data= new DataTable();
            sda.Fill(data);
            Con.Close();
            foreach(DataRow row in data.Rows)
            {
                form.Add(row[0].ToString());
            }
            return form;
        }

        public string Update_Tutor_Form(string id)//update tutor form 
        {
            string status = "Fail to update";//because tutor form change may in add or delete form so need to find their difference in add or delete
            List<string> deleteform= new List<string>();
            List<string> oldform = gettutorform(id);
            List<string> addform= new List<string>();
            string[] level = form.Split(",");
            foreach(string l in level)
            {
                int have = 0;
                if (l != "")
                {
                    foreach (string f in oldform)
                    {
                        if (have == 1) { break; }
                        if (f == l)
                        {
                            have = 1;
                            break;
                        }
                    }
                    if (have == 0)
                    {
                        addform.Add(l);
                    }

                }
            }
            if (addform.Count == 0) 
            {
                foreach (string l in oldform)
                {
                    int have = 0;
                    if (l != "")
                    {
                        foreach (string f in level)
                        {
                            if (have == 1) { break; }
                            if (f == l)
                            {
                                have = 1;
                                break;
                            }
                        }
                        if (have == 0)
                        {
                            deleteform.Add(l);
                        }

                    }
                }
            }
            if(addform.Count != 0)
            {
                foreach(string add in addform)//if in add will add into database with the adding form
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Tutor_Form values (@id,@form)", Con);
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@form", add);
                    int i =cmd.ExecuteNonQuery();
                    if(i!=0) status= "Sucessful to update form";
                    Con.Close();
                }
            }
            else if (deleteform.Count != 0)
            {
                foreach (string del in deleteform)//if uncheck will delete the relevant form
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Tutor_Form where Userid=@id and Form=@form", Con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@form", del);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0) status = "Sucessful to update form";
                    Con.Close();
                }
            }
            return status;
        }
        public string Update_Tutor_subject(string id)//update tutor subject
        {
            string status = "Fail to update";//because tutor subject change may in add or delete form so need to find their difference in add or delete
            List<string> deletesubject = new List<string>();
            List<string> oldsubject =gettutorsubject(id);
            List<string> addsubject = new List<string>();
            string[] sub = subject.Split(",");
            foreach (string s in sub)
            {
                int have = 0;
                if (s != "")
                {
                    
                    foreach (string o in oldsubject)
                    {
                        if (have == 1) { break; }
                        if (o == s)
                        {
                            
                            have = 1;
                            break;
                        }
                    }
                    if (have == 0)
                    {
                        addsubject.Add(s);
                    }

                }
            }
            if (addsubject.Count == 0)
            {
                foreach (string o in oldsubject)
                {
                    int have = 0;
                    if (o != "")
                    {
                        foreach (string s in sub)
                        {
                            if (have == 1) { break; }
                            if (s == o)
                            {
                                have = 1;
                                break;
                            }
                        }
                        if (have == 0)
                        {
                            deletesubject.Add(o);
                        }

                    }
                }
            }
            if (addsubject.Count != 0)
            {
                List<string> subjectid = getsubjectid(addsubject);
                foreach (string s in subjectid)
                {
                    //MessageBox.Show(s);
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Tutor_subject values (@id,@subjectid)", Con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@subjectid", s);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0) status = "Sucessful to update subject";
                    Con.Close();
                }
            }
            else if (deletesubject.Count != 0)
            {
                List<string> subjectid = getsubjectid(deletesubject);
                foreach (string del in subjectid)
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Tutor_Subject where Userid=@id and Subject_id=@sub", Con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@sub", del);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0) status = "Sucessful to update subject";
                    Con.Close();
                }
            }
            return status;

        }
        private List<string> getsubjectid(List<string> subject)//use for get the subject name from subject id
        {
            List<string> subjectid = new List<string>();
            foreach(string sub in subject)
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select Subject_id from Subject_Table where Subject_Name='" + sub + "'", Con);
                SqlDataReader rd= cmd.ExecuteReader();
                while(rd.Read())
                {
                    subjectid.Add(rd.GetString(0));
                }
                Con.Close();
            }
            return subjectid;
        }
    }
}
