using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IOOP_GROUP_22.ReceptionistForms
{
    public partial class StudentEnrollment : Form
    {

        int selectedRowCount = 1;

        public StudentEnrollment()
        {
            InitializeComponent();
        }



        private void btnEnrlStudInfo_Click(object sender, EventArgs e)
        {

            lblEnrlBanner.Text = "Student Information";
            pnlEnrlSubject.Visible = false;
            pnlStudEnrlDecide.Visible = false;

        }

        private void btnEnrlStudSubj_Click(object sender, EventArgs e)
        {
            lblEnrlBanner.Text = "Subject Enrollment";
            pnlEnrlSubject.Visible = true;
            pnlStudEnrlDecide.Visible = true;

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ReceptionistClass obj = new ReceptionistClass(txtEnrlStudName.Text, txtEnrlStudEmail.Text, txtEnrlStudContactNum.Text, txtUsername.Text, txtPassword.Text, dtpBirthDate.Text);
            Array valid = obj.validation();
            if (txtEnrlStudName.Text =="" || txtEnrlStudEmail.Text=="" || txtEnrlStudContactNum.Text=="" || txtUsername.Text=="" || txtPassword.Text=="" || picStudProfilePic.Image == null || (rdoGenderFemale.Checked==false && rdoGenderMale.Checked==false))
            {
                MessageBox.Show("Please fill in all student information!");
            }
            else
            {
                if (valid.Length == 0)
                {
                    ReceptionistClass obj1 = new ReceptionistClass();
                    string check = obj1.CheckNoSameName(txtUsername.Text);
                    if (check != "Username has been used!")
                    {
                        btnEnrlStudSubj.Enabled = true;
                        lblEnrlBanner.Text = "Subject Enrollment";
                        pnlEnrlSubject.Visible = true;
                        pnlStudEnrlDecide.Visible = true;
                    }
                    else if (check == "Username has been used!")
                    {
                        MessageBox.Show(check);
                    }
                }
                else
                {
                    List<string> list = new List<string>();
                    foreach (string val in valid)
                    {
                        list.Add(val);
                    }
                    var message = string.Join("\n ", list);
                    MessageBox.Show(message);
                }
            }
            
        }

        private void btnEnrlStudInfoReset_Click(object sender, EventArgs e)
        {
            GeneralUse reset = new GeneralUse();
            foreach (Control ctrl in pnlEnrlStudInfo.Controls)
            {
                reset.ResetEnteredValuesInControl(ctrl);
            }
            rdoGenderMale.Checked = false;
            rdoGenderFemale.Checked = false;
            picStudProfilePic.Image= null;

        }

        private void btnEnrlSubjReset_Click(object sender, EventArgs e)
        {
            GeneralUse reset = new GeneralUse();
            foreach (Control ctrl in pnlEnrlSubjResult.Controls)
            {
                reset.ResetEnteredValuesInControl(ctrl);
            }
            selectedRowCount= 1;
            

        }

        private void btnAllEnrlLvlSubj_Click(object sender, EventArgs e)
        {
            cmbLevelSearch.Text="";
            cmbSubjSearch.Text="";
            
            cmbLevelSearch.SelectedIndex = -1;
            cmbSubjSearch.SelectedIndex = -1;
            
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.TutorTimetable = dgvTutorTimetable;
            obj1.ShowAllTimetable();
        }

        

        private void btnBackEnrlStudInfo_Click(object sender, EventArgs e)
        {
            lblEnrlBanner.Text = "Student Information";
            pnlEnrlSubject.Visible = false;
            pnlStudEnrlDecide.Visible = false;

        }

        
        private void btnEnrlCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("All data will be lost. Are you sure to cancel the operation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d==DialogResult.Yes)
            {
                GeneralUse reset = new GeneralUse();
                foreach (Control ctrl in this.Controls)
                {
                    reset.ResetEnteredValuesInControl(ctrl);
                }
                picStudProfilePic.Image = null;
                cmbLevelSearch.SelectedIndex = -1;
                cmbSubjSearch.SelectedIndex = -1;
                ReceptionistClass obj1 = new ReceptionistClass();
                obj1.TutorTimetable = dgvTutorTimetable;
                obj1.ShowAllTimetable();
                dgvTutorTimetable.ClearSelection();
                selectedRowCount = 1;


            }
            
        }

        
        private void StudentEnrollment_Load(object sender, EventArgs e)
        {
            btnEnrlStudSubj.Enabled = false;
            ReceptionistClass.ShowSubject(cmbSubjSearch);
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.TutorTimetable = dgvTutorTimetable;
            obj1.ShowAllTimetable();
        }

        private void btnSrchEnrlLvlSubj_Click(object sender, EventArgs e)
        {
            string form = cmbLevelSearch.GetItemText(cmbLevelSearch.SelectedItem);
            string subject = cmbSubjSearch.GetItemText(cmbSubjSearch.SelectedItem); 
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.TutorTimetable = dgvTutorTimetable;
            obj1.SearchTimetable(form,subject);
        }

        
        private void dgvTutorTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (selectedRowCount == 1) 
            {

                txtEnrlSubjName1.Text = dgvTutorTimetable.CurrentRow.Cells[5].Value.ToString();
                txtEnrlClassId1.Text = dgvTutorTimetable.CurrentRow.Cells[0].Value.ToString();
                selectedRowCount += 1;
            }
            else if (selectedRowCount == 2)
            {
                txtEnrlSubjName2.Text = dgvTutorTimetable.CurrentRow.Cells[5].Value.ToString();
                txtEnrlClassId2.Text = dgvTutorTimetable.CurrentRow.Cells[0].Value.ToString();
                if (txtEnrlClassId2.Text == txtEnrlClassId1.Text)
                {
                    MessageBox.Show("Cannot enroll into a class more than once!");
                    txtEnrlSubjName2.Text = "";
                    txtEnrlClassId2.Text = "";

                }
                else
                {
                    selectedRowCount += 1;
                }
                
            }

            else if (selectedRowCount == 3)
            {
                txtEnrlSubjName3.Text = dgvTutorTimetable.CurrentRow.Cells[5].Value.ToString();
                txtEnrlClassId3.Text = dgvTutorTimetable.CurrentRow.Cells[0].Value.ToString();
                if ((txtEnrlClassId3.Text== txtEnrlClassId2.Text) ||(txtEnrlClassId3.Text== txtEnrlClassId1.Text))
                {
                    MessageBox.Show("Cannot enroll into a class more than once!");
                    txtEnrlSubjName3.Text = "";
                    txtEnrlClassId3.Text = "";
                }
                else
                {
                    selectedRowCount += 1;
                }
                
                
            }

            else 
            {
                MessageBox.Show("You cannot enroll more than three subject!","Warning");
            }
            
        }

        private void btnEnrlSave_Click(object sender, EventArgs e)
        {
            string classId1 = txtEnrlClassId1.Text;
            string classId2 = txtEnrlClassId2.Text;
            string classId3 = txtEnrlClassId3.Text;
            string enrlDone = "Enrollment done!";
            string enrlFailed = "Enrollment failed!";
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtEnrlStudName.Text;
            string email = txtEnrlStudEmail.Text;
            string contact = txtEnrlStudContactNum.Text;
            string gender = "";
            if (rdoGenderMale.Checked == true)
            {
                gender = "Male";

            }
            else if (rdoGenderFemale.Checked == true)
            {
                gender = "Female";

            }

            DateTime dob = DateTime.Parse(dtpBirthDate.Value.ToShortDateString());
            string form = cmbEnrlLevel.GetItemText(cmbEnrlLevel.SelectedItem);
            DateTime enrlDate = DateTime.Parse(dtpEnrlDate.Value.ToShortDateString());
            selectedRowCount = 1;
            ReceptionistClass obj = new ReceptionistClass();
            ReceptionistClass obj1 = new ReceptionistClass();
            
            string enrlStudId = obj.StudentIdGeneration();
            ArrayList dates = new ArrayList();
            
            

            string status1 = obj1.EnrollStudent(enrlStudId, username, password, name, email, contact, gender, dob, form, enrlDate,picStudProfilePic.Image);

            if (MessageBox.Show("Confirm save the data?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (status1 == enrlDone)
                {
                    ReceptionistClass obj2 = new ReceptionistClass();
                    ReceptionistClass obj3 = new ReceptionistClass();
                    ReceptionistClass obj4 = new ReceptionistClass();
                    

                    if (classId1 != "")
                    {


                        
                        string status2 = obj2.EnrollSubject(enrlStudId, classId1, enrlDate);
                        if (status2 == status1)
                        {
                            MessageBox.Show(classId1 + ": " + enrlDone);
                            
                        }
                        else { MessageBox.Show(classId1 + ": " + enrlFailed); }
                        


                    }
                    if (classId2 != "")
                    {
                        
                        string status3 = obj3.EnrollSubject(enrlStudId, classId2, enrlDate);
                        if (status3 == status1)
                        {
                            MessageBox.Show(classId2 + ": " + enrlDone);
                           
                        }
                        else { MessageBox.Show(classId2 + ": " + enrlFailed); }
                        

                    }

                    if (classId3 != "")
                    {
                        
                        string status3 = obj4.EnrollSubject(enrlStudId, classId3, enrlDate);

                        if (status3 == status1)
                        {
                            MessageBox.Show(classId3 + ": " + enrlDone);
                            
                        }
                        else 
                        { 
                            MessageBox.Show(classId3 + ":  " + enrlFailed); 
                        }
                        

                    }



                }
                else if (status1 == enrlFailed)
                {
                    MessageBox.Show(enrlFailed);
                }


                GeneralUse reset = new GeneralUse();
                foreach (Control ctrl in this.Controls)
                {
                    reset.ResetEnteredValuesInControl(ctrl);
                }
                picStudProfilePic.Image = null;
                cmbLevelSearch.SelectedIndex = -1;
                cmbSubjSearch.SelectedIndex = -1;
                ReceptionistClass obj0 = new ReceptionistClass();
                obj0.TutorTimetable = dgvTutorTimetable;
                obj0.ShowAllTimetable();
                dgvTutorTimetable.ClearSelection();
                lblEnrlBanner.Text = "Student Information";
                pnlEnrlSubject.Visible = false;
                pnlStudEnrlDecide.Visible = false;

            }
           
        }

       
        private void btnUploadStudProfilePic_Click(object sender, EventArgs e)
        {

            Stream mystream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && (mystream = openFileDialog.OpenFile()) != null)
            {
                picStudProfilePic.Load(openFileDialog.FileName);

            }
        }
    }
}
