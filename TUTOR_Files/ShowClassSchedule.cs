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
    public partial class ShowClassSchedule : Form
    {
        private string TutorID;
        
        public ShowClassSchedule()
        {
            InitializeComponent();
        }

        public ShowClassSchedule(string TutorID)
        {
            InitializeComponent();
            this.TutorID = TutorID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTutormenu_Click(object sender, EventArgs e)
        {
            //create object for TutorMenu
            //classname objectname = new constructor
            this.Hide();
            TutorMenu obj1 = new TutorMenu(TutorID);
            obj1.ShowDialog();
            this.Close();
        }

        private void btnChangeclassinformation_Click(object sender, EventArgs e)
        {
            //create object for ChangeClassInformation
            //classname objectname = new constructor
            this.Hide();
            ChangeClassInformation obj2 = new ChangeClassInformation(TutorID);
            obj2.ShowDialog();
            this.Close();
        }

        private void btnStudentlist_Click(object sender, EventArgs e)
        {
            //create object for StudentList
            //classname objectname = new constructor
            this.Hide();
            StudentList obj3 = new StudentList(TutorID);
            obj3.ShowDialog();
            this.Close();
        }


        private void ShowClassSchedule_Load(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;

            //InitializeComponent();
            Class obj1 = new Class(TutorID);
            obj1.ClassSchedule = dataGridView1;
            obj1.showClassSchedule();
            lblStaffid.Text = "STAFF ID: " + TutorID;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void hideSubmenu()
        {
            if (pnlSubmenu.Visible == true)
                pnlSubmenu.Visible = false;
        }
        private void showsubmenu(Panel submenu)//when click will check if visible will invisible else visible
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void btnAcc_Click(object sender, EventArgs e)
        {
           showsubmenu(pnlSubmenu);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Log Out!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login np = new Login();
                np.ShowDialog();
                this.Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorUpdateProfile tp = new TutorUpdateProfile(TutorID);
            tp.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            //create object for TutorMenu
            //classname objectname = new constructor
            this.Hide();
            TutorMenu obj1 = new TutorMenu(TutorID);
            obj1.ShowDialog();
            this.Close();
        }
    }
}
