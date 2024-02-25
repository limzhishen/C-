using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22.ReceptionistForms
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.StudentInfo = dgvStudList;
            obj1.ShowAllStudentInfo();
            
        }



        private void btnSrchStud_Click(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.StudentInfo = dgvStudList;
            obj1.SearchStudent(txtSrchStudId.Text);
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.StudentInfo = dgvStudList;
            obj1.ShowAllStudentInfo();
            
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE selected student data.","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                
                ReceptionistClass obj1 = new ReceptionistClass();
                obj1.StudentInfo = dgvStudList;
                obj1.DeleteStudent(txtDelStudId.Text);
                ReceptionistClass obj2 = new ReceptionistClass();
                obj2.StudentInfo = dgvStudList;
                obj2.ShowAllStudentInfo();

            }
        }

       
        private void dgvStudList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtDelStudId.Text = dgvStudList.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
