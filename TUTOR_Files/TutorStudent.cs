using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml;

namespace IOOP_GROUP_22
{
    internal class TutorStudent
    {
        //attributes(variables)

        // Opening Sql SqlConnection
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string userID;
        private string classID;
        private string enrollmentDate;
        private DataGridView studentList;

        public DataGridView StudentList { get => studentList; set => studentList = value; }


        //Constructors
        //Constructor is used to complete the initial work.
        //Constructor can pass the parameters we need and write the required methods.
        public TutorStudent()
        {

        }
        public TutorStudent(string ui)
        {
            userID = ui;
        }

        public TutorStudent(string ui, string ci, string ed)
        {
            userID = ui;
            classID = ci;
            enrollmentDate = ed;

        }

        //This method is used to display the student list of all students taught by the specified tutor.
        public void showStudentList()
        {
            con.Open(); // Open the connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student_List",con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Using Data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentList.DataSource = dt;
            con.Close(); // Close the connection
        }

        //This method is used to find the list of students taught by the specified tutor.
        public void selectStudentList()
        {
            con.Open(); // Open the connection
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student_List WHERE Studentid in (SELECT Studentid FROM Student_Class WHERE Classid in (SELECT Classid FROM Timetable WHERE Userid = '"+userID+"')) ",con);
            //cmd.ExecuteReader();
            //con.Close();
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Using Data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            StudentList.DataSource = dt;
            con.Close(); // Close the connection
        }

        //This method is used to find students of the specified form from the studentlist.
        public void searchStudentList(string form)
        {
            string query = "(SELECT * FROM Student_List)";


            if (form != "Form")
            {
                query = "SELECT * FROM Student_List WHERE Form = '" + form + "'";
            }
            
            

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Using Data Table
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentList.DataSource = dt;
            con.Close(); // Close the connection





        }

    }
}
