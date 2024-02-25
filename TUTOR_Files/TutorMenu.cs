using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_GROUP_22
{
    public partial class TutorMenu : Form
    {
        private string TutorID="Tutor001";

        public TutorMenu()
        {
            InitializeComponent();
            

        }

        public TutorMenu(string TutorID)
        {
            InitializeComponent();
            this.TutorID = TutorID;
        }


        private void button7_Click(object sender, EventArgs e) //This button is the Show Class Schedule. 
        {
            //create object for ShowClassSchedule
            //classname objectname = new constructor
            this.Hide();
            ShowClassSchedule obj4 = new ShowClassSchedule(TutorID);
            obj4.ShowDialog();
            this.Close();
        }

        private void btnChangeclassinformation_Click(object sender, EventArgs e)
        {
            //create object for ChangeClassInformation
            //classname objectname = new constructor

            this.Hide(); // hide the current window
            ChangeClassInformation obj1 = new ChangeClassInformation(TutorID);
            obj1.ShowDialog(); //The second window pops up, the first window can't be used
            this.Close(); //Close the first window
        }

        private void llbEditprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // this opens the Edit profile page

            this.Hide();
            TutorUpdateProfile obj4 = new TutorUpdateProfile(TutorID);
            obj4.ShowDialog();
            this.Close();
        }

        private void btnShowclassschedule_Click(object sender, EventArgs e)
        {
            // create object for ShowClassSchedule
            //classname objectname = new constructor
            this.Hide();
            ShowClassSchedule obj2 = new ShowClassSchedule(TutorID);
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

        private void TutorMenu_Load(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;

            Tutor obj1 = new Tutor(TutorID);
            //When the tutor logs in to the account, the getProfileDetail method will find the matching information from the database.
            Tutor.getProfileDetail(obj1);
            lblidtutor.Text = obj1.Userid;//This displays the user id of the tutor who logged in to the account.
            lblemail.Text = obj1.Email;//This displays the email of the tutor who logged in to the account.
            picTutor.Image = obj1.ProfileImage;//This is a photo to show the tutor who is logged into the account.
            timer1.Start();//Start timer1. Allow the event to be raised again,used to start the calculation of time.


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
        private void picAcc_Click(object sender, EventArgs e)
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
    }
}