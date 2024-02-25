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
    public partial class receptionistRegister : Form
    {
        private string userid="Adm001";
        public receptionistRegister()
        {
            InitializeComponent();
        }
        public receptionistRegister(string id)
        {
            InitializeComponent();
            userid=id;
        }

        private void receptionistRegister_Load(object sender, EventArgs e)
        {
            Dtp_Dob.Format = DateTimePickerFormat.Custom;
            Dtp_Dob.CustomFormat = "dd/MM/yyyy";
            pnlSubmenu.Visible= false;
            tmrTime.Start();
        }
        private string imagepath = "";
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //try
            {
                Errorprovide.Clear();
                string gender = "";
                if (radMale.Checked == true) gender = "Male";
                else if (radFemale.Checked == true) gender = "Female";//after validation must change

                AdminRegister obj1 = new AdminRegister(txtUsername.Text, txtPassword.Text, txtName.Text, txtEmail.Text, txtContact.Text, gender, Dtp_Dob.Value,imagepath);
                Array valid = obj1.validation();

                if (valid.Length == 0) 
                {
                    if (imagepath== "")
                    {
                        Errorprovide.SetError(btnUpload, "Please upload an image");
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to Register?", "Register Receptionist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        { MessageBox.Show(obj1.register_Recption()); reset(); }
                    }
                    
                }
                else
                {
                    Errormessage_icon(valid);
                }

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
                    //MessageBox.Show(i);
                }
                else Errorprovide.SetError(btnRegister, i);
            }
        }
        private void reset()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            Dtp_Dob.Value=DateTime.Now;
            radFemale.Checked= false;
            radMale.Checked= false;
            Errorprovide.Clear();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Reset?", "Register Receptionist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) reset();
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
            this.Hide();
            AdminProfile ap=new AdminProfile(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminHomepage ap=new adminHomepage(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            receptionistRegister ap=new receptionistRegister(userid);
            ap.ShowDialog();
            this.Close();
            */
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            tutorRegister ap=new tutorRegister(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnUsermanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            userManage ap=new userManage(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyIncome ap=new MonthlyIncome(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null)
            {
                picRecp.Load(openFileDialog.FileName);
                imagepath = openFileDialog.FileName;
            }
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
