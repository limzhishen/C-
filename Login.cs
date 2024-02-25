using System.Data;
using System.Data.SqlClient;

namespace IOOP_GROUP_22
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or Password cannot be empty!", "Login information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User obj = new User(txtUsername.Text, txtPassword.Text);
                string user = obj.LoginUser();
                string[] role = user.Split(',');
                if (role[0] == "ADMIN")
                {
                    this.Hide();
                    adminHomepage np= new adminHomepage(role[1]);
                    np.ShowDialog();
                    this.Close();
                }
                else if (role[0] == "RECEPTIONIST")
                {
                    this.Hide();
                    RecepMainpage np = new RecepMainpage(role[1]);
                    np.ShowDialog();
                    this.Close();
                }
                else if (role[0] == "TUTOR")
                {
                    this.Hide();
                    TutorMenu np = new TutorMenu(role[1]);
                    np.ShowDialog();
                    this.Close();
                }
                else if (role[0] == "STUDENT")
                {
                    this.Hide();
                    StudentHomepage np = new StudentHomepage(role[1]);
                    np.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                    txtUsername.Focus();
                }
            }

        }
        



    }
}