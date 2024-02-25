using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Security.Policy;
using System.Web;
using System.Drawing;

namespace IOOP_GROUP_22.ReceptionistForms
{

    internal class ReceptionistClass
    {
        private string userid;
        private string username;
        private string password;
        private string name;
        private string email;
        private string contact;
        private string gender;
        private string dob;
        private string user_role;
        private Image user_Profile_pic;
        

        private DataGridView studentInfo;
        private DataGridView tutorTimetable;
        private DataGridView paymentHistory;
        private DataGridView makePayment;
        private DataGridView requestDrop;
        private DataGridView requestAdd;

        public string Userid { get { return userid; } set { userid = value; } }
        public string Username { get { return username; } set { username = value; } }

        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Contact { get { return contact; } set { contact = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Dob { get { return dob; } set { dob = value; } }
  

        


        public DataGridView StudentInfo { get { return studentInfo; } set { studentInfo = value; } }
        public DataGridView TutorTimetable { get { return tutorTimetable; } set { tutorTimetable = value; } }
        public DataGridView PaymentHistory { get { return paymentHistory; } set { paymentHistory = value; } }
        public DataGridView MakePayment { get { return makePayment; } set { makePayment = value; } }
        public DataGridView RequestDrop { get { return requestDrop; } set { requestDrop = value; } }
        public DataGridView RequestAdd { get { return requestAdd; } set { requestAdd = value; } }

        public Image User_Profile_pic { get => user_Profile_pic; set => user_Profile_pic = value; }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public ReceptionistClass() { }

        
        public ReceptionistClass(string userid)
        {
            this.userid = userid;
        }

        public ReceptionistClass(string userid,string name,string username,string email,string contact)
        {
            this.userid = userid;
            this.name = name;
            this.username = username;
            this.email = email;
            this.contact = contact;
        }
        public ReceptionistClass(string name, string email, string contact, string username, string password, string dob)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.username = username;
            this.password = password;
            this.dob = dob;

        }


        //About general use
        //This is use use to input all subject into the combobox for selection
        public static void ShowSubject(System.Windows.Forms.ComboBox comboBox)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Subject_Name From Subject_Table", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox.Items.Add(dr.GetString(0));
            }
            con.Close();
        }

        //This is to find the subject name based on subject id
        public static string SubjectIdNameConversion(string subjId)
        {
            string subjectname = null;
            if (subjId != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Subject_Name From Subject_Table Where Subject_id = '" + subjId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    subjectname = dr.GetString(0);
                }
                con.Close();
            }

