using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_GROUP_22
{
    internal class EditTimetable
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private DataGridView timetable;
        private DataGridView requestadd;
        private DataGridView requestdrop;
        private string studentid;
        private string classid;

        public DataGridView Timetable { get => timetable; set => timetable = value; }
        public DataGridView Requestadd { get => requestadd; set => requestadd = value; }
        public DataGridView Requestdrop { get => requestdrop; set => requestdrop = value; }
        public string StudentID { get => studentid; set => studentid = value; }
        public string Classid { get => classid; set => classid = value; }

        public EditTimetable(string Studentid) 
        {
            this.StudentID = Studentid;
        }

        public EditTimetable(string Studentid, string classid) 
        {
            this.StudentID = Studentid;
            this.Classid = classid;
        }

        // retrieves all the subjects from the Subject_Table in the database and returns an array of strings
        public static Array getSubject() // retrieved subjects are stored in a string array
        {
            string[] subject = { };
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Subject_Name from Subject_Table", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            foreach (DataRow dr in data.Rows) // iterates through each row of the DataTable to resize the string array
            {
                Array.Resize(ref subject, subject.Length + 1);
                subject[subject.Length - 1] = dr[0].ToString();
            }
            con.Close();
            return subject; // the method returns the populated string array.
        }

        public void getAllTimetable()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter ( "select * from Timetable where Form=(select Form from Student_List where Studentid= '" + StudentID + "')", con );
            DataTable data = new DataTable();
            sda.Fill(data);
            Timetable.DataSource= data;
            con.Close();

        }
        public void SearchAllTimetable(string subject)
        {
            // use the SQL to query the database
            string query = "select * from Timetable where Form=(select Form from Student_List where StudentID='" + StudentID + "')";
            if (subject != "Subject")
            {
                query += " AND Subject_Name='" + subject + "'";
            }
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con); // Retrieve the required data using a SqlDataAdapter object
            DataTable data = new DataTable(); // The retrieved data is stored in a DataTable object
            sda.Fill(data);
            Timetable.DataSource= data; // assigned to the DataSource property of the Timetable component
            con.Close();
        }

        public string Request_add() 
        {
            string status = "Fail to update";
            string Req_add = addidgenerator(); // generates a unique ID for a new add request
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Request_add values (@add, @stuid, @clsid, @status)", con); // inserts a new record in the Request_add table
            cmd.Parameters.AddWithValue("@add", Req_add);
            cmd.Parameters.AddWithValue("@stuid", StudentID);
            cmd.Parameters.AddWithValue("@clsid", Classid);
            cmd.Parameters.AddWithValue("@status", "Unaccepted");
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Successful to update!";
            }
            con.Close();
            return status;
        }

        private string addidgenerator() 
        {
            int i = 1;
            int count = 1;
            string id;
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select Request_addid from Request_add", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            while (i < 5) // checks each integer value from 1 to 5 against the numbers within the "Request_addid" values
            {
                i = 1; // the loop continues to the next integer
                foreach (DataRow dr in dt.Rows)
                {
                    string remove = (dr[0].ToString().Remove(0,4));
                    if (Convert.ToInt32(remove) == count) { i = 2; } 
                }
                if (i == 2) { count++; }
                else break;
            }
            // the unique ID is created using the count variable
            if (count < 10) id = "Read00" + count.ToString();
            else if (count > 10 || count < 100) id = "Read0" + count.ToString();
            else id = "Read" + count.ToString();
            con.Close();
            return id;
        }
        public int addvalidation()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Student_Class where Classid in (select Classid from Student_Class where Studentid='" + StudentID + "')", con); // count of records in a table
            // / The result of the count is converted to an integer and returned as output
            int i = Convert.ToInt32(cmd.ExecuteScalar().ToString()); // uses the SqlCommand and ExecuteScalar methods to execute the SQL command and retrieve the scalar value
            con.Close();
            return i;

        }
        public int samevalidation()
        {
            int i = 0;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select classid from Student_Class where Studentid='" + StudentID + "'", con);
            DataTable da = new DataTable();
            sda.Fill(da);
            foreach(DataRow dr in da.Rows) 
            {
                if (dr[0].ToString() == Classid) { i=1; }
            }
            con.Close();
            return i;
        }

        public string Request_drop()
        {
            string status = "Fail to update";
            string Req_drop = dropidgenerator(); // generates a unique ID for a new add request
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Request_drop values (@drop, @stuid, @clsid, @status)", con);
            cmd.Parameters.AddWithValue("@drop", Req_drop);
            cmd.Parameters.AddWithValue("@stuid", StudentID);
            cmd.Parameters.AddWithValue("@clsid", Classid);
            cmd.Parameters.AddWithValue("@status", "Unaccepted");
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Successful to update!";
            }
            con.Close();
            return status;

        }


        private string dropidgenerator()
        {
            int i = 1;
            int count = 1;
            string id;
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select Request_dropid from Request_drop", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            while (i < 5) // checks each integer value from 1 to 5 against the numbers within the "Request_addid" values
            {
                i = 1; // the loop continues to the next integer
                foreach (DataRow dr in dt.Rows)
                {
                    string remove = (dr[0].ToString().Remove(0, 4));
                    if (Convert.ToInt32(remove) == count) { i = 2; }
                }
                if (i == 2) { count++; }
                else break;
            }
            // the unique ID is created using the count variable
            if (count < 10) id = "Redr00" + count.ToString();
            else if (count > 10 || count < 100) id = "Redr0" + count.ToString();
            else id = "Redr" + count.ToString();
            con.Close();
            return id;

        }
        public string validAddRequest()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Request_add where Studentid=@student and Classid=@class and Request_Status='Unaccepted'", con);
            cmd.Parameters.AddWithValue("@student", StudentID);
            cmd.Parameters.AddWithValue("@class", Classid);
            string i = cmd.ExecuteScalar().ToString();
            con.Close() ;
            return i;
        }
        public int validalready()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) from Request_add where Studentid=@student and Request_Status='Unaccepted'", con);
            cmd.Parameters.AddWithValue("@student", StudentID);
            int i = Convert.ToInt32( cmd.ExecuteScalar());
            con.Close();
            return i;
        }
        public string validdropalready()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Count(*) from Request_drop where Studentid=@student and Classid=@class and Request_Status='Unaccepted'", con);
            cmd.Parameters.AddWithValue("@student", StudentID);
            cmd.Parameters.AddWithValue("@class", Classid);
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
        public void showRequestadd(string select)
        {
            con.Open();
            string query = "select * from Request_add where Studentid='" + StudentID + "'";
            if (select != "") { query += " and Request_Status='Unaccepted'"; }//adds a condition to the query to only retrieve records with a Request_Status of "Unaccepted"
            SqlCommand cmd = new SqlCommand(query,con);// The query is passed to a SqlCommand object called cmd
            SqlDataAdapter sda=new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data); // fill a new DataTable object called data with the results of the query
            Requestadd.DataSource = data;
            con.Close();
        }

        public void showRequestdrop(string select)
        {
            con.Open();
            string query = "select * from Request_drop where studentid ='" + StudentID + "'";
            if (select != "") { query += " and Request_Status='Unaccepted'"; }
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            Requestdrop.DataSource = data;
            con.Close();
        }
        public string deleteaddrequest()
        {
            string status = "Fail to update";
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Request_add where Request_addid='" + StudentID + "'", con);
            int i=cmd.ExecuteNonQuery();
            if(i!=0)
            {
                status = "Success!";
            }
            con.Close();
            return status;
        }
        public string deletedroprequest()
        {
            string status = "Fail to update"; // initializes a string variable named "status" with a default value of "Fail to update"
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Request_drop where Request_dropid='" + StudentID + "'", con); // creates a instance of the SqlCommand class
            // executes the command using the "ExecuteNonQuery" method
            int i = cmd.ExecuteNonQuery(); //stores the result in an integer variable named "i"
            if (i != 0) // at least one record was deleted
            {
                status = "Success!";
            }
            con.Close();
            return status; // returns the value of the "status" variable
        }
    }
}
