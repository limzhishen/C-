using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace IOOP_GROUP_22
{
    public partial class EnrollHistory : Form
    {
        private string Studentid;
        public EnrollHistory()
        {
            InitializeComponent();
        }
        public EnrollHistory(string Studentid) 
        {
            InitializeComponent();
            this.Studentid=Studentid;
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProfile np = new StudentProfile(Studentid);
            np.ShowDialog();
            this.Close();
        }

        private void btnDropPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            DropTimetable np = new DropTimetable(Studentid);
            np.ShowDialog();
            this.Close();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTimetable np = new AddTimetable(Studentid);
            np.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentHomepage np = new StudentHomepage(Studentid);
            np.ShowDialog();
            this.Close();
        }

        private void EnrollHistory_Load(object sender, EventArgs e)
        {
            EditTimetable obj = new EditTimetable(Studentid);
            obj.Requestadd = dataGridView1;
            obj.Requestdrop= dataGridView2;
            obj.showRequestadd(""); // Call the showRequestadd method of the object passing an empty string as parameter
            obj.showRequestdrop("");
        }

        private void btnHistoryPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollHistory np = new EnrollHistory(Studentid);
            np.ShowDialog();
            this.Close();
        }

        private void cmbAddSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAddSubject.Text == "add")
            {
                EditTimetable obj = new EditTimetable(Studentid);
                obj.Requestadd = dataGridView1; // Set the Requestadd property of the object to the dataGridView1
                obj.showRequestadd("");
            }
            else if (cmbAddSubject.Text == "Unaccepted")
            {
                EditTimetable obj = new EditTimetable(Studentid);
                obj.Requestadd = dataGridView1;
                obj.showRequestadd("have"); 
            }
        }
        

        private void btnaddClear_Click(object sender, EventArgs e)
        {
            cmbAddSubject.SelectedIndex = -1; // set to -1 to deselect any selected item
            EditTimetable obj = new EditTimetable(Studentid); // An instance of EditTimetable class is created with Studentid as a parameter.
            obj.Requestadd = dataGridView1;
            obj.showRequestadd("");
            txtaddClassid.Text = "Requestid";
        }

        private void cmbDropSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbDropSubject.Text == "drop")
                {
                    EditTimetable obj = new EditTimetable(Studentid);
                    obj.Requestdrop = dataGridView2;
                    obj.showRequestdrop("");
                }
                else if (cmbDropSubject.Text == "Unaccepted")
                {
                    EditTimetable obj = new EditTimetable(Studentid);
                    obj.Requestdrop = dataGridView2;
                    obj.showRequestdrop("have");
                }
            }
        }

        private void btndropClear_Click(object sender, EventArgs e)
        {
            cmbDropSubject.SelectedIndex = -1;
            EditTimetable obj = new EditTimetable(Studentid);
            obj.Requestdrop = dataGridView2;
            obj.showRequestdrop("");
            txtdropClassid.Text = "Requestid";
        }

        private string addstatus;
        private string dropstatus;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtaddClassid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            addstatus = dataGridView1.SelectedCells[3].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdropClassid.Text = dataGridView2.SelectedCells[0].Value.ToString();
            dropstatus = dataGridView2.SelectedCells[3].Value.ToString();
        }

        private void btnaddCancel_Click(object sender, EventArgs e)
        {
            if (txtaddClassid.Text != "Requestid") 
            {
                if (addstatus == "Unaccepted")
                {
                    EditTimetable obj1 =new EditTimetable(txtaddClassid.Text);
                    MessageBox.Show(obj1.deleteaddrequest());
                }
                else
                {
                    MessageBox.Show("Your request has already been requested.", "Cancel Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the class you want to cancel", "Cancel Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            EditTimetable obj = new EditTimetable(Studentid);
            obj.Requestadd = dataGridView1;
            obj.showRequestadd("");
        }

        private void btndropCancel_Click(object sender, EventArgs e)
        {
            if(txtdropClassid.Text != "Requestid")
            {
                if(dropstatus== "Unaccepted")
                {
                    EditTimetable obj1 = new EditTimetable(txtdropClassid.Text);
                    MessageBox.Show(obj1.deletedroprequest());
                }
                else
                {
                    MessageBox.Show("Your request has already been requested.", "Cancel Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the class you want to cancel", "Cancel Request",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
