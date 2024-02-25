using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace IOOP_GROUP_22
{
    public partial class StudentProfile : Form
    {
        // This stores the ID of the student whose profile is being viewed/edited
        private string StudentID;
        public StudentProfile()
        {
            InitializeComponent();
        }

        // This constructor initializes the form with a specific student ID
        public StudentProfile(string studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (radMale.Checked) { Gender = "Male"; }
            else Gender= "Female";
            Student obj = new Student(StudentID, txtName.Text, txtEmail.Text, Gender, txtForm.Text, txtUsername.Text, txtPassword.Text, txtContact.Text, dtpDob.Value, txtEnrollmentMonth.Text);
            obj.Profile_image = pictureBox1.Image;
            Array valid =obj.validation();
            if(valid.Length==0) MessageBox.Show(obj.editprofile()); // calls the "editprofile" method of the Student object to update the student's profile in the database 
            else
            {
                List<string> list = new List<string>();
                foreach(string var in valid)
                {
                    list.Add(var);
                }
                var mess=string.Join("\n", list);
                MessageBox.Show(mess); // If there are any validation errors, it displays them in a message box
            }
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            studProfile();

            // This code sets the format of the date picker control to display dates in the "dd/MM/yyyy" format
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "dd/MM/yyyy";
        }

        private void studProfile()
        {
            Student obj = new Student(StudentID); // Create instance of the Student Class with the student ID
            obj.getprofile();// call "getprofile" method to retrieve the student's profile information
            lblUsername.Text = obj.Username;
            txtStudentID.Text = StudentID;
            txtName.Text = obj.Name;
            txtEmail.Text = obj.Email;
            if (obj.Gender == "Female") { radFemale.Checked = true; }
            else { radMale.Checked = true; }
            txtForm.Text = obj.Form;
            txtUsername.Text = obj.Username;
            txtPassword.Text = obj.Password;
            txtContact.Text = obj.Contact;
            dtpDob.Value = obj.Dob;
            
            txtEnrollmentMonth.Text = obj.Enrollment.Substring(0, 9);
            pictureBox1.Image = obj.Profile_image;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            studProfile();
        }

        private void btnPicUpload_Click(object sender, EventArgs e)
        {
            Stream mystream = null;

            OpenFileDialog openFileDialog= new OpenFileDialog(); // This code opens a file dialog to allow the user to select an image file
            openFileDialog.Filter = "select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null) 
            {
                pictureBox1.Load(openFileDialog.FileName); // Display the selected image in the picture box on the form
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentHomepage np = new StudentHomepage(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTimetable np = new AddTimetable(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnDropPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            DropTimetable np = new DropTimetable(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnProfilePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProfile np = new StudentProfile(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void btnHistoryPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollHistory np = new EnrollHistory(StudentID);
            np.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}