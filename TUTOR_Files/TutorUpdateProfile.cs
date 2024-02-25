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
    public partial class TutorUpdateProfile : Form
    {
        private string TutorID="Tutor001";

        public TutorUpdateProfile()
        {
            InitializeComponent();
        }

        public TutorUpdateProfile(string TutorID)
        {
            InitializeComponent();
            this.TutorID = TutorID;
        }


        private void btnTutormenu_Click(object sender, EventArgs e)
        {
            //create object for TutorMenu
            //classname objectname = new constructor
            this.Hide();
            TutorMenu obj1 = new TutorMenu();
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

        private void btnStudentlist_Click(object sender, EventArgs e)
        {
            //create object for StudentList
            //classname objectname = new constructor
            this.Hide();
            StudentList obj4 = new StudentList(TutorID);
            obj4.ShowDialog();
            this.Close();
        }

        private void TutorUpdateProfile_Load(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;

            reset();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            timer1.Start();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radMale.Checked) { gender = "Male"; }
            else gender = "Female";
            Tutor obj1 = new Tutor(TutorID,txtUsername.Text, txtPassword.Text, txtName.Text, txtEmail.Text, txtContact.Text, dateTimePicker1.Value, gender);
            obj1.ProfileImage = picTutor.Image;
            Array valid = obj1.validation();


            if(valid.Length==0)
            {
                MessageBox.Show(obj1.editProfile());
            }
            else
            {
                List<string> mess= new List<string>();
                foreach(string s in valid)
                {
                    if(s!="")mess.Add(s);
                }
                var messange = string.Join("\n", mess);
                MessageBox.Show(messange,"Valid Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            reset();
        }
        //private string imagePath="";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null)
            {
                picTutor.Load(openFileDialog.FileName);
                //imagePath = openFileDialog.FileName;
            }
        }

        private void reset()
        {
            Tutor obj1 = new Tutor(TutorID);
            Tutor.getProfileDetail(obj1);
            txtUsername.Text = obj1.Username;
            txtPassword.Text = obj1.Password;
            txtName.Text = obj1.Name;
            txtEmail.Text = obj1.Email;
            txtContact.Text = obj1.Contact;
            if (obj1.Gender == "Female")
            {
                radFemale.Checked = true;
            }
            else
            {
                radMale.Checked = true;
            }
            dateTimePicker1.Value = obj1.DateOfBirth;
            picTutor.Image = obj1.ProfileImage;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text= DateTime.Now.ToLongTimeString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

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
