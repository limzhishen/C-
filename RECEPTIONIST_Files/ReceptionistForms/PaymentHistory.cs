using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_GROUP_22.ReceptionistForms
{
    public partial class PaymentHistory : Form
    {
        string studname;
        string studlevel;
        string studsubj;
        string studcharge;
        string paiddate;
        public PaymentHistory()
        {
            InitializeComponent();
            
        }

        
        private void dtpPayMonth_ValueChanged(object sender, EventArgs e)
        {

            DateTime Date = DateTime.Parse(dtpPayMonth.Value.ToShortDateString());
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.PaymentHistory = dgvStudPayHist;
            obj1.ShowMonthPaymentHistory(Date);
        }

        private void btnReceiptInfoReset_Click_1(object sender, EventArgs e)
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
            dtpPayMonth.ResetText();
            cmbLevelSearch.SelectedIndex = -1;
            cmbSubjSearch.SelectedIndex = -1;
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.PaymentHistory = dgvStudPayHist;
            obj1.ShowAllPaymentHistory();
            dgvStudPayHist.ClearSelection();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            ReceptionistClass.ShowSubject(cmbSubjSearch);
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.PaymentHistory = dgvStudPayHist;
            obj1.ShowAllPaymentHistory();
        }

        
        private void btnSrchPaidLvlSubj_Click(object sender, EventArgs e)
        {
            string form = cmbLevelSearch.GetItemText(cmbLevelSearch.SelectedItem);
            string subjectname = cmbSubjSearch.GetItemText(cmbSubjSearch.SelectedItem);
            string paidstatus = "Paid";
            ReceptionistClass obj1 = new ReceptionistClass();
            obj1.PaymentHistory = dgvStudPayHist;
            obj1.SearchPaymentHistory(form, subjectname,paidstatus);
        }

        private void dgvStudPayHist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPaymentId.Text = dgvStudPayHist.CurrentRow.Cells[0].Value.ToString();
            txtPaidStudId.Text = dgvStudPayHist.CurrentRow.Cells[1].Value.ToString();
            studname = dgvStudPayHist.CurrentRow.Cells[2].Value.ToString();
            studlevel = dgvStudPayHist.CurrentRow.Cells[3].Value.ToString();
            studsubj = dgvStudPayHist.CurrentRow.Cells[4].Value.ToString();
            studcharge = dgvStudPayHist.CurrentRow.Cells[5].Value.ToString();
            paiddate = dgvStudPayHist.CurrentRow.Cells[6].Value.ToString();


        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (txtPaymentId.Text!="" && txtPaidStudId.Text!="")
            {
                string onlydate =Convert.ToDateTime(paiddate).ToShortDateString();
                PaymentReceipt form = new PaymentReceipt();
                form.paymentid = txtPaymentId.Text;
                form.paystudid = txtPaidStudId.Text;
                form.payername = studname;
                form.paylevel = studlevel;
                form.paysubject = ReceptionistClass.SubjectIdNameConversion(studsubj);
                form.paycharge = studcharge;
                form.paiddate = onlydate;
                form.copy = "(Copy)";
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a payment history record!");
            }


            
        }
    }
}
