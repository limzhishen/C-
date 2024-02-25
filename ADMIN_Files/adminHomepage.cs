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
    public partial class adminHomepage : Form
    {
        private string userid="Adm001" ;//for check
        
        public adminHomepage()
        {
            InitializeComponent();
        }
        public adminHomepage(string id)
        {
            InitializeComponent();
            userid = id;
        }
      
        private void adminHomepage_Load(object sender, EventArgs e)//get information by using properties
        {
            tmrTime.Start();
            pnlSubmenu.Visible = false;
            Admininfo obj1 = new Admininfo(userid);
            Admininfo.Getinformation(obj1);
            lblAdmin.Text = obj1.User_role;
            lblName.Text = obj1.Name;
            lblEmail.Text = obj1.Email;
            //get total user and total amount
            lblamount.Text = DataGetAdmin.getmonthamount();//get this month amount
            lbluseramount.Text = DataGetAdmin.gettotaluser();
            picAdmin.Image = obj1.Profile_image;

        }

        
        private void timTime_Tick(object sender, EventArgs e)//show date time by timer tick
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
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

        private void btnAcc_Click_1(object sender, EventArgs e)
        {
            showsubmenu(pnlSubmenu);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile ap = new AdminProfile(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnShowprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile ap = new AdminProfile(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            adminHomepage ap = new adminHomepage(userid);
            ap.ShowDialog();
            this.Close();*/
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionistRegister ap = new receptionistRegister(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            tutorRegister ap = new tutorRegister(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyIncome ap = new MonthlyIncome(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnUsermanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            userManage ap = new userManage(userid);
            ap.ShowDialog();
            this.Close();
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

        private void lbllogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Log Out!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login np = new Login();
                np.ShowDialog();
                this.Close();
            }
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log out?", "Log Out!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login np = new Login();
                np.ShowDialog();
                this.Close();
            }
        }
    }
}