            return subjectname;
        }

        public Array validation()
        {
            string[] array = { };
            if (!email.Contains("@"))
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "Email must contain '@'";
            }
            if (!email.Contains("."))
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Email must contain '.'";
            }

            if (contact.Length == 0 || contact.Length == 1 || contact.Length == 2)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "Please Fill in the contact";
            }

            else if (contact.Length > 2)
            {
                if (contact.Remove(2) == "01")

                    if (contact.Remove(3) == "011")
                    {
                        if ((contact.ToString()).Length != 11)
                        {
                            Array.Resize(ref array, array.Length + 1);
                            array[array.Length - 1] = "Please check the number of contact";
                        }
                    }
                    else
                    {
                        if ((contact.ToString()).Length != 10)
                        {
                            Array.Resize(ref array, array.Length + 1);
                            array[array.Length - 1] = "Please check the number of contact";
                        }

                    }

                else
                {
                    Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please use malaysia contact '01'";
                }
                if (!int.TryParse(contact, out int numericValue))
                {
                    Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Contact number only accepter numeric";
                }
            }
            if (Convert.ToDateTime(dob) > DateTime.Today)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "Select the true of your Date of Birth";
            }
            if (username.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the username";
            }
            if (name.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the name";
            }
            return array;
        }





        //About profile

        //Display the user profile
        public static void ViewProfile(ReceptionistClass o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from User_Info where Userid='" + o1.userid + "'", con);
            
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.userid = rd.GetString(0);
                o1.username = rd.GetString(1);
                o1.password = rd.GetString(2);
                o1.name = rd.GetString(3);
                o1.email = rd.GetString(4);
                o1.contact = rd.GetString(5);
                o1.gender = rd.GetString(6);
                o1.dob = rd.GetDateTime(7).ToShortDateString();
                o1.user_role = rd.GetString(8);

            }
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Profile_image"]);
            Image image = new Bitmap(ms);
            o1.User_Profile_pic= image;
            con.Close();


        }

        //Change the password of user
        public void UpdatePassword(string oldPw, string newPw, string confirmPw)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Password from User_info Where Username = '" + username + "'", con);
            string oldPassword = cmd.ExecuteScalar().ToString();

            if (oldPw == oldPassword)
            {
                if (confirmPw != newPw)
                {
                    MessageBox.Show("New password and confirm password does not match!", "Warning");
                }
                else if (newPw == "" || confirmPw == "")
                {
                    MessageBox.Show("Please enter your new and confirm password!", "Warning");
                }

                else if (confirmPw.Equals(newPw))
                {

                    SqlCommand cmd2 = new SqlCommand("Update User_info Set Password = '" + newPw + "' Where Username = '" + username + "'", con);
                    int i = cmd2.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Password change successfully.");

                    }
                    else
                    {
                        MessageBox.Show("Unable to change password.");

                    }
                }

            }
            else if (oldPw != oldPassword)
            {
                MessageBox.Show("Old Password incorrect!", "Warning");
            }
            con.Close();


        }

        //Save the change of user profile
        public string SaveProfile(string id,string name, string username, string email, string contactno)
        {
            string status1;
            con.Open();
            MemoryStream ms = new MemoryStream();
            User_Profile_pic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imagedata = ms.ToArray();
            SqlCommand cmd = new SqlCommand("Update User_info Set Name='"+ name +"',Username='"+ username +"', Email='"+ email +"', Profile_image=@image,Contact='"+ contactno +"' Where Userid='"+ id +"'", con);
            cmd.Parameters.AddWithValue("@image", imagedata);
            int i = cmd.ExecuteNonQuery();
            if (i != -1 && i != 0)
            {
                status1 = "Profile updated successful!";

            }
            else
            {
                status1 = "Profile updated failed!";

            }
            con.Close();
            return status1;
        }




        //About Modify Student

        //Display all student in table form
        public void ShowAllStudentInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Studentid,Username,Name,Email,Contact,Gender,Dob,Form,User_Role,Enrollment from Student_List", con);
            //Select Studentid,Username,Name,Email,Contact,Gender,Dob,Form,User_Role from Student_List where Studentid=@id
            //cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = "Stu" + "%";
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentInfo.DataSource = dt;
            con.Close();
        }

        //Search student by student id
        public void SearchStudent(string studId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Studentid,Username,Name,Email,Contact,Gender,Dob,Form,User_Role,Enrollment from Student_List Where Studentid = '" + studId + "'", con);
            try
            {

                cmd.ExecuteReader();
                con.Close();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                studentInfo.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Student ID!");
            }


        }

        //Delete student according student id
        public void DeleteStudent(string studId)
        {
            //Check student already clear all payment or not
            ArrayList paymentStatus = new ArrayList();
            List<string> unpaid = new List<string>();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Payment_status From Make_Payment Where Studentid = '"+ studId +"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                paymentStatus.Add(dr.GetString(0));
            }
            con.Close();
            for (int i = 1; i < paymentStatus.Count;++i)
            {
                string status = (string)paymentStatus[i];
                unpaid.Add(status);
            }
            if (unpaid.Contains("Unpaid"))
            {
                MessageBox.Show("This student haven't clear the payment!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Delete From Student_Class Where Studentid = '" + studId + "'", con);
                SqlCommand cmd2 = new SqlCommand("Delete From Request_add Where Studentid = '" + studId + "'", con);
                SqlCommand cmd3 = new SqlCommand("Delete From Request_drop Where Studentid = '" + studId + "'", con);
                SqlCommand cmd4 = new SqlCommand("Delete From Student_List Where Studentid = '" + studId + "'", con);
                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    int i1 = cmd1.ExecuteNonQuery();
                    int i2 = cmd2.ExecuteNonQuery();
                    int i3 = cmd3.ExecuteNonQuery();
                    int i4 = cmd4.ExecuteNonQuery();
                    if (i1 == 0 && i2 == 0 && i3==0 && i4==0)
                    {
                        MessageBox.Show("Deletion successful!");
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed!");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Student ID!");
                }
                con.Close();
            }
            
        }

        


        //About enroll student

        //Show tutor timetable in table form
        public void ShowAllTimetable()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Timetable", con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tutorTimetable.DataSource = dt;
            con.Close();


        }

        //Search tutor timetable by teaching level and subject
        public void SearchTimetable(string form, string subject)
        {
            //Search subject only
            con.Open();
            if (form == "" && subject != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Timetable Where Subject_Name = '" + subject + "'", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tutorTimetable.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }

            }
            //Search form only
            else if (form != "" && subject == "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Timetable Where Form = '" + form + "'", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tutorTimetable.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }

            }
            //Search form and subject
            else if (form != "" && subject != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Timetable Where Form = '" + form + "'And Subject_Name = '" + subject + "'", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tutorTimetable.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }
            }
            //Search nothing
            else if (form == "" && subject == "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Timetable", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tutorTimetable.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }
            }
        }

        //Auto generate student id
        public string StudentIdGeneration()
        {
            //When there is gap between id, for example 001 and 003, this will generate 002, if no, keep add on
            string id;
            int count = 1;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Studentid from Student_List Where Studentid Like 'Stu%'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string remove = (rd.GetString(0).Remove(0, 3));
                if (count != Convert.ToInt32(remove)) break;
                count++;
            }
            if (count < 10) id = "Stu00" + count.ToString();
            else if (count > 10 || count < 100) id = "Stu0" + count.ToString();
            else id = "Stu" + count.ToString();
            con.Close();
            return id;
        }

        //Prevent using of same username when enroll a student
        public string CheckNoSameName(string username)
        {
            string check = null;
            ArrayList studUsername = new ArrayList();

            con.Open();
            SqlCommand cmd = new SqlCommand("Select Username From Student_List",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                studUsername.Add(dr.GetString(0));
            }
            con.Close();
            for (int i = 0; i < studUsername.Count;++i)
            {
                string checkusername = (string)studUsername[i];
                if (username == checkusername)
                {
                    check = "Username has been used!";
                    
                    break;
                }
            }
            return check;

        }

        //Record enrolled student information into database
        public string EnrollStudent(string studId, string username, string password, string name, string email, string contact, string gender, DateTime dob, string form, DateTime enrlDate,Image image)
        {
            string status1;
            this.User_Profile_pic = image;

            con.Open();
            MemoryStream ms = new MemoryStream();
            User_Profile_pic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] photodata = ms.ToArray();
            SqlCommand cmd = new SqlCommand("Insert Into Student_List (Studentid,Username,Password,Name,Email,Contact,Gender,Dob,Form,User_Role,Enrollment,Profile_Image) Values ('" + studId + "','" + username + "','" + password + "','" + name + "','" + email + "','" + contact + "','" + gender + "',@a,'" + form + "','STUDENT',@b,@img)", con);
            cmd.Parameters.AddWithValue("@a", dob);
            cmd.Parameters.AddWithValue("@b", enrlDate);
            cmd.Parameters.AddWithValue("@img", photodata);
            int i = cmd.ExecuteNonQuery();
            if (i != -1 && i != 0)
            {
                status1 = "Enrollment done!";

            }
            else
            {
                status1 = "Enrollment failed!";

            }
            con.Close();
            return status1;
        }

        //Record the subject that student has choosen into database
        public string EnrollSubject(string studId, string classid, DateTime enrlDate)
        {
            string status2;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Student_Class (Studentid,Classid,Enrollment_Date) Values ('" + studId + "','" + classid + "',@a)", con);
            cmd.Parameters.AddWithValue("@a",enrlDate);
            int i = cmd.ExecuteNonQuery();
            if (i != -1 && i != 0)
            {
                status2 = "Enrollment done!";

            }
            else
            {
                status2 = "Enrollment failed!";

            }
            con.Close();
            return status2;

        }




        //About payment

        //Update the payment date when student successfully make the payment
        public string UpdatePaymentDate(string paymentid, string studid, DateTime paydate)
        {
            string status=null;
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Make_Payment SET Payment_Date = @a,Payment_status = 'Paid' Where Paymentid='" + paymentid + "' And Studentid='" + studid + "'", con);
            cmd.Parameters.AddWithValue("@a",paydate);
            int a = cmd.ExecuteNonQuery();

            if (a != -1 && a != 0)
            {
                MessageBox.Show("Paid!");


            }
            else
            {
                status = "Payment failed!";
                MessageBox.Show(status);

            }

            con.Close();
            return status;
        }

        //Shoow all the payment record in table form
        public void ShowAllNeededPayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Make_Payment", con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            makePayment.DataSource = dt;
            con.Close();
        }

        //Show the payment record that class fee is already paid by student
        public void ShowAllPaymentHistory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Make_Payment Where Payment_status='Paid'", con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentHistory.DataSource = dt;
            con.Close();
        }

        //Show payment record that is in "Paid" status start from the choosen date
        public void ShowMonthPaymentHistory(DateTime date)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Make_Payment Where Payment_status='Paid' And Payment_Date>@a", con);
            cmd.Parameters.AddWithValue("@a", date);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentHistory.DataSource = dt;
            con.Close();
        }

        //Search Paid record by level, subject name, and paid status of student
        public void SearchPaymentHistory(string form, string subjectname, string paidstatus)
        {
            // Search only Subject name
            con.Open();
            if (form == "" && subjectname != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Make_Payment Where Payment_status='"+ paidstatus +"' And Subject_id = (Select Subject_id From Subject_Table Where Subject_Name='"+ subjectname +"')", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentHistory.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }

            }
            //Search by form only
            else if (form != "" && subjectname == "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Make_Payment Where Payment_status='"+ paidstatus +"' And Form = '" + form + "'", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentHistory.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }

            }
            //Search by form, subject name and paid status
            else if (form != "" && subjectname != "" && paidstatus != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Make_Payment Where Payment_status='"+ paidstatus +"' And Form = '" + form + "' And Subject_id = (Select Subject_id From Subject_Table Where Subject_Name='" + subjectname + "')", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentHistory.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }
            }
            //Search without form and subject name
            else if (form == "" && subjectname == "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Make_Payment", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentHistory.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }
            }
            con.Close();
        }

        //Search all payment record no matter is paid or unpaid by student level and subject name
        public void SearchPayment(string form, string subjectname)
        {
            //Search with subject name
            con.Open();
            if (form == "" && subjectname != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Make_Payment Where Subject_id = (Select Subject_id From Subject_Table Where Subject_Name='" + subjectname + "')", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    makePayment.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }

            }
            //Search with form
            else if (form != "" && subjectname == "" )
            {
                SqlCommand cmd = new SqlCommand("Select * from Make_Payment Where Form = '" + form + "'", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    makePayment.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }

            }
            //Search with form and subject name
            else if (form != "" && subjectname != "" )
            {
                SqlCommand cmd = new SqlCommand("Select * from Make_Payment Where Form = '" + form + "' And Subject_id = (Select Subject_id From Subject_Table Where Subject_Name='" + subjectname + "')", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    makePayment.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }
            }
            //Search nothing
            else if (form == "" && subjectname == "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Make_Payment", con);
                try
                {

                    cmd.ExecuteReader();
                    con.Close();
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    makePayment.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid Selection!");
                }
            }
            con.Close();
        }

        //Search all payment record by the paid status
        public void PaymentByStatus(string payStatus)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Make_Payment Where Payment_status='"+ payStatus +"'", con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            makePayment.DataSource = dt;
            con.Close();
        }

        //Auto generate the payment id
        public string paymentIdGeneration()
        {
            //When there is gap between two id, fill in the gap, if no, keep add on
            string id;
            
            int count = 1;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Paymentid from Make_Payment Where Paymentid Like 'Pay%'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                
                string remove = (rd.GetString(0).Remove(0, 3));
                if (count != Convert.ToInt32(remove)) break;
                count++;
                
            }
            if (count < 10) id = "Pay00" + count.ToString();
            else if (count > 10 || count < 100) id = "Pay0" + count.ToString();
            else id = "Pay" + count.ToString();
            con.Close();
            return id;
            
        }

        //Return an array list that contain all class date of particular class up to 100 lesson amount
        public static ArrayList ClassAllDate(string classid)
        {

            int insertdatetotalcount = 99   ;
            ArrayList classdate = new ArrayList();
            DateTime dateofclass;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Start_Time From Timetable Where Classid='"+ classid +"'",con);
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read()) 
            {
                classdate.Add(rd.GetDateTime(0));
            }
            con.Close();
            dateofclass = (DateTime)classdate[0];
            DateTime date = dateofclass;
            ArrayList allclassdate= new ArrayList();
            allclassdate.Add(dateofclass);
            for (int i = 1; i<=insertdatetotalcount;++i)
            {

                date = date.AddDays(7);
                allclassdate.Add(date);
            }
            return allclassdate;
        }

        //Generate the payment based on class choosen by student
        public void StudentClassBasedPayment(DateTime payMonth)
        {
            //Generate needed payment for each student by loop
            ArrayList studid = new ArrayList();
            ArrayList studclassid = new ArrayList();
            ArrayList enrldate = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Studentid From Student_Class",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                studid.Add(dr.GetString(0));
            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Classid From Student_Class", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                studclassid.Add(dr2.GetString(0));
            }
            con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select Enrollment_Date From Student_Class", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                enrldate.Add(dr3.GetDateTime(0));
            }
            con.Close();
            for (int i = 0; i < studid.Count; ++i)
            {
                string studentid = (string)studid[i];
                string studentClassid = (string)studclassid[i];
                DateTime enrollmentDate = (DateTime)enrldate[i];
                ArrayList specificClassAllDate = new ArrayList();
                specificClassAllDate = ReceptionistClass.ClassAllDate(studentClassid);
                ReceptionistClass.RecordNeededPayment(specificClassAllDate,studentid,studentClassid,enrollmentDate,payMonth);
            }
            MessageBox.Show("All needed payment generated!");

        }

        //Record the payment of class choosen by student into database
        public static void RecordNeededPayment(ArrayList date, string enrlStudId, string classId, DateTime enrlDate, DateTime payMonth)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            string paymentId = obj1.paymentIdGeneration();


            ArrayList allClassDate = new ArrayList();
            allClassDate = date;
            DateTime singledate;
            ArrayList currentMonthClassDate = new ArrayList();


            for (int i = 0; i < allClassDate.Count; ++i)
            {
                DateTime payMonthLastDate = payMonth.AddMonths(1).AddDays(-1);
                int checkearlylate = DateTime.Compare(enrlDate, payMonth);
                int checkearlylate2 = DateTime.Compare(enrlDate,payMonthLastDate);
                singledate = (DateTime)allClassDate[i];
                //When last month is student enrollment month
                if (checkearlylate > 0 && checkearlylate2<=0)
                {
                    
                    if ((singledate.Month == enrlDate.Month) && (singledate.Year == enrlDate.Year))
                    {
                        currentMonthClassDate.Add(singledate);
                    }
                }




                //When student has enrolled before the first date of last month
                else if (checkearlylate < 0)
                {
                    if ((singledate.Month == payMonth.Month) && (singledate.Year == payMonth.Year))
                    {
                        currentMonthClassDate.Add(singledate);
                    }
                }
            }

           
            try
            {
                int weekClassCount = currentMonthClassDate.Count;
                int weekClassCount2 = currentMonthClassDate.Count - (1);
                //add the first date of next month for checking use in count the week class
                DateTime currentMonthLastClassDate = (DateTime)currentMonthClassDate[weekClassCount2];
                int changedCurrentMonthLastClassDate = currentMonthLastClassDate.AddMonths(1).Month;

                while (currentMonthLastClassDate.Month != changedCurrentMonthLastClassDate)
                {
                    currentMonthLastClassDate = currentMonthLastClassDate.AddDays(1);
                }
                currentMonthClassDate.Add((DateTime)currentMonthLastClassDate);

                /*When enroll date fall on class date or between class date and next class date, 
                no need to pay the fee of class date and class date before in current current in respective month*/
                int haveweekclass = 0;
                if (enrlDate < (DateTime)currentMonthClassDate[0])
                {
                    haveweekclass = currentMonthClassDate.Count - 1;

                }
                else
                {
                    for (int i = currentMonthClassDate.Count - 1; i >= 1; --i)
                    {

                        int result1 = DateTime.Compare(enrlDate, (DateTime)currentMonthClassDate[i - 1]);
                        int result2 = DateTime.Compare(enrlDate, (DateTime)currentMonthClassDate[i]);
                        int result3 = DateTime.Compare(enrlDate, (DateTime)currentMonthClassDate[i - 1]);
                        bool inbetween = result2 < 0 && result3 > 0; //if in berween, true
                        bool ondate = result1 == 0;


                        if (inbetween == false)
                        {
                            if (ondate == false)
                            {
                                haveweekclass += 1;
                            }

                            else if (ondate == true)
                            {
                                break;
                            }


                        }
                        else if (inbetween == true)
                        {
                            if (ondate == false)
                            {

                                break;
                            }
                        }




                    }
                }

                int classCharge;
                int totalFee;
                List<int> fee = new List<int>();


                con.Open();
                SqlCommand cmd = new SqlCommand("Select Charge from Timetable Where Classid = '" + classId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fee.Add(dr.GetInt32(0));


                }
                con.Close();


                classCharge = fee[0];
                //Count total charge of the month by single class charge and how many week that student would study at that month
                totalFee = classCharge * haveweekclass;

                con.Open();
                SqlCommand cmd2 = new SqlCommand("Insert Into Make_Payment (Paymentid,Studentid,Student_Name,Form,Subject_id,Fee,Payment_Date,Payment_status) Values ('" + paymentId + "','" + enrlStudId + "',(SELECT Name FROM Student_List Where Studentid='" + enrlStudId + "'),(SELECT Form FROM Student_List Where Studentid='" + enrlStudId + "'),(SELECT Subject_id FROM Timetable WHERE Classid='" + classId + "'),'" + totalFee + "',@a,'Unpaid')", con);
                cmd2.Parameters.AddWithValue("@a", enrlDate);
                int a = cmd2.ExecuteNonQuery();

                if (a != -1 && a != 0)
                {
                    

                }
                else
                {
                    MessageBox.Show("Needed Payment not recorded!");

                }

                con.Close();
                
            }
            catch
            {
                
            }

        }




        //About change subject request

        //Record the payment when student has dropped the class based on how many class the student has attended in that month
        public void RecordNeededPaymentWhenDropClass(DateTime dropDate, string classId, string studId)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            string paymentId = obj1.paymentIdGeneration();
            ArrayList classAllDate = new ArrayList();
            classAllDate = ReceptionistClass.ClassAllDate(classId);
            DateTime singledate;
            ArrayList currentMonthClassDate = new ArrayList();
            DateTime firstClassDate = (DateTime)classAllDate[0];
            int checkearlylate = DateTime.Compare(dropDate, firstClassDate);
            if (checkearlylate < 0)
            {

            }
            else
            {
                for (int i = 0; i < classAllDate.Count; ++i)
                {


                    singledate = (DateTime)classAllDate[i];
                    if ((singledate.Month == dropDate.Month) && (singledate.Year == dropDate.Year))
                    {
                        currentMonthClassDate.Add(singledate);
                    }

                }
                int weekClassCount = currentMonthClassDate.Count;
                int weekClassCount2 = currentMonthClassDate.Count - (1);
                //add the first date of next month for checking use in count the week class
                DateTime currentMonthLastClassDate = (DateTime)currentMonthClassDate[weekClassCount2];
                int changedCurrentMonthLastClassDate = currentMonthLastClassDate.AddMonths(1).Month;

                while (currentMonthLastClassDate.Month != changedCurrentMonthLastClassDate)
                {
                    currentMonthLastClassDate = currentMonthLastClassDate.AddDays(1);
                }

                currentMonthClassDate.Add((DateTime)currentMonthLastClassDate);

                /*When enroll date fall on class date or between class date and next class date, 
                no need to pay the fee of class date and class date before in current current in respective month*/
                int doneweekclass = currentMonthClassDate.Count - 1;
                if (dropDate < (DateTime)currentMonthClassDate[0])
                {
                    doneweekclass = 0;

                }
                else
                {
                    for (int i = currentMonthClassDate.Count - 1; i >= 1; --i)
                    {

                        int result1 = DateTime.Compare(dropDate, (DateTime)currentMonthClassDate[i - 1]);
                        int result2 = DateTime.Compare(dropDate, (DateTime)currentMonthClassDate[i]);
                        int result3 = DateTime.Compare(dropDate, (DateTime)currentMonthClassDate[i - 1]);
                        bool inbetween = result2 < 0 && result3 > 0; //if in between, true
                        bool ondate = result1 == 0;


                        if (inbetween == false)
                        {
                            if (ondate == false)
                            {
                                doneweekclass -= 1;
                            }

                            else if (ondate == true)
                            {
                                doneweekclass -= 1;
                                break;
                            }


                        }
                        else if (inbetween == true)
                        {
                            if (ondate == false)
                            {

                                break;
                            }
                        }

                    }
                }

                int classCharge;
                int totalFee;
                List<int> fee = new List<int>();


                con.Open();
                SqlCommand cmd = new SqlCommand("Select Charge from Timetable Where Classid = '" + classId + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fee.Add(dr.GetInt32(0));


                }
                con.Close();


                classCharge = fee[0];
                //Count total charge of the month by single class charge and how much fee need to pay based on how many week that student has studied at that month
                totalFee = classCharge * doneweekclass;

                con.Open();
                SqlCommand cmd2 = new SqlCommand("Insert Into Make_Payment (Paymentid,Studentid,Student_Name,Form,Subject_id,Fee,Payment_Date,Payment_status) Values ('" + paymentId + "','" + studId + "',(SELECT Name FROM Student_List Where Studentid='" + studId + "'),(SELECT Form FROM Student_List Where Studentid='" + studId + "'),(SELECT Subject_id FROM Timetable WHERE Classid='" + classId + "'),'" + totalFee + "',@a,'Unpaid')", con);
                cmd2.Parameters.AddWithValue("@a", dropDate);
                int a = cmd2.ExecuteNonQuery();

                if (a != -1 && a != 0)
                {
                    MessageBox.Show("Needed payment recorded!");

                }
                else
                {
                    MessageBox.Show("Needed Payment not recorded!");

                }

                con.Close();
            }
        }  

        //Display all the class dropping request of student
        public void ShowAllDropRequest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Request_drop",con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            requestDrop.DataSource = dt;
            con.Close();

            
        }

        //Display all the class adding reclass of student
        public void ShowAllAddRequest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Request_add", con);
            cmd.ExecuteReader();
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            requestAdd.DataSource = dt;
            con.Close();
        }

        //Check the student's payment status before making an operation
        public string CheckPaymentStatus(string studId)
        {
            string check=null;
            ArrayList paymentStatus = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Payment_status From Make_Payment Where Studentid = '" + studId + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                paymentStatus.Add(dr.GetString(0));
            }
            con.Close();
            for (int i = 0; i < paymentStatus.Count; ++i)
            {
                string status = (string)paymentStatus[i];
                if (status == "Unpaid")
                {
                    check = "This student haven't clear the payment!";
                    break;
                }
            }
            
            return check;
        }

        //Accept the student request on dropping class
        public void AcceptStudentDropSubject(string studId, string classId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" Delete From Student_Class Where Studentid =@a And Classid =@b",con);
            cmd.Parameters.AddWithValue("@a",studId);
            cmd.Parameters.AddWithValue("@b", classId);
            int i = cmd.ExecuteNonQuery();
            if ( i != 0)
            {
                
                SqlCommand cmd2 = new SqlCommand("Update Request_drop SET Request_Status = 'Accepted' Where Studentid = '"+ studId +"' And Classid = '"+ classId +"'",con);
                MessageBox.Show("Class dropped successful!");
                int a = cmd2.ExecuteNonQuery();
                if (a == -1 || a==0 )
                {
                    MessageBox.Show("Drop class request status is failed to update!");
                }
                else
                {
                    DateTime dropClassDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    ReceptionistClass obj1 = new ReceptionistClass();
                    con.Close();
                    obj1.RecordNeededPaymentWhenDropClass(dropClassDate, classId, studId);
                }

            }
            else
            {
                MessageBox.Show("Class dropped failed! There is no record that student has enrolled into this class!");

            }
            con.Close();

        }

        //Accept the student request on adding class
        public void AcceptStudentAddSubject(string studId, string classId)
        {
            ArrayList StudentId = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Studentid From Student_Class Where Studentid='"+ studId +"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StudentId.Add(dr.GetString(0));
            }

            //Check student has reach maximum number of enrolled class or not
            con.Close();
            if (StudentId.Count >= 3)
            {
                MessageBox.Show("Student has already enrolled three class! ");
            }
            
            //Student can enroll as there has capacity for enrollment into the class because haven't reach the maximum number of class
            else
            {
                List<string> studentClassId = new List<string>();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Select Classid From Student_Class Where Studentid='"+ studId +"'",con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read()) 
                { 
                    studentClassId.Add(dr1.GetString(0));
                }
                con.Close();
                //When student want to add same class that has enrolled
                if (studentClassId.Contains(classId))
                {
                    MessageBox.Show("This student has enrolled into the same class already!");
                }
                //When student add different class
                else
                {
                    DateTime enrlDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand(" Insert Into Student_Class (Studentid,Classid,Enrollment_Date) Values( '" + studId + "', '" + classId + "',@a)", con);
                    cmd2.Parameters.AddWithValue("@a", enrlDate);
                    int i = cmd2.ExecuteNonQuery();
                    if (i != -1 && i != 0)
                    {
                        MessageBox.Show(classId + ": " + "Class added successful!");
                        SqlCommand cmd3 = new SqlCommand("Update Request_add SET Request_Status = 'Accepted' Where Studentid = '" + studId + "' And Classid = '" + classId + "'", con);
                        int a = cmd3.ExecuteNonQuery();
                        if (a == -1 || a == 0)
                        {
                            MessageBox.Show("Add class request status is failed to update!");
                        }

                    }
                    else
                    {
                        MessageBox.Show(classId + ": " + "Class added failed");

                    }
                    con.Close();
                }
                
            }
            
        }






    }


}
