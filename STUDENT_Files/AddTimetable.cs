using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22
{
    public partial class AddTimetable : Form
    {
        private string StudentID;
        public AddTimetable()
        {
            InitializeComponent();
        }

        public AddTimetable(string StudentId)
        {
            InitializeComponent();
            this.StudentID= StudentId;
        }

        private void AddTimetable_Load(object sender, EventArgs e)
        {
            Student obj = new Student(StudentID);// instance of the "Student" class is created using the "StudentID" parameter. 
            obj.FirstTimetable = dgvFirst; // "dgvFirst" is assigned to the "FirstTimetable" property of this object
            obj.showtimetable();

            // An array of subjects is obtained by calling the static method "getSubject()"
            Array subject =EditTimetable.getSubject(); 
            foreach (string sub in subject)
            { 
                cmbSubject.Items.Add(sub);// each subject in this array is added to the ComboBox "cmbSubject".
            }
            EditTimetable obj1 = new EditTimetable(StudentID); // instance of the "EditTimetable" class is created using the "StudentID" parameter
            obj1.Timetable = dgvAll;
            obj1.getAllTimetable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtaddClassid.Text != "Class ID")
            {
                EditTimetable obj = new EditTimetable(StudentID, txtaddClassid.Text);
                string request = obj.validAddRequest();
                int requestalready = obj.validalready();
                int valid = obj.addvalidation();
                int same=obj.samevalidation();
                if (same != 0)
                {
                    MessageBox.Show("Cannot add same class", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt32(request) != 0)
                    {
                        MessageBox.Show("You already have a request of this class", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (valid >= 3)
                        {
                            MessageBox.Show("You already have 3 classes", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if ((requestalready + valid) >= 3)
                        {
                            MessageBox.Show("You already have a add request", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            if (MessageBox.Show("Are you sure you want to proceed?", "Request Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                MessageBox.Show(obj.Request_add());


                            }
                        }
                    }
               
                }
            }
            else 
            {
                MessageBox.Show("Please select a class that you want to add", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtaddClassid.Text = "Class ID";
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditTimetable obj1 = new EditTimetable(StudentID);

            obj1.Timetable = dgvAll;
            obj1.SearchAllTimetable(cmbSubject.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbSubject.Text = "subject";
            EditTimetable obj1 = new EditTimetable(StudentID);
            obj1.Timetable = dgvAll;
            obj1.getAllTimetable();
            txtaddClassid.Text = "Class ID";
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

        private void btnHistoryPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollHistory np = new EnrollHistory(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void dgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtaddClassid.Text = dgvAll.SelectedCells[0].Value.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
