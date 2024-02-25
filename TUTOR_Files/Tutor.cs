using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_GROUP_22
{
    internal class Tutor
    {
        //attributes(variables)

        // Opening Sql SqlConnection
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string userid;
        private string username;
        private string password;
        private string name;
        private string email;
        private string contact;
        private string gender;
        private DateTime dateOfBirth;
        private string userRole;
        private Image profileImage;



        //Constructors
        //Constructor is used to complete the initial work.
        //Constructor can pass the parameters we need and write the required methods.
        public Tutor(string userid)
        {
            Userid = userid;
        }


        public Image ProfileImage { get => profileImage; set => profileImage = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Userid { get => userid; set => userid = value; }

        public Tutor(string id,string un, string p, string n, string e, string c, DateTime d, string g)
        {
            this.userid = id;
            this.username = un;
            this.password = p;
            this.name = n;
            this.email = e;
            this.contact = c;
            this.dateOfBirth = d;
            this.gender = g;
            //this.image = image;


        }

        //This method is used to read the tutor profile from the query. 
        public static void getProfileDetail(Tutor id)
        {
            con.Open();// Open the connection
            //This query is to find the information of the person who logs in to the system and display it in the profile.
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_info WHERE Userid = '" +id.Userid + "'", con);
            //DataReader is the way to read data.
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //When overridden in a class, decodes the specified number of bytes starting at the specified address into a string.
                id.Username = rd.GetString(1);
                id.Password = rd.GetString(2);
                id.Name = rd.GetString(3);
                id.Email = rd.GetString(4);
                id.Contact = rd.GetString(5);
                id.Gender = rd.GetString(6);
                id.DateOfBirth = rd.GetDateTime(7);
                id.UserRole = rd.GetString(8);


                }
                //status = "Successful";
            //}
            //else status = "Unable";
            con.Close(); // Close the connection
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //Use memory stream to read pictures.
            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Profile_image"]);
            id.ProfileImage = new Bitmap(ms);
            con.Close();
            //return status;

        }

        public string editProfile()
        {
            //zbyte[] Imagedata = dataimage(image);
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            MemoryStream ms = new MemoryStream();
            ProfileImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] Imagedata = ms.ToArray();
            SqlCommand cmd = new SqlCommand("Update User_info SET Username=@username,Password=@pass,Name=@name,Email=@email,Contact=@contact,Gender=@gender,Dob=@dob,Profile_image=@profileimage WHERE Userid=@userid", con);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dateOfBirth);
            cmd.Parameters.AddWithValue("@profileimage", Imagedata);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Successful!";
            }
            else status = "Unable";
            con.Close();

            return status;
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
            if (dateOfBirth > DateTime.Today)
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
                    if (userid != dr[2].ToString())
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
                    if (userid != dr[2].ToString())
                    { Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same"; }
                }
            }
            con.Close();
            return array;
        }


    }
}
