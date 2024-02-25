using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_GROUP_22
{
    public partial class tutorRegister : Form
    {

        private string userid;
        public tutorRegister()
        {
            InitializeComponent();
        }
        public tutorRegister(string id)
        {
            InitializeComponent();
            userid = id;
        }

        private void tutorRegister_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            Dtp_Dob.Format = DateTimePickerFormat.Custom;
            Dtp_Dob.CustomFormat = "dd/MM/yyyy";
            DataTable subject = DataGetAdmin.getsubject();
            foreach (DataRow row in subject.Rows)
            {
                cklSubject.Items.Add(row[0]);
            }
            pnlSubmenu.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Errorprovide.Clear();
            string gender = "";
            if (radMale.Checked == true) gender = "Male";
            else if (radFemale.Checked == true) gender = "Female";//after validation must change
            
            AdminRegister obj1 = new AdminRegister(txtUsername.Text, txtPassword.Text, txtName.Text, txtEmail.Text, txtContact.Text, gender, Dtp_Dob.Value,imagePath);
            Array valid = obj1.validation();
            string level = getlevel();
            string subject=getsubject();
            AdminRegister obj2 = new AdminRegister(level,subject);
            Array levelvalid=obj2.levelsubject();
            if (valid.Length == 0&&levelvalid.Length==0) 
            {
                if (imagePath == "")
                {
                    Errorprovide.SetError(btnUpload, "Upload a picture");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Register?", "Register Tutor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string tutorid = obj1.idgeneration("Tutor");
                        if (obj1.register_Tutor(tutorid) == "Sucessful to register")
                        {
                            MessageBox.Show(obj2.tutor_Levelregister(tutorid));
                            reset();
                        }
                        else MessageBox.Show("Something got error");
                    }
                }

            }
            else
            {
                Errormessage_icon(valid);
                Errormessage_icon(levelvalid);
                
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
                }
                else if (i == "Check either one Form"){ Errorprovide.SetError(grplevel, i);}
                else if (i == "Check either one subject"){Errorprovide.SetError(cklSubject, i); }
                else Errorprovide.SetError(btnRegister, i);
            }
        }

        private string getlevel()
        {
            StringBuilder level= new StringBuilder();
            if (chkForm1.Checked) level.Append("Form 1,");
            if (chkForm2.Checked) level.Append("Form 2,");
            if (chkForm3.Checked) level.Append("Form 3,");
            if (chkForm4.Checked) level.Append("Form 4,");
            if (chkForm5.Checked) level.Append("Form 5,");
            return level.ToString();
        }
        private string getsubject()
        {
            int i;
            StringBuilder subject = new StringBuilder();
            for (i = 0; i <= cklSubject.Items.Count-1; i++)
            {
                if (cklSubject.GetItemChecked(i) == true)
                {
                    if (subject.Length == 0)
                    {
                        subject.Append(cklSubject.Items[i]);
                    }
                    else
                    {
                        subject.Append("," + cklSubject.Items[i]);
                    }
                }
            }
            
            return subject.ToString();
        }
        private void reset()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            Dtp_Dob.Value = DateTime.Now;
            radFemale.Checked = false;
            radMale.Checked = false;
            Errorprovide.Clear();
            chkForm1.Checked= false;
            chkForm2.Checked= false;
            chkForm3.Checked= false;
            chkForm4.Checked= false;
            chkForm5.Checked= false;
            for(int i=0; i<cklSubject.Items.Count;i++)
            {
                cklSubject.SetItemChecked(i, false);
            }
            cklSubject.SelectedItems.Clear();

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Reset?", "Register Tutor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) reset();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminHomepage ap= new adminHomepage(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionistRegister ap= new receptionistRegister(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            tutorRegister ap= new tutorRegister(userid);
            ap.ShowDialog();
            this.Close();
            */
        }

        private void btnUsermanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            userManage ap= new userManage(userid);
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

        private void btnAcc_Click(object sender, EventArgs e)
        {
            showsubmenu(pnlSubmenu);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile ap= new AdminProfile(userid);
            ap.ShowDialog();
            this.Close();
        }
        private string imagePath = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null)
            {
                picTutor.Load(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
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
