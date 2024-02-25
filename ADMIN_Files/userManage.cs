using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22
{
    public partial class userManage : Form
    {
        private string userid;
        private string Updateid="";
        public userManage()
        {
            InitializeComponent();
        }
        public userManage(string id)
        {
            InitializeComponent();
            userid = id;
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userManage_Load(object sender, EventArgs e)
        {
            Search();
            adduserrole();
            pnlSubmenu.Visible = false;
            tmrTime.Start();
        }
        private void Search()
        {
            DataGetAdmin obj1 = new DataGetAdmin();
            dgvUser.DataSource = obj1.Search_User(cmbUserrole.Text);
        }
        private void adduserrole()
        {
            cmbUserrole.Items.Add("ADMIN");
            cmbUserrole.Items.Add("TUTOR");
            cmbUserrole.Items.Add("RECEPTIONIST");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGetAdmin obj1 = new DataGetAdmin();
            dgvUser.DataSource = obj1.Search_with_name(txtSearchname.Text);
            cmbUserrole.SelectedIndex= -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbUserrole.SelectedIndex = -1;
            txtSearchname.Clear();
            Search();
        }

        private void cmbUserrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void reset()
        {
            txtPassword.Clear();
            txtusername.Clear();
            Updateid = "";
            Errorprovide.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Updateid == "")
            {
                MessageBox.Show("Please select which personal you want to update", "Update Password and Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure want to update", "Update Password and Username",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                {
                    if (txtPassword.Text == "" || txtusername.Text == "") 
                    { 
                        Errorprovide.SetError(txtusername, "Please Fill in properly ");
                        Errorprovide.SetError(txtPassword, "Please Fill in properly ");
                    }
                    else
                    {
                        Admininfo obj1 = new Admininfo(Updateid,txtusername.Text,txtPassword.Text);
                        Array valid=obj1.valid();
                        if (valid.Length == 0)
                        {
                            MessageBox.Show(obj1.Change_Username_Password());
                            reset();
                        }
                        else
                        {
                            foreach (string i in valid)
                            {
                                if (i == "Username and Password is same with original")
                                {
                                    Errorprovide.SetError(txtPassword, i);
                                    Errorprovide.SetError(txtusername, i);
                                }
                                else if (i == "Username and Password is same with other")
                                {
                                    Errorprovide.SetError(txtPassword, i);
                                    Errorprovide.SetError(txtusername, i);
                                }

                            }
                        }
                    }
                }
               
            }
        }

        private void btnAssign_MouseHover(object sender, EventArgs e)
        {
            tooltiptutor.Show("Select a Tutor for enable this button", btnAssign);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Updateid == "") { MessageBox.Show("Please select which personal you want to delete", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                if (Updateid.Substring(0, 3) == "Adm")
                {
                    MessageBox.Show("ADMIN cannot be delete", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure want to delete User :" + Updateid, "Delete Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Admininfo obj = new Admininfo();
                        MessageBox.Show(obj.DeleteUser(Updateid));
                        Search();
                        reset();
                    }

                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (Updateid != "")
            {
                if (Updateid.Substring(0, 5) == "Tutor")
                {
                    TutorchangeForm chg = new TutorchangeForm(Updateid);
                    chg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Only Tutor can be assign");
                }
            }
            else
            {
                MessageBox.Show("Only Tutor can be assign");
            }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminHomepage ap= new adminHomepage(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile ap= new AdminProfile(userid); 
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
            this.Hide();
            tutorRegister ap= new tutorRegister(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyIncome ap= new MonthlyIncome(userid);
            ap.ShowDialog();
            this.Close();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = dgvUser.SelectedCells[1].Value.ToString();
            txtPassword.Text = dgvUser.SelectedCells[2].Value.ToString();
            Updateid = dgvUser.SelectedCells[0].Value.ToString();
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
