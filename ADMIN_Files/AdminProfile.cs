using System;
using System.Collections;
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
    public partial class AdminProfile : Form
    {
        private string imagePath="";
        private string userid="Adm001";
        public AdminProfile()
        {
            InitializeComponent();
        }
        public AdminProfile(string id)
        {
            InitializeComponent();
            userid = id;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = false;
            startup();
            tmrTime.Start();
        }
        private void startup()//get information by using properties
        {
            Admininfo obj1 = new Admininfo(userid);
            Admininfo.Getinformation(obj1);
            txtName.Text = obj1.Name;
            txtEmail.Text = obj1.Email;
            txtUsername.Text = obj1.Username;
            txtPassword.Text = obj1.Password;
            txtContact.Text = obj1.Contact.ToString();
            if (obj1.Gender == "Male") { radMale.Checked = true; }
            else { radFemale.Checked = true; }
            Dtp_Dob.Format = DateTimePickerFormat.Custom;
            Dtp_Dob.CustomFormat = "dd/MM/yyyy";
            Dtp_Dob.Value = Convert.ToDateTime(obj1.Dob);
            picAdmin.Image = obj1.Profile_image;

            Errorprovide.Clear();
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Reset?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) startup();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string gender = "Male";
            if (radFemale.Checked) { gender = "Female"; }

            AdminRegister obj1 = new AdminRegister(userid, txtUsername.Text, txtPassword.Text, txtName.Text, txtEmail.Text, txtContact.Text, gender, Dtp_Dob.Value,imagePath);
            Array valid = obj1.validation();

            if (valid.Length == 0) 
            {
                if (MessageBox.Show("Are you sure you want to Upadte?", "Update Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Admininfo obj2 = new Admininfo(userid, txtUsername.Text, txtPassword.Text, txtName.Text, txtEmail.Text, txtContact.Text, gender, Dtp_Dob.Value, imagePath);
                    //obj2.Profile_image = picAdmin.Image;
                    MessageBox.Show(obj2.updateprofile()); startup();
                }
                     
            }
            else
            {/*
                List<string> list = new List<string>();
                var message=string.Join("\n", list);
                MessageBox.Show(message);*/
                Errormessage_icon(valid);
            }
            
        }
        private void Errormessage_icon(Array valid)
        {
            foreach (string i in valid)
            {
                if (i == "Email must contain '@'") Errorprovide.SetError(txtEmail, i + " and '.'");
                else if (i == "Email must contain '.'") Errorprovide.SetError(txtEmail, i + " and '@'");
                else if (i == "Please use malaysia contact '01'") Errorprovide.SetError(txtContact, i);
                else if (i == "Please check the number of contact") Errorprovide.SetError(txtContact, i);
                else if (i == "Contact number only accepter numeric") Errorprovide.SetError(txtContact, i);
                else if (i == "Select the true of your Date of Birth") Errorprovide.SetError(Dtp_Dob, i);
                else if (i == "Please fill in the username") Errorprovide.SetError(txtUsername, i);
                else if (i == "Please fill in the password") Errorprovide.SetError(txtPassword, i);
                else if (i == "Please fill in the name") Errorprovide.SetError(txtName, i);
                else if (i == "Please check either of the gender") { Errorprovide.SetError(radFemale, i); Errorprovide.SetError(radMale, i); }
                else if (i == "Please Fill in the contact") Errorprovide.SetError(txtContact, i);
                else if (i == "Username and Password is same")
                {
                    Errorprovide.SetError(txtUsername, i);
                    Errorprovide.SetError(txtPassword, i);
                    MessageBox.Show(i);
                }
                else Errorprovide.SetError(btnEdit, i);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminHomepage np= new adminHomepage(userid);
            np.ShowDialog();
            this.Close();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionistRegister np = new receptionistRegister(userid);
            np.ShowDialog();
            this.Close();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            tutorRegister np = new tutorRegister(userid);
            np.ShowDialog();
            this.Close();
        }

        private void btnUsermanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            userManage np = new userManage(userid);
            np.ShowDialog();
            this.Close();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyIncome np = new MonthlyIncome(userid);
            np.ShowDialog();
            this.Close();
        }
        private void hideSubmenu()
        {
            if (pnlSubmenu.Visible == true)
                pnlSubmenu.Visible = false;
        }
        private void showsubmenu(Panel submenu)
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            /*
             * this.Hide();
            AdminProfile np = new AdminProfile(userid);
            np.ShowDialog();
            this.Close();
            */
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            Stream mystream= null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this)==DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null)
            {
                picAdmin.Load(openFileDialog.FileName);
                imagePath=openFileDialog.FileName;
            }
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
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
    }
}
