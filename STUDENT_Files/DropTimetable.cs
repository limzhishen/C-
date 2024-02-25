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
    public partial class DropTimetable : Form
    {
        private string StudentID;

        public DropTimetable()
        {
            InitializeComponent();
        }

        public DropTimetable(string studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void btnHistoryPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollHistory np = new EnrollHistory(StudentID);
            np.ShowDialog();
            this.Close();
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

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProfile np = new StudentProfile(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void DropTimetable_Load(object sender, EventArgs e)
        {
            Student obj = new Student(StudentID);
            obj.FirstTimetable = dgvTimetable;
            obj.showtimetable(); // Call the showtimetable method to display the student's timetable
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {

            if (txtdropClassid.Text != "Class ID") // Check if the user has selected a class to drop
            {
                EditTimetable obj = new EditTimetable(StudentID, txtdropClassid.Text);
                string validdropalready = obj.validdropalready(); // Call the validdropalready method to check if the user has already requested to drop this class
                if (validdropalready != "0")
                {
                    MessageBox.Show("You already have a drop request");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to proceed?", "Request Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show(obj.Request_drop()); // Call the Request_drop method to drop the class
                    }
                }


            }
            else
            {
                MessageBox.Show("Please select a class that you want to Drop", "Drop Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Reset the text of the txtdropClassid textbox to "Class ID"
            txtdropClassid.Text = "Class ID";

        }

        private void dgvTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdropClassid.Text = dgvTimetable.SelectedCells[0].Value.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
