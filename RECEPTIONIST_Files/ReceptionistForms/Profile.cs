using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22.ReceptionistForms
{
    
    public partial class Profile : Form
    {
        string userid;
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string userId)
        {
            InitializeComponent();
            userid = userId;
        }

        


        private void Profile_Load(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass(userid);
            ReceptionistClass.ViewProfile(obj1);
            txtUserId.Text = obj1.Userid;
            txtName.Text = obj1.Name;
            if (obj1.Gender == "Male")
            {
                rdoMale.Checked = true;
            }
            else if (obj1.Gender == "Female")
            {
                rdoFemale.Checked = true;
            }
            rdoMale.Enabled = false;
            rdoFemale.Enabled = false;
            txtUsername.Text = obj1.Username;
            txtEmail.Text = obj1.Email;
            txtContact.Text = obj1.Contact;
            txtDob.Text = obj1.Dob;
            txtName.ReadOnly = true;
            txtUserId.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtDob.ReadOnly= true;
            txtEmail.ReadOnly = true;
            txtContact.ReadOnly = true;
            picProfilePic.Image = obj1.User_Profile_pic;


        }
        
        private void btnUploadProfilePic_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null)
            {
                picProfilePic.Load(openFileDialog.FileName);

            }

        }
 
        private void btnProfileEdit_Click_1(object sender, EventArgs e)
        {
            txtName.ReadOnly = false; Focus();
            txtUserId.ReadOnly = true;
            txtUsername.ReadOnly = false;
            rdoMale.Enabled = false;
            rdoFemale.Enabled = false;
            txtEmail.ReadOnly = false;
            txtContact.ReadOnly = false;
            btnProfileSaveChange.Enabled = true;
        }

        private void llbChangePw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword form = new ChangePassword();
            form.Show();
        }

       
        private void btnProfileSaveChange_Click_1(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass(txtUserId.Text, txtName.Text, txtUsername.Text, txtEmail.Text, txtContact.Text);
            Array valid= obj1.validation();
            List<string> checkempty = new List<string>();
            foreach (Control ctrl in pnlProfileInfo.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox))
                {
                    if (ctrl.Text=="")
                    {
                        string empty = "Empty";
                        checkempty.Add(empty);
                    }
                }
            }
            if (checkempty.Contains("Empty")) 
            {
                MessageBox.Show("Profile haven't completed!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (valid.Length == 0)
                {
                    obj1.User_Profile_pic = picProfilePic.Image;
                    MessageBox.Show(obj1.SaveProfile(txtUserId.Text, txtName.Text, txtUsername.Text, txtEmail.Text, txtContact.Text));
                }
                else
                {
                    List<string> list = new List<string>();
                    foreach (string val in valid)
                    {
                        list.Add(val);
                    }
                    var message =string.Join("\n ", list);
                    MessageBox.Show(message);
                }
                
            }
            
        }
    }
}
