using IOOP_GROUP_22.ReceptionistForms;
using System.Collections;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_GROUP_22
{
    public partial class RecepMainpage : Form
    {

        //Fields
        public static string userid="Rec001";//check only
        private Button? currentButton;
        private Form activeForm;
        private MailBox mailBoxForm=new MailBox();

        public RecepMainpage()
        {
            InitializeComponent();
            
        }

        public RecepMainpage(string userId)
        {
            InitializeComponent();
            userid = userId;
        }




        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.AliceBlue;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlHomePage.Controls.Add(childForm);
            this.pnlHomePage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceptionistForms.Profile(userid), sender);
            lblBanner.Text = "Profile";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            lblBanner.Text = "Welcome back, receptionist!";
        }

        private void btnStudentEnroll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceptionistForms.StudentEnrollment(), sender);
            lblBanner.Text = "Student Enrollment";
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceptionistForms.StudentList(), sender);
            lblBanner.Text = "Student List";
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceptionistForms.MakePayment(), sender);
            lblBanner.Text = "Make Payment";
        }

        private void btnPaymentHist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceptionistForms.PaymentHistory(), sender);
            lblBanner.Text = "Payment History";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult m;
            m = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (m == DialogResult.OK)
            {
                this.Hide();
                Login np = new Login();
                np.ShowDialog();
                this.Close();
            }

        }

        
        private void btnMailBox_Click(object sender, EventArgs e)
        {
            mailBoxForm.ShowDialog();
            
        }


        private void Mainpage_Load(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass(userid);
            ReceptionistClass.ViewProfile(obj1);
            lblRcptId.Text = obj1.Userid;
            
            
        }
    }
}