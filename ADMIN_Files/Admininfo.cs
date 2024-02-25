using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IOOP_GROUP_22
{
    internal class Admininfo
    {

        //field
        private string userid;
        private string username;
        private string password;
        private string name;
        private string email;
        private string contact;
        private string gender;
        private DateTime dob;
        private string user_role;
        private Image profile_image;
        private string update_image;
        static SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        //properties
        public string Email { get => email; set => email = value; }
        public string User_role { get => user_role; set => user_role = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public Image Profile_image { get => profile_image; set => profile_image = value; }


        #region Constructor
        public Admininfo() { }
        public Admininfo(string id)
        {
            userid = id;
        }
        public Admininfo(string userid,string username, string password)//Constructor
        {
            this.userid = userid;
            this.username = username;
            this.password = password;
        }
        public Admininfo(string userid, string username, string password, string name, string email, string contact, string gender, DateTime dob, string Profile_imgage)
        {
            this.userid = userid;
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.gender = gender;
            this.dob = dob;
            this.update_image = Profile_imgage;
        }
        #endregion 


        public static void Getinformation(Admininfo id)//To get the respective information from database
        {
            Con.Open(); 
            SqlCommand cmd = new SqlCommand("Select * from User_Info where Userid='" + id.userid + "'", Con);
            SqlDataReader rd = cmd.ExecuteReader();//read the data
            while (rd.Read())
            {
                //assignment the data to poperties
                id.Username = rd.GetString(1);
                id.Password = rd.GetString(2);
                id.Name = rd.GetString(3);
                id.Email = rd.GetString(4);
                id.Contact = rd.GetString(5);
                id.Gender = rd.GetString(6);
                id.Dob = rd.GetDateTime(7);
                id.User_role = rd.GetString(8);
                

            }
            Con.Close();
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);//To get the respective profile_image
            DataSet ds = new DataSet();
            da.Fill(ds);
            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Profile_image"]);
            id.Profile_image = new Bitmap(ms);
            Con.Close();

        }


        public static byte[] dataimage(string filename)
        {
            FileStream fs= new FileStream(filename,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            return br.ReadBytes((int)fs.Length);          
        }
        public string updateprofile()//update the admin own profile
        {
            byte[] photodata = null;//Create a empty byte for store the image with format varbinary
            string query = "Update User_info set Username=@user,Password=@password,Name=@name,Email=@email,Contact=@contact,Gender=@gender,Dob=@dob where Userid=@userid";
            if (update_image != "")//To check that have upload the new photo
            {
                photodata = dataimage(update_image);//using method to change image to varbinary type
                query = "Update User_info set Username=@user,Password=@password,Name=@name,Email=@email,Contact=@contact,Gender=@gender,Dob=@dob ,Profile_image=@photo where Userid = @userid";

            }
            string status = "Fail to update";

            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            if (update_image != "") cmd.Parameters.AddWithValue("@photo", photodata);

            int i = cmd.ExecuteNonQuery();//receive the status of update
            if (i != 0) status = "Sucessful to update";
            Con.Close();
            return status;
        }
        public Array valid()//valid the username and password that update in User manage 
        {
            string[] array = { };//Create a empty array
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Username,Password,Userid from User_info ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().ToLower() == username.ToString().ToLower() && dr[1].ToString().ToLower() == password.ToString().ToLower())// if username and password match with other where will cause error
                {
                    if (userid == dr[2].ToString())
                    {
                        Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same with original"; 
                    }
                    else
                    {
                        Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same with other";
                    }
                }
            }
            Con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Username,Password,Studentid from Student_List ", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Con.Close();
            foreach (DataRow dr in dt2.Rows)
            {
                if (dr[0].ToString().ToLower() == username.ToString().ToLower() && dr[1].ToString().ToLower() == password.ToString().ToLower())
                {
                    if (userid == dr[2].ToString())
                    {
                        Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same with original";
                    }
                    else
                    {
                        Array.Resize(ref array, array.Length + 1); array[array.Length - 1] = "Username and Password is same with other";
                    }
                }
            }
            return array;
        }
        public string Change_Username_Password()// Update the repective username and password that have change and valid in user manage
        {
            string status = "Fail to update";
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update User_info SET Username=@username, Password=@pass where userid=@user", Con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@user", userid);
            int i = cmd.ExecuteNonQuery();
            if (i != 0) status = "Sucessful to update";
            Con.Close();
            return status;
        }
        public string DeleteUser(string id)//Delete the user in database by using their id
        {
            string status = "Fail to update";
            if (id.Substring(0, 3) == "Rec") //if id is receptionist only delete from database
            {
                
                Con.Open();
                SqlCommand cmd = new SqlCommand("Delete from User_info where userid='" + id + "'",Con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0) status = "Sucessful to update";
                Con.Close();
            }
            else if(id.Substring(0,5)=="Tutor")//if id is tutor cannot delete direct, because of primary key and foreign key in database settings, need delete all foreign key
            {
                
                List<string> classid = new List<string>();//one tutor may have many class so using the list to store all class id that create by this tutor
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Classid from Timetable where userid='"+id+"'",Con);
                DataTable da= new DataTable();
                sda.Fill(da);//store data in datatable
                Con.Close();
                foreach(DataRow row in da.Rows)//use foreach to add the data row by row
                {
                    classid.Add(row[0].ToString());//the classid is store in the first row
                }
                foreach (string clsid in classid)//delete each foreign key class id in student_class table
                {
                    Con.Open();
                    SqlCommand cmd2 = new SqlCommand("Delete from Student_Class where Classid=@classid", Con);
                    cmd2.Parameters.AddWithValue("@classid", clsid);
                    cmd2.ExecuteNonQuery();
                    Con.Close();
                }
                foreach (string clsid in classid)//delete each foreign key class id in Request_add table
                {
                    Con.Open();
                    SqlCommand cmd2 = new SqlCommand("Delete from Request_add where Classid=@classid", Con);
                    cmd2.Parameters.AddWithValue("@classid", clsid);
                    cmd2.ExecuteNonQuery();
                    Con.Close();
                }
                foreach (string clsid in classid)//delete each foreign key class id in Request_drop table
                {

                    Con.Open();
                    SqlCommand cmd2 = new SqlCommand("Delete from Request_drop where Classid=@classid", Con);
                    cmd2.Parameters.AddWithValue("@classid", clsid);
                    cmd2.ExecuteNonQuery();
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd3 = new SqlCommand("Delete from Timetable where Userid='" + id + "'",Con);
                cmd3.ExecuteNonQuery();
                Con.Close();
                Con.Open();
                SqlCommand cmd4 = new SqlCommand("Delete from Tutor_subject where Userid='" + id + "'", Con);
                cmd4.ExecuteNonQuery();
                Con.Close();
                Con.Open();
                SqlCommand cmd5 = new SqlCommand("Delete from Tutor_Form where Userid='" + id + "'", Con);
                cmd5.ExecuteNonQuery();
                Con.Close();
                Con.Open();
                SqlCommand cmd6 = new SqlCommand("Delete from User_info where userid='" + id + "'",Con);
                int i =cmd6.ExecuteNonQuery();//if tutor can delete in user_info table(primary key) with sucessfull, that mean another table is delete with sucessfull
                Con.Close();
                if (i != 0)
                {
                    status = "Successful to update";
                }

            }
            return status;
        }
    }
}
