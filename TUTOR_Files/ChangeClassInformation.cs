using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Http.Headers;

namespace IOOP_GROUP_22
{
    public partial class ChangeClassInformation : Form
    {
        private string TutorID;
        private string classid = "";

        //private DataGridView classInformation;



        public ChangeClassInformation()
        {
            InitializeComponent();


        }

        public ChangeClassInformation(string TutorID)
        {
            InitializeComponent();
            this.TutorID = TutorID;
        }

        //Add datagridview row data on the form of change class information.
        private void btnAdd_Click(object sender, EventArgs e)
        {


            //Add datagridview row data
            if (cmbForm2.Text=="Form"||cmbSubject2.Text=="Subject Name" || cmbDuration.Text == "Duration" || txtCharges.Text == ""||cmbDuration.Text==""||txtCharges.Text=="0")
            {
                //When you press add directly without selecting any option, a message.box will appear to remind you.
                MessageBox.Show("Please fill all class information", "Adding Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add?", "Adding Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Add the database
                    classid = "";
                    Class obj1 = new Class(classid, TutorID, cmbForm2.Text, cmbSubject2.Text, dateTimePicker1.Value, cmbDuration.Text, txtCharges.Text);
                    string validdate = obj1.datetime_validation(dateTimePicker1.Value);
                    if (validdate == "Record added")
                    {
                        obj1.addClassInformation();
                        MessageBox.Show("Record added", "Adding Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show(validdate);

                    Class obj2 = new Class();
                    obj2.ClassInformation = dataGridView1;
                    obj2.showClassInformation();
                }
                
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            // MessageBox.Show("Record updated", "Updating Record", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (MessageBox.Show("Are you sure you want to update?", "Updating Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Updating the database
                
                Class obj = new Class(classid,TutorID,cmbForm2.Text, cmbSubject2.Text, dateTimePicker1.Value, cmbDuration.Text, txtCharges.Text);
               
                if (classid != "")
                {

                    string validdate = obj.datetime_validation(dateTimePicker1.Value);
                    if (validdate == "Record added")
                    {

                        obj.updateClassInformation();
                        MessageBox.Show("Record updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show(validdate);

                }
                else
                {
                    MessageBox.Show("Please select the row of class that you want to update.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Class obj2 = new Class();
                obj2.ClassInformation = dataGridView1;
                obj2.showClassInformation();
            }


        }

        private void btnTutormenu_Click(object sender, EventArgs e)
        {
            //create object for TutorMenu
            //classname objectname = new constructor
            this.Hide();
            TutorMenu obj1 = new TutorMenu(TutorID);
            obj1.ShowDialog();
            this.Close();
        }

        private void btnShowclassschedule_Click(object sender, EventArgs e)
        {
            //create object for ShowClassSchedule
            //classname objectname = new constructor
            this.Hide();
            ShowClassSchedule obj2 = new ShowClassSchedule(TutorID);
            obj2.ShowDialog();
            this.Close();
        }

        private void btnStudentlist_Click(object sender, EventArgs e)
        {
            //create object for StudentList
            //classname objectname = new constructor
            this.Hide();
            StudentList obj3 = new StudentList(TutorID);
            obj3.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            //MessageBox.Show("Record deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (MessageBox.Show("Are you sure you want to delete?", "Delete Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Deleted the database
                if (classid != "")
                {
                    Class obj = new Class(classid, cmbForm2.Text, cmbSubject2.Text, dateTimePicker1.Value, cmbDuration.Text, txtCharges.Text);
                    obj.deleteClassInformation();
                    MessageBox.Show("Record deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select the row of the class that you want to delete.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                Class obj2 = new Class();
                obj2.ClassInformation = dataGridView1;
                obj2.showClassInformation();
            }

        }


        private void ChangeClassInformation_Load(object sender, EventArgs e)
        {
            pnlSubmenu.Visible=false;
            

            DataTable form = Class.getForm(TutorID);
            foreach (DataRow row in form.Rows)
            {
                
                cmbForm2.Items.Add(row[0]);
            }





            DataTable subject = Class.getSubject();
            foreach (DataRow row in subject.Rows)
            {
                cmbSubject1.Items.Add(row[0]);
            }


            DataTable subject1 = Class.getTutorSubject(TutorID);
            foreach (DataRow row in subject1.Rows)
            {
                cmbSubject2.Items.Add(row[0]);
            }


            Class obj1 = new Class();
            obj1.ClassInformation = dataGridView1;
            obj1.showClassInformation();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Class obj1 = new Class();
            obj1.ClassSchedule= dataGridView1;
            obj1.searchClassInformation(cmbSubject1.Text, cmbForm1.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Class obj2 = new Class();
            obj2.ClassInformation = dataGridView1;
            obj2.showClassInformation();
            cmbForm1.Text = "Form";
            cmbSubject1.Text = "Subject";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1) ; //-1 is to avoid rendering the first row of headers
            //{
            //DataGridView dgvRow = classInformation.Rows[e.RowIndex]; 
            //The logged-in tutor can only update its own class information, and cannot change other tutors.
            //If the logged-in tutor wants to update the class information that is not his own, the classid will not be saved, and it cannot be updated without the classid.
            if (TutorID == dataGridView1.SelectedCells[1].Value.ToString())
            {
                classid = dataGridView1.SelectedCells[0].Value.ToString();
                cmbForm2.SelectedItem = dataGridView1.SelectedCells[3].Value.ToString();
                cmbSubject2.SelectedItem = dataGridView1.SelectedCells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedCells[7].Value.ToString();
                cmbDuration.Text = dataGridView1.SelectedCells[8].Value.ToString();
                txtCharges.Text = dataGridView1.SelectedCells[6].Value.ToString();
            }
            else classid = "";

            //}
        }
        private void hideSubmenu()
        {
            if (pnlSubmenu.Visible == true)
                pnlSubmenu.Visible = false;
        }
        private void showsubmenu(Panel submenu)//when click will check if visible will invisible else visible
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorUpdateProfile tp = new TutorUpdateProfile(TutorID);
            tp.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            //create object for TutorMenu
            //classname objectname = new constructor
            this.Hide();
            TutorMenu obj1 = new TutorMenu(TutorID);
            obj1.ShowDialog();
            this.Close();
        }


    }
}
