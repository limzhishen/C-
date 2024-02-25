using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22.ReceptionistForms
{
    public partial class MakePayment : Form
    {
        
        public MakePayment()
        {
            InitializeComponent();
            
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {

            DateTime paydate = DateTime.Parse(DateTime.Now.ToShortDateString());
            ReceptionistClass obj1 = new ReceptionistClass();
            string status = obj1.UpdatePaymentDate(txtPaymentId.Text, txtPaidStudId.Text, paydate); 
            if (status != "Payment failed!")
            {
                
                PaymentReceipt form = new PaymentReceipt();
                form.paymentid = txtPaymentId.Text;
                form.paystudid = txtPaidStudId.Text;
                form.payername = txtName.Text;
                form.paylevel = txtPaidLevel.Text;
                form.paysubject = ReceptionistClass.SubjectIdNameConversion(txtPaidSubject.Text);
                form.paycharge = txtPaidFees.Text;
                form.paiddate = DateTime.Now.ToShortDateString();
                form.ShowDialog();
            }
            
        }

       
        private void MakePayment_Load(object sender, EventArgs e)
        {
            ReceptionistClass.ShowSubject(cmbSubjSearch);
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.MakePayment = dgvStudPay;
            obj1.ShowAllNeededPayment();
        }

        private void btnReceiptInfoReset_Click(object sender, EventArgs e)
        {
            GeneralUse reset = new GeneralUse();
            foreach (Control ctrl in panel2.Controls)
            {
                reset.ResetEnteredValuesInControl(ctrl);
            }
        }

        private void btnSrchAllPaid_Click(object sender, EventArgs e)
        {
            cmbLevelSearch.Text = "";
            cmbSubjSearch.Text = "";
            cmbLevelSearch.SelectedIndex = -1;
            cmbSubjSearch.SelectedIndex = -1;
            ReceptionistClass obj2 = new ReceptionistClass();
            obj2.MakePayment = dgvStudPay;
            obj2.ShowAllNeededPayment();
            dgvStudPay.ClearSelection();
        }

        
        private void btnSrchPaidLvlSubj_Click(object sender, EventArgs e)
        {
            string form = cmbLevelSearch.GetItemText(cmbLevelSearch.SelectedItem);
            string subjectname = cmbSubjSearch.GetItemText(cmbSubjSearch.SelectedItem);
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.MakePayment = dgvStudPay;
            obj1.SearchPayment(form, subjectname);
        }

        private void btnGenerateLstMthPay_Click(object sender, EventArgs e)
        {
            DateTime lastmonthdate = DateTime.Parse(dtpPayMonth.Value.ToShortDateString());
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.StudentClassBasedPayment(lastmonthdate);
            ReceptionistClass obj2 = new ReceptionistClass();
            obj2.MakePayment = dgvStudPay;
            obj2.ShowAllNeededPayment();


        }

        private void dgvStudPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudPay.CurrentRow.Cells[7].Value.ToString() == "Paid")
            {
                MessageBox.Show("This student has made the payment already!");
            }
            else
            {
                txtPaymentId.Text = dgvStudPay.CurrentRow.Cells[0].Value.ToString();
                txtPaidStudId.Text = dgvStudPay.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvStudPay.CurrentRow.Cells[2].Value.ToString();
                txtPaidLevel.Text = dgvStudPay.CurrentRow.Cells[3].Value.ToString();
                txtPaidSubject.Text = dgvStudPay.CurrentRow.Cells[4].Value.ToString();
                txtPaidFees.Text = dgvStudPay.CurrentRow.Cells[5].Value.ToString();
            }
            
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string payStatus = cmbStatus.GetItemText(cmbStatus.SelectedItem);
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.MakePayment = dgvStudPay;
            obj1.PaymentByStatus(payStatus);
        }
    }
}
