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
    public partial class MailBox : Form
    {
        public MailBox()
        {
            InitializeComponent();
        }

        
        private void MailBox_Load(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.RequestDrop = dgvRequestDrop;
            obj1.ShowAllDropRequest();
            ReceptionistClass obj2 = new ReceptionistClass();
            obj2.RequestAdd = dgvRequestAdd;
            obj2.ShowAllAddRequest();
        }

        private void btnAcceptChange_Click(object sender, EventArgs e)
        {
            ReceptionistClass obj1 = new ReceptionistClass();
            ReceptionistClass obj2 = new ReceptionistClass();

            if (txtStudIdDrop.Text != "" && txtClassCurrent.Text != "")
            {
                obj1.AcceptStudentDropSubject(txtStudIdDrop.Text, txtClassCurrent.Text);

                if (txtStudIdAdd.Text != "" && txtClassAfter.Text != "")
                {
                    obj2.AcceptStudentAddSubject(txtStudIdAdd.Text, txtClassAfter.Text);
                }
            }

            else if (txtStudIdDrop.Text == "" && txtClassCurrent.Text == "")
            {
                
                if (txtStudIdAdd.Text != "" && txtClassAfter.Text != "")
                {
                    obj2.AcceptStudentAddSubject(txtStudIdAdd.Text, txtClassAfter.Text);
                }
            }


            ReceptionistClass obj4 = new ReceptionistClass();
            obj4.RequestDrop = dgvRequestDrop;
            obj4.ShowAllDropRequest();
            ReceptionistClass obj5 = new ReceptionistClass();
            obj5.RequestAdd = dgvRequestAdd;
            obj5.ShowAllAddRequest();
        }

        private void btnCheckPaid_Click(object sender, EventArgs e)
        {
            dgvRequestDrop.AllowUserToAddRows = false;
            dgvRequestAdd.AllowUserToAddRows = false;
            int requestDropNum = dgvRequestDrop.Rows.Count;
            int requestAddNum = dgvRequestAdd.Rows.Count;
            List<string> requestDropStudId = new List<string>();
            List<string> requestAddStudId = new List<string>();
            
            for (int i = 0; i < requestDropNum; ++i)
            {
                string id1 = dgvRequestDrop.Rows[i].Cells[1].Value.ToString();
                requestDropStudId.Add(id1);
            }
            for (int i2 = 0; i2 < requestAddNum; ++i2)
            {
                string id2 = dgvRequestAdd.Rows[i2].Cells[1].Value.ToString();
                requestAddStudId.Add(id2);
                
            }
            if (!requestDropStudId.Contains(txtStudIdCheck.Text) && !requestAddStudId.Contains(txtStudIdCheck.Text))
            {
                MessageBox.Show("This student haven't make request yet!");
            }
            else
            {
                string status = "This student haven't clear the payment!";
                string studId = txtStudIdCheck.Text;
                ReceptionistClass obj1 = new ReceptionistClass();
                string check = obj1.CheckPaymentStatus(studId);
                if (check != status)
                {
                    MessageBox.Show("Student has done all the payment!");
                    txtClassAfter.ReadOnly= false;
                    btnAcceptChange.Enabled = true;
                    btnCancel.Enabled = true;

                }
                else if (check == status)
                {
                    MessageBox.Show(status);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("All data will be lost. Are you sure to cancel the operation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                GeneralUse reset = new GeneralUse();
                foreach (Control ctrl in this.Controls)
                {
                    reset.ResetEnteredValuesInControl(ctrl);
                }
                
                ReceptionistClass obj1 = new ReceptionistClass();
                ReceptionistClass obj2 = new ReceptionistClass();
                obj1.RequestAdd = dgvRequestAdd;
                obj1.ShowAllAddRequest();
                obj2.RequestDrop = dgvRequestDrop;
                btnAcceptChange.Enabled = false;
                btnCancel.Enabled = false;
                obj2.ShowAllDropRequest();
                dgvRequestAdd.ClearSelection();
                dgvRequestDrop.ClearSelection();
                txtStudIdCheck.Focus();
                


            }
        }

        private void dgvRequestDrop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string requestStatus = dgvRequestDrop.CurrentRow.Cells[3].Value.ToString();
            if (requestStatus == "Cancel")
            {
                MessageBox.Show("This request has cancelled by student!");
            }
            else if (requestStatus == "Accepted")
            {
                MessageBox.Show("This request has been processed!");
            }
            else if (requestStatus == "Unaccepted")
            {
                txtStudIdDrop.Text = dgvRequestDrop.CurrentRow.Cells[1].Value.ToString();
                txtClassCurrent.Text = dgvRequestDrop.CurrentRow.Cells[2].Value.ToString();
            }
            
        }

        private void dgvRequestAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudIdAdd.Text = dgvRequestAdd.CurrentRow.Cells[1].Value.ToString();
            txtClassAfter.Text = dgvRequestAdd.CurrentRow.Cells[2].Value.ToString();
            string requestStatus = dgvRequestAdd.CurrentRow.Cells[3].Value.ToString();
            if (requestStatus == "Cancel")
            {
                MessageBox.Show("This request has cancelled by student!");
            }
            else if (requestStatus == "Accepted")
            {
                MessageBox.Show("This request has been processed!");
            }
            else if (requestStatus == "Unaccepted")
            {
                txtStudIdAdd.Text = dgvRequestAdd.CurrentRow.Cells[1].Value.ToString();
                txtClassAfter.Text = dgvRequestAdd.CurrentRow.Cells[2].Value.ToString();
            }
                
        }

        private void MailBox_Shown(object sender, EventArgs e)
        {
            txtStudIdCheck.Focus();
        }
    }
}
