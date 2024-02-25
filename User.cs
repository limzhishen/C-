using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_GROUP_22
{
    internal class User
    {
        private string Username;
        private string Password;
        static SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public User(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public string LoginUser()
        {
            string user="";
            Con.Open();
            SqlCommand cmd  = new SqlCommand("Select Count(*) from User_info where Username=@name and Password=@pass",Con);
            cmd.Parameters.AddWithValue("@name", Username);
            cmd.Parameters.AddWithValue("@pass", Password);
            int i = Convert.ToInt32( cmd.ExecuteScalar());
            Con.Close();
            if (i ==1) 
            {
                Con.Open();
                SqlCommand cmd2 = new SqlCommand("Select User_role,Userid from User_info where Username=@name and Password=@pass", Con);
                cmd2.Parameters.AddWithValue("@name", Username);
                cmd2.Parameters.AddWithValue("@pass", Password);
                SqlDataReader rd=cmd2.ExecuteReader();
                while(rd.Read())
                {
                    user += rd.GetString(0);
                    user += ","+rd.GetString(1); 
                }
                Con.Close();
            }
            
            if (user == "")
            {
                Con.Open();
                SqlCommand cmd3 = new SqlCommand("Select Count(*) from Student_List where Username=@name and Password=@pass", Con);
                cmd3.Parameters.AddWithValue("@name", Username);
                cmd3.Parameters.AddWithValue("@pass", Password);
                int j = Convert.ToInt32(cmd3.ExecuteScalar());
                Con.Close();
                if (j == 1) 
                {
                    Con.Open();
                    SqlCommand cmd4 = new SqlCommand("Select User_role,Studentid from Student_List where Username=@name and Password=@pass", Con);
                    cmd4.Parameters.AddWithValue("@name", Username);
                    cmd4.Parameters.AddWithValue("@pass", Password);
                    SqlDataReader rd=cmd4.ExecuteReader();
                    while(rd.Read())
                    {
                        user += rd.GetString(0);
                        user+= ","+rd.GetString(1);
                    }
                    Con.Close();
                }
            }
            return user;
        }
    }
}
