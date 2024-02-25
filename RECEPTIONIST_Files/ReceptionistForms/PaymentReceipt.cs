
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22.ReceptionistForms
{
    public partial class PaymentReceipt : Form
    {
        public string paymentid, paystudid, payername, paylevel, paysubject, paycharge, copy="",paiddate;
        
        public PaymentReceipt()
        {
            InitializeComponent();
        }

        

        private void PaymentReceipt_Load(object sender, EventArgs e)
        {
            label9.Text = paymentid;
            label12.Text = paystudid;
            label13.Text = payername;
            label18.Text = paylevel;
            label15.Text = paysubject;
            label16.Text = paycharge;
            label10.Text = paiddate;
            label19.Text = copy;
        }

       

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picPrint, "Print");

        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            pnlPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();


        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width/662) - (this.pnlPrint.Width/662), this.pnlPrint.Location.Y);


            ;
        }

        private void picPrint_Click(object sender, EventArgs e)
        {
            Print(this.pnlPrint);
        }
    }
}
