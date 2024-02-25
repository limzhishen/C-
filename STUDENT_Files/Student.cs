using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace IOOP_GROUP_22
{
    internal class Student
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private DataGridView firstTimetable;

        private string name;
        private string email;
        private string studentID;
        private string gender;
        private string form;
        private string username;
        private string password;
        private string contact;
        private DateTime dob;
        private string enrollment;
        private Image profile_image;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Form { get => form; set => form = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Contact { get => contact; set => contact = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Enrollment { get => enrollment; set => enrollment = value; }
        public Image Profile_image { get => profile_image; set => profile_image = value; }
        public DataGridView FirstTimetable { get => firstTimetable; set => firstTimetable = value; }

        // This constructors takes in a student ID
        public Student(string StudentID)
        { 
            this.StudentID= StudentID;
        }

        //This constructors takes in all the properties of a student
        public Student(string StudentID, string Name, string Email, string Gender, string Form, string Username, string Password, string Contact, DateTime Dob, string Enrollment)
        {
            this.StudentID = StudentID;
            this.Name = Name;
            this.Email = Email;
            this.Gender = Gender;
            this.Form = Form;
            this.Username = Username;
            this.Password = Password;
            this.Contact = Contact;
            this.Dob = Dob;
            this.Enrollment = Enrollment;
        }

        public void showtimetable() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Timetable where Classid in (select Classid from Student_Class where Studentid ='" + StudentID + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FirstTimetable.DataSource= dt;
            con.Close();
        }
        public void getprofile()
        { 
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Student_List where Studentid =@userid", con);
            // add a parameter to the SqlCommand object using the Parameters collection and the AddWithValue method 
            cmd.Parameters.AddWithValue("@userid", StudentID);// This allows to pass a value for the "@userid" parameter
            SqlDataReader rd = cmd.ExecuteReader(); // This object is used to read the data returned by the SELECT statement
            while (rd.Read()) 
            {
                Username= rd.GetValue(1).ToString();
                Password= rd.GetValue(2).ToString();
                Name= rd.GetValue(3).ToString();
                Email= rd.GetValue(4).ToString();
                Contact= rd.GetValue(5).ToString();
                Gender= rd.GetValue(6).ToString();
                Dob = rd.GetDateTime(7);
                Form= rd.GetValue(8).ToString();
                Enrollment= rd.GetValue(10).ToString();
                
            }
            con.Close();

            // The Fill method of the SqlDataAdapter is used to populate the DataSet with the results of the query
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Profile_image"]);
            Image image = new Bitmap(ms);
            con.Close();
            Profile_image=image; // assign the Bitmap object to an instance variable of the class
        }



        public string editprofile()
        {
            string status = null;
            con.Open();
            MemoryStream ms = new MemoryStream();
            Profile_image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);// save the Profile_image to it as a PNG
            byte[] profPhoto= ms.ToArray();// convert the MemoryStream to a byte array using the ToArray method
            // add parameters to the SqlCommand object using the Parameters collection and the AddWithValue method
            SqlCommand cmd = new SqlCommand("UPDATE Student_List SET Username =@user, Password =@pass, Name =@name, Email= @em, Contact =@num, Gender =@gen, Dob =@dob, Profile_image =@primg where studentID=@userid", con);
            cmd.Parameters.AddWithValue("@userid", StudentID);
            cmd.Parameters.AddWithValue("@user", Username);
            cmd.Parameters.AddWithValue("@pass", Password);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@em", Email);
            cmd.Parameters.AddWithValue("@num", Contact);
            cmd.Parameters.AddWithValue("@gen", Gender);
            cmd.Parameters.AddWithValue("@dob", Dob);
            cmd.Parameters.AddWithValue("@primg", profPhoto);

            int i = cmd.ExecuteNonQuery();// returns the number of rows affected by the update

            if (i != 0)
            {
                status = "Success!";
            }

            else status = "Unable";
            con.Close();

            return status; // return the "status" variable

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
            if (Convert.ToDateTime(Dob) > DateTime.Today)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "Select the true of your Date of Birth";
            }
            if (username.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the username";
            }
            if (password.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the password";
            }
            if (name.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the name";
            }
            if (gender.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please check either of the gender";
            }
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Username,Password,Userid from User_info ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().ToLower() == username.ToString().ToLower() && dr[1].ToString().ToLower() == password.ToString().ToLower())
                {
                    if (StudentID != dr[2].ToString())
                    { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same"; }
                }
            }
            con.Close();
            con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Username,Password,Studentid from Student_List ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().ToLower() == username.ToString().ToLower() && dr[1].ToString().ToLower() == password.ToString().ToLower())
                {
                    if (StudentID != dr[2].ToString())
                    { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same"; }
                }
            }
            con.Close();
            return array;
        }

    }
}
