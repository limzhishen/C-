using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.Drawing.Text;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace IOOP_GROUP_22
{
    internal class Class
    {
        //attributes(variables)

        // Opening Sql SqlConnection
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string tutorName;
        private string userId;
        private string classId;
        private string Form;
        private string subjectId;
        private string subjectName;
        private DateTime startTime;
        private string duration;
        private string charges;
        private DataGridView classInformation;
        private DataGridView classSchedule;


        //Constructors
        //Constructor is used to complete the initial work.
        //Constructor can pass the parameters we need and write the required methods.
        public Class()
        {
        }

        
        public Class(string id)
        {
            this.userId = id;
        }

        //constructors
        public Class(string ci,string ui, string F, string sn, DateTime st, string d, string c)
        {
            classId = ci;
            userId = ui;
            Form = F;
            subjectName = sn;
            startTime = st;
            duration = d;
            charges = c;
        }

        public Class(string ci, string F, string sn, DateTime st, string d, string c)
        {
            classId = ci;
            Form = F;
            subjectName = sn;
            startTime = st;
            duration = d;
            charges = c;
  

        }

        public DataGridView ClassInformation { get => classInformation; set => classInformation = value; }
        public DataGridView ClassSchedule { get => classSchedule; set => classSchedule = value; }


        //behaviour(methods)

        //Used to let the tutor add related classes
        public void addClassInformation()
        {
           
            con.Open();// Open the connection
            //Before using sqlcommand, you must define it first.
            SqlCommand md = new SqlCommand("(Select Name from User_info where Userid='" + userId + "')", con);
            tutorName = md.ExecuteScalar().ToString();//Returns the first row and first column of the query result.
            con.Close(); // Close the connection 
            con.Open();
            SqlCommand d = new SqlCommand("(select Subject_id from Subject_Table where Subject_Name='" + subjectName + "')", con);
            subjectId = d.ExecuteScalar().ToString();
            con.Close() ;
            classId = classid_generator();//Classid will be automatically generated.
            con.Open();
            // Pass in parameter into sql query.
            SqlCommand cmd = new SqlCommand("INSERT INTO Timetable(Classid,Userid,Tutor_Name,Form,Subject_id,Subject_Name,Charge,Start_Time,Duration) VALUES(@Classid,@Userid,@Tutor_Name,@Form,@Subject_id,@Subject_Name,@Charge,@Start_Time,@Duration)", con);
            cmd.Parameters.AddWithValue("@Classid", classId);
            cmd.Parameters.AddWithValue("@Userid", userId);
            cmd.Parameters.AddWithValue("@Tutor_Name", tutorName);
            cmd.Parameters.AddWithValue("@Form", Form);
            cmd.Parameters.AddWithValue("@Subject_id", subjectId);
            cmd.Parameters.AddWithValue("@Subject_Name", subjectName);
            cmd.Parameters.AddWithValue("@Charge", charges);
            cmd.Parameters.AddWithValue("@Start_Time", startTime);
            cmd.Parameters.AddWithValue("@Duration", duration);
            //ExecuteNonQuery() Used to verify the addition, deletion and modification of the database.
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //This datetime_validation is used to verify whether the selected time conflicts when we select add or update.
        public string datetime_validation(DateTime tutor_class_time)
        {
            string status = "Record added";
            con.Open();
            //SqlDataAdapter is a bridge between DataTable and SQL Server.
            SqlDataAdapter sda =new SqlDataAdapter("Select Start_Time,Duration,Classid from Timetable where Userid='" + userId + "'", con);
            //DataTable is an in-memory data table.
            DataTable da =new DataTable();
            sda.Fill(da);
            //Use Foreach to loop the rows and columns of the DataTable.
            foreach (DataRow dr in da.Rows) 
            {
                DateTime starttime = Convert.ToDateTime(dr[0].ToString());
                if (dr[1].ToString().Length != 5)//Because the first line is the attribute name, not the value we want.
                {
                    //Use substring to extract from the specified character position from the string.
                    //Substring starts to take value from this position, but does not include this point.
                    string addhour = dr[1].ToString().Substring(0,1);
                    if (tutor_class_time >= starttime && tutor_class_time <= starttime.AddHours(Convert.ToInt32(addhour)))
                    {
                        if (classId != dr[2].ToString()) status = "Datetime is conflict with other class";

                    }
                }
                else
                {
                    string addhour = dr[1].ToString().Substring(0,1);
                    string addmin= dr[1].ToString().Substring(2,2);
 
                    if (tutor_class_time >= starttime && tutor_class_time <= starttime.AddHours(Convert.ToInt32(addhour)).AddMinutes(Convert.ToInt32(addmin)))
                    {
                        if (classId != dr[2].ToString()) status = "Datetime is conflict with other class";
                    }
                }
            }
            con.Close();
            return status;//return the value back.
        }

        //Used to let the tutor delete related classes.
        public void deleteClassInformation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student_Class WHERE Classid = '" + classId +"' ", con);
            cmd.ExecuteNonQuery();//Used to verify the addition, deletion and modification of the database.
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM Request_drop WHERE Classid = '" + classId + "' ", con);
            cmd1.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Request_add WHERE Classid = '" + classId + "' ", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("DELETE FROM Timetable WHERE Classid = '" + classId + "'", con);
            cmd3.ExecuteNonQuery();
            con.Close();
        }


        //Used to let the tutor update related classes.
        public void updateClassInformation()
        {
            
            con.Open(); // Open the connection

            // Pass in parameter into sql query
            SqlCommand cmd = new SqlCommand("UPDATE Timetable SET Form = @form, Subject_Name = @sub, Start_Time = @date, Duration = @duration, Charge = @charge, Subject_id=(select Subject_id from Subject_Table where Subject_Name=@su) WHERE ClassId = @classId", con);
            cmd.Parameters.AddWithValue("@classId",classId);
            cmd.Parameters.AddWithValue("@form", Form);
            cmd.Parameters.AddWithValue("@sub", subjectName);
            cmd.Parameters.AddWithValue("@date", startTime);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@charge", charges);
            cmd.Parameters.AddWithValue("@su", subjectName);

            int i=cmd.ExecuteNonQuery();

            con.Close(); // Close the connection

            
        }



        //This classid_generator method is used to automatically generate Classid.
        private string classid_generator()
        {
            string id = "";
            int i = 1;//cls001
            int count = 1;//001
            con.Open();//Open the connection
            //SqlDataAdapter is a bridge between DataTable and SQL Server.
            SqlDataAdapter cmd = new SqlDataAdapter("Select Classid from Timetable", con);
            DataTable dt = new DataTable();//DataTable is an in-memory data table.
            cmd.Fill(dt);
            while (i < 5)
            {
                i = 1;
                foreach (DataRow dr in dt.Rows)//Use Foreach to loop the rows and columns of the DataTable.
                {
                    string remove = (dr[0].ToString().Remove(0, 3));//Remove cls from cls001.
                    if (Convert.ToInt32(remove) == count) { i = 2; }//Convert.ToInt32 is convert to int.

                }
                if (i == 2) { count++; }
                else break;

            }
            
            if (count < 10) id = "Cls00" + count.ToString();
            else if (count > 10 || count < 100) id = "Cls0" + count.ToString();
            else id = "Cls" + count.ToString();//ToString convert int into string.
            con.Close();//Close the connection
            return id;

        }
        //This method is used to display the class information of all tutors.
        public void showClassInformation()
        {
            con.Open(); // Open the connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM Timetable",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);//SqlDataAdapter is a bridge between DataTable and SQL Server.
            //Using Data Table
            DataTable dt = new DataTable();//DataTable is an in-memory data table.
            da.Fill(dt);
            classInformation.DataSource= dt;// For binding data
            con.Close(); // Close the connection
            
        }


        //This method is used to display the class schedule of the specified tutor.
        public void showClassSchedule()
        {
            con.Open(); // Open the connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM Timetable WHERE Userid='"+userId+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Using Data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            classSchedule.DataSource = dt;
            con.Close(); // Close the connection

        }

        //This method is used to find class information about the selected form and subject.
        public void searchClassInformation(string sub, string form)
        {
            string query = "(SELECT * FROM Timetable)";
            
            
            if (sub == "Subject" && form != "Form")
            {
                query = "SELECT * FROM Timetable WHERE Form = '" + form + "'";
            }
            else if (form == "Form" && sub != "Subject")
            {
                query="SELECT * FROM Timetable WHERE Subject_Name = '" + sub + "'";
            }
            else if (sub != "Subject" && form != "Form")
            {
                query="SELECT * FROM Timetable WHERE Subject_Name ='" + sub + "' AND Form ='" +form + "'";
            }

            con.Open();// Open the connection
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Using Data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            classSchedule.DataSource = dt;
            con.Close(); // Close the connection

        }

        public static DataTable getSubject()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Subject_Name FROM Subject_Table", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getTutorSubject(string ui)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Subject_Name from Subject_Table where Subject_id in (select Subject_id from Tutor_subject where Userid = '"+ui+"');", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable getForm(string ui)//userid = ui,在formpage 
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Form FROM Tutor_Form WHERE Userid = '"+ ui + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        /*
        public static DataTable getDuration()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Duration FROM Timetable", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        */
    }
}
