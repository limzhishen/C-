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
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace IOOP_GROUP_22.ReceptionistForms
{
    public partial class ChangePassword : Form
    {
        private string userid = "Rec001"; //check only

        public ChangePassword()
        {
            InitializeComponent();
        }


        private void txtOldPw_TextChanged(object sender, EventArgs e)
        {
            txtOldPw.UseSystemPasswordChar = true;
        }
        private void txtNewPw_TextChanged(object sender, EventArgs e)
        {
            txtNewPw.UseSystemPasswordChar = true;
        }
        private void txtConfirmPw_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPw.UseSystemPasswordChar = true;
        }

        private void picHidePw1_MouseDown(object sender, MouseEventArgs e)
        {
            txtOldPw.UseSystemPasswordChar = false;
        }

        private void picHidePw1_MouseUp(object sender, MouseEventArgs e)
        {
            txtOldPw.UseSystemPasswordChar = true;
        }

        private void picHidePw2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPw.UseSystemPasswordChar = false;
        }

        private void picHidePw2_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPw.UseSystemPasswordChar = true;
        }

        private void picHidePw3_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPw.UseSystemPasswordChar = false;
        }

        private void picHidePw3_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPw.UseSystemPasswordChar = true;
        }

        private void btnCancelChangePw_Click(object sender, EventArgs e)
        {
            txtOldPw.Clear();
            txtNewPw.Clear();
            txtConfirmPw.Clear();
            this.Close();
        }

        private void btnSavePw_Click(object sender, EventArgs e)
        {
            string oldPw = txtOldPw.Text;
            string newPw = txtNewPw.Text;
            string confirmPw = txtConfirmPw.Text;
            ReceptionistClass obj1 = new ReceptionistClass(userid);
            obj1.UpdatePassword(oldPw, newPw, confirmPw);
        }
    }
 
}
