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
    public partial class Monthly_Income_Report : Form
    {
        private DataTable income;
        private int totalincome;
        public Monthly_Income_Report()
        {
            InitializeComponent();
        }
        public Monthly_Income_Report(DataTable Show,int income)
        {
            InitializeComponent();
            this.income = Show;
            this.totalincome = income;
        }
        private void Monthly_Income_Report_Load(object sender, EventArgs e)
        {
            dgvIncome.DataSource= income;
            lblTotal.Text = "Total Income=RM " + totalincome;
            lblDate.Text="Generate Date "+DateTime.Now.ToShortDateString();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
