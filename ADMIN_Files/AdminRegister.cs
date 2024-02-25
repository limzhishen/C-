using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_GROUP_22
{
    internal class AdminRegister
    {
        private string userid;
        private string username;
        private string password;
        private string name;
        private string email;
        private string contact;
        private string gender;
        private DateTime dob;
        private string level;
        private string subject;
        private string Profile_image;
        
        
        static SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        #region Constructor

        public AdminRegister(string userid, string username, string password, string name, string email, string contact, string gender, DateTime dob, string Profile_imgage)
        {
            this.userid = userid;
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.gender = gender;
            this.dob = dob;
            this.Profile_image = Profile_imgage;
            //this.user_type = user_type;
        }
        public AdminRegister( string username, string password, string name, string email, string contact, string gender, DateTime dob,string Profile_imgage)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.gender = gender;
            this.dob = dob;
            this.Profile_image= Profile_imgage;
        }
        public AdminRegister(string level,string subject)
        {
            this.level = level;
            this.subject = subject;
        }
        #endregion

        #region validation
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
            
            if (contact.Length == 0 || contact.Length == 1|| contact.Length==2) 
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "Please Fill in the contact";
            }

            else if (contact.Length>2)
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
            if (dob>DateTime.Today)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "Select the true of your Date of Birth";
            }
            if(username.Length == 0) 
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the username";
            }
            if (password.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the password";
            }
            if(name.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please fill in the name";
            }
            if (gender.Length == 0)
            {
                Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Please check either of the gender";
            }
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Username,Password,Userid from User_info ", Con);
            DataTable dt= new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().ToLower() == username.ToString().ToLower() && dr[1].ToString().ToLower()==password.ToString().ToLower())
                {
                    if (userid != dr[2].ToString())
                    { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same"; }
                }
            }
            Con.Close() ;
            Con.Open() ;
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Username,Password,Studentid from Student_List ", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().ToLower() == username.ToString().ToLower() && dr[1].ToString().ToLower() == password.ToString().ToLower())
                {
                    if (userid != dr[2].ToString())
                    { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same"; }
                }
            }
            Con.Close();
            return array;
        }

        public Array levelsubject()//validation of check have check the form and subject
        {

            string[] array = { };
            string[] assign_level = level.Split(",");
            string[] assign_subject = subject.Split(",");
            if (level.Length == 0) { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Check either one Form"; }
            if (subject.Length == 0) { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Check either one subject"; }
            return array;
        }
        #endregion

        #region register

        public string register_Recption()
        {
            byte[] photodata = Admininfo.dataimage(Profile_image);
            string status = "Fail to update";
            userid = idgeneration("Recption");
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into User_info values (@userid,@user,@password,@name,@email,@contact,@gender,@dob,'RECEPTIONIST',@image)", Con);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@image", photodata);
            int i = cmd.ExecuteNonQuery();
            if (i != 0) status = "Sucessful to register";
            Con.Close();
            return status;
        }
        public string register_Tutor(string id)//register tutor
        {
            byte[] photodata = Admininfo.dataimage(Profile_image);//convert the image to varbinary
            string status = "Fail to update";

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into User_info values (@userid,@user,@password,@name,@email,@contact,@gender,@dob,'TUTOR',@image)", Con);
            cmd.Parameters.AddWithValue("@userid", id);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@image", photodata);
            int i = cmd.ExecuteNonQuery();
            if (i != 0) status = "Sucessful to register";
            Con.Close();
            return status;
        }
        public string idgeneration(string user)//generate the userid by transfer attribute to find which repective userid
        {
            string id;//hold id for return
            int count = 1;
            if (user == "Tutor") 
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select Userid from User_info where Userid like'Tutor%' ORDER BY Userid ASC", Con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string remove = (rd.GetString(0).Remove(0, 5));//remove the first five character
                    if (count != Convert.ToInt32(remove)) break;//if number no same with the number from database will break 
                    count++;
                }
                if (count < 10) id = "Tutor00" + count.ToString();//Add the corresponding user name back
                else if (count > 10 || count < 100) id = "Tutor0" + count.ToString();
                else id = "Tutor" + count.ToString();
                Con.Close();
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select Userid from User_info where Userid like'Rec%' ORDER BY Userid ASC", Con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string remove = (rd.GetString(0).Remove(0, 3));
                    if (count != Convert.ToInt32(remove)) break;
                    count++;
                }
                if (count < 10) id = "Rec00" + count.ToString();
                else if (count > 10 || count < 100) id = "Rec0" + count.ToString();
                else id = "Rec" + count.ToString();
                Con.Close();
            }
            return id;
            
        }


        public string tutor_Levelregister(string id)//Assignment the tutor form and subject after register
        {
            string status = "Fail to update";
            string[] array = {};
            string[] assign_level = level.Split(",");
            string[] assign_subject = subject.Split(",");
            foreach(string l in assign_level)
            {
                if (l != "") 
                {
                    status = "Fail to update";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Tutor_Form values('" + id + "','" + l + "' )", Con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        status = "Sucessful to register";
                    }
                    else break;
                    Con.Close();
                }
            }
            foreach (string s in assign_subject)
            {
                status = "Fail to update";
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tutor_subject values('" + id + "',(Select Subject_id from Subject_Table where Subject_Name='" + s + "' ))", Con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Sucessful to register";
                }
                else break;
                Con.Close();
            }
            return status;
        }
        #endregion

    }
}
