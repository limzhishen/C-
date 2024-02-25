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
    public partial class MonthlyIncome : Form
    {
        private string userid="Adm001";
        public MonthlyIncome()
        {
            InitializeComponent();
        }
        public MonthlyIncome(string id)
        {
            InitializeComponent();
            userid= id;
        }

        private void MonthlyIncome_Load(object sender, EventArgs e)
        {
            startup();
            populate();
            pnlSubmenu.Visible = false;
            tmrTime.Start();
            cal_totalincome();
            foreach (DataRow year in DataGetAdmin.getYear().Rows)
            {
                cmbYear.Items.Add(year[0].ToString());
            }
        }
        private void startup()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i);
            }
            for (int i = 1; i <= 5; i++)
            {
                cmbForm.Items.Add("Form " + i);
            }
            DataTable subject = DataGetAdmin.getsubject();
            foreach(DataRow row in subject.Rows)
            {
                cmbSubject.Items.Add(row[0]);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            populate();
            cmbForm.SelectedIndex= -1;
            cmbMonth.SelectedIndex= -1;
            cmbSubject.SelectedIndex= -1;
            cmbYear.SelectedIndex= -1;
            cal_totalincome();
        }
        private void populate()
        {
            DataGetAdmin obj2 = new DataGetAdmin();
            obj2.Tablemonthly1 = dgvIncome;
            obj2.Monthly_Income();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            dgvIncome.DataSource = DataGetAdmin.Search_Monthly_Income(cmbMonth.Text,cmbForm.Text,cmbSubject.Text, cmbYear.Text,"");
            cal_totalincome();
             
        }
        int income = 0;
        private void cal_totalincome()
        {
            income = 0;
            foreach (DataGridViewRow dt in dgvIncome.Rows)
            {
                if (dt.Cells[7].Value != null)
                {
                    if (dt.Cells[7].Value.ToString() == "Paid")
                    {
                        income += Convert.ToInt32(dt.Cells[5].Value);
                    }
                }
                lblIncome.Text=income.ToString();
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminHomepage ap = new adminHomepage(userid);
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

        private void btnUsermanagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            userManage ap= new userManage(userid);
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



        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Monthly_Income_Report ap= new Monthly_Income_Report(DataGetAdmin.Search_Monthly_Income(cmbMonth.Text, cmbForm.Text, cmbSubject.Text, cmbYear.Text,"genera"), income);
            ap.ShowDialog();
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
