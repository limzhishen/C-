using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22
{
    public partial class StudentHomepage : Form
    {
        private string StudentID;
        public StudentHomepage()
        {
            InitializeComponent();
        }

        // Constructor that takes studentID as an argument
        public StudentHomepage(string StudentId)
        {
            InitializeComponent();
            // Initialize the StudentID field with the given studentID
            this.StudentID = StudentId;
        }

        private void StudentHomepage_Load(object sender, EventArgs e)
        {
            startup(); // Call the startup method
        }

        private void startup() 
        {
            Student obj = new Student(StudentID);//Create instance of the Student Class with the student ID
            obj.FirstTimetable = dataGridView1;
            obj.showtimetable();
            obj.getprofile();
            lblUsername.Text = obj.Username;
            picStudent.Image = obj.Profile_image;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentHomepage np = new StudentHomepage(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTimetable np = new AddTimetable(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnDropPage_Click(object sender, EventArgs e)
        {

            this.Hide();
            DropTimetable np = new DropTimetable(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnHistoryPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollHistory np = new EnrollHistory(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProfile np = new StudentProfile(StudentID);
            np.ShowDialog();
            this.Close();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login np = new Login();
            np.ShowDialog();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
