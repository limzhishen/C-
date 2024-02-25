using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class StudentList : Form
    {
        private string TutorID;


        public StudentList()
        {
            InitializeComponent();
        }

        public StudentList(string TutorID) //用来接收资料，login的时候辨认是谁
        {
            InitializeComponent();
            this.TutorID = TutorID;
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

        private void btnShowclassschedule_Click(object sender, EventArgs e)
        {
            //create object for ShowClassSchedule
            //classname objectname = new constructor
            this.Hide();
            ShowClassSchedule obj3 = new ShowClassSchedule(TutorID);
            obj3.ShowDialog();
            this.Close();
        }


        private void StudentList_Load(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;

            TutorStudent obj1 = new TutorStudent(TutorID);
            obj1.StudentList = dataGridView1;
            obj1.selectStudentList();

            lblStaffid.Text = "STAFF ID:" + TutorID;

            timer1.Start();
  
        }


   

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TutorStudent obj1 = new TutorStudent();
            obj1.StudentList = dataGridView1;
            obj1.searchStudentList(cmbForm.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TutorStudent obj2 = new TutorStudent();
            obj2.StudentList = dataGridView1;
            obj2.showStudentList();
            cmbForm.Text = "Form";
            
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
            TutorUpdateProfile tp = new TutorUpdateProfile(TutorID);
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
