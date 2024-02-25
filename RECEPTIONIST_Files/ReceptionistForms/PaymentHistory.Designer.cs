namespace IOOP_GROUP_22.ReceptionistForms
{
    partial class PaymentHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudPayHist = new System.Windows.Forms.DataGridView();
            this.lblPayMonth = new System.Windows.Forms.Label();
            this.dtpPayMonth = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPaidStudId = new System.Windows.Forms.TextBox();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.btnReceiptInfoReset = new System.Windows.Forms.Button();
            this.lblPaidStudId = new System.Windows.Forms.Label();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.cmbSubjSearch = new System.Windows.Forms.ComboBox();
            this.cmbLevelSearch = new System.Windows.Forms.ComboBox();
            this.btnSrchAllPaid = new System.Windows.Forms.Button();
            this.btnSrchPaidLvlSubj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudPayHist)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStudPayHist);
            this.panel1.Controls.Add(this.lblPayMonth);
            this.panel1.Controls.Add(this.dtpPayMonth);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbSubjSearch);
            this.panel1.Controls.Add(this.cmbLevelSearch);
            this.panel1.Controls.Add(this.btnSrchAllPaid);
            this.panel1.Controls.Add(this.btnSrchPaidLvlSubj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 744);
            this.panel1.TabIndex = 0;
            // 
            // dgvStudPayHist
            // 
            this.dgvStudPayHist.AllowUserToDeleteRows = false;
            this.dgvStudPayHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudPayHist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStudPayHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudPayHist.Location = new System.Drawing.Point(12, 309);
            this.dgvStudPayHist.Name = "dgvStudPayHist";
            this.dgvStudPayHist.ReadOnly = true;
            this.dgvStudPayHist.RowHeadersWidth = 62;
            this.dgvStudPayHist.RowTemplate.Height = 33;
            this.dgvStudPayHist.Size = new System.Drawing.Size(1334, 423);
            this.dgvStudPayHist.TabIndex = 36;
            this.dgvStudPayHist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudPayHist_CellClick);
            // 
            // lblPayMonth
            // 
            this.lblPayMonth.AutoSize = true;
            this.lblPayMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayMonth.Location = new System.Drawing.Point(1030, 208);
            this.lblPayMonth.Name = "lblPayMonth";
            this.lblPayMonth.Size = new System.Drawing.Size(129, 32);
            this.lblPayMonth.TabIndex = 35;
            this.lblPayMonth.Text = "Pay Month";
            // 
            // dtpPayMonth
            // 
            this.dtpPayMonth.CustomFormat = "dd/MM/yyyy";
            this.dtpPayMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPayMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayMonth.Location = new System.Drawing.Point(1165, 203);
            this.dtpPayMonth.Name = "dtpPayMonth";
            this.dtpPayMonth.Size = new System.Drawing.Size(181, 39);
            this.dtpPayMonth.TabIndex = 34;
            this.dtpPayMonth.ValueChanged += new System.EventHandler(this.dtpPayMonth_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.txtPaidStudId);
            this.panel2.Controls.Add(this.txtPaymentId);
            this.panel2.Controls.Add(this.btnGenerateReceipt);
            this.panel2.Controls.Add(this.btnReceiptInfoReset);
            this.panel2.Controls.Add(this.lblPaidStudId);
            this.panel2.Controls.Add(this.lblPaymentId);
            this.panel2.Location = new System.Drawing.Point(186, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 132);
            this.panel2.TabIndex = 33;
            // 
            // txtPaidStudId
            // 
            this.txtPaidStudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaidStudId.Location = new System.Drawing.Point(281, 76);
            this.txtPaidStudId.Name = "txtPaidStudId";
            this.txtPaidStudId.ReadOnly = true;
            this.txtPaidStudId.Size = new System.Drawing.Size(150, 39);
            this.txtPaidStudId.TabIndex = 29;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaymentId.Location = new System.Drawing.Point(281, 18);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.ReadOnly = true;
            this.txtPaymentId.Size = new System.Drawing.Size(150, 39);
            this.txtPaymentId.TabIndex = 28;
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReceipt.Location = new System.Drawing.Point(644, 41);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(204, 46);
            this.btnGenerateReceipt.TabIndex = 27;
            this.btnGenerateReceipt.Text = "Generate Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // btnReceiptInfoReset
            // 
            this.btnReceiptInfoReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceiptInfoReset.Location = new System.Drawing.Point(487, 41);
            this.btnReceiptInfoReset.Name = "btnReceiptInfoReset";
            this.btnReceiptInfoReset.Size = new System.Drawing.Size(112, 46);
            this.btnReceiptInfoReset.TabIndex = 26;
            this.btnReceiptInfoReset.Text = "Reset";
            this.btnReceiptInfoReset.UseVisualStyleBackColor = true;
            this.btnReceiptInfoReset.Click += new System.EventHandler(this.btnReceiptInfoReset_Click_1);
            // 
            // lblPaidStudId
            // 
            this.lblPaidStudId.AutoSize = true;
            this.lblPaidStudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaidStudId.Location = new System.Drawing.Point(139, 79);
            this.lblPaidStudId.Name = "lblPaidStudId";
            this.lblPaidStudId.Size = new System.Drawing.Size(127, 32);
            this.lblPaidStudId.TabIndex = 1;
            this.lblPaidStudId.Text = "Student ID";
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentId.Location = new System.Drawing.Point(139, 21);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(136, 32);
            this.lblPaymentId.TabIndex = 0;
            this.lblPaymentId.Text = "Payment ID";
            // 
            // cmbSubjSearch
            // 
            this.cmbSubjSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubjSearch.FormattingEnabled = true;
            this.cmbSubjSearch.Location = new System.Drawing.Point(404, 261);
            this.cmbSubjSearch.Name = "cmbSubjSearch";
            this.cmbSubjSearch.Size = new System.Drawing.Size(182, 40);
            this.cmbSubjSearch.TabIndex = 32;
            // 
            // cmbLevelSearch
            // 
            this.cmbLevelSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLevelSearch.FormattingEnabled = true;
            this.cmbLevelSearch.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.cmbLevelSearch.Location = new System.Drawing.Point(88, 261);
            this.cmbLevelSearch.Name = "cmbLevelSearch";
            this.cmbLevelSearch.Size = new System.Drawing.Size(182, 40);
            this.cmbLevelSearch.TabIndex = 31;
            // 
            // btnSrchAllPaid
            // 
            this.btnSrchAllPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchAllPaid.Location = new System.Drawing.Point(738, 257);
            this.btnSrchAllPaid.Name = "btnSrchAllPaid";
            this.btnSrchAllPaid.Size = new System.Drawing.Size(147, 46);
            this.btnSrchAllPaid.TabIndex = 30;
            this.btnSrchAllPaid.Text = "Show All";
            this.btnSrchAllPaid.UseVisualStyleBackColor = true;
            this.btnSrchAllPaid.Click += new System.EventHandler(this.btnSrchAllPaid_Click);
            // 
            // btnSrchPaidLvlSubj
            // 
            this.btnSrchPaidLvlSubj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchPaidLvlSubj.Location = new System.Drawing.Point(620, 257);
            this.btnSrchPaidLvlSubj.Name = "btnSrchPaidLvlSubj";
            this.btnSrchPaidLvlSubj.Size = new System.Drawing.Size(112, 46);
            this.btnSrchPaidLvlSubj.TabIndex = 29;
            this.btnSrchPaidLvlSubj.Text = "Search";
            this.btnSrchPaidLvlSubj.UseVisualStyleBackColor = true;
            this.btnSrchPaidLvlSubj.Click += new System.EventHandler(this.btnSrchPaidLvlSubj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Level";
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1358, 744);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentHistory";
            this.Text = "Payment_History";
            this.Load += new System.EventHandler(this.PaymentHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudPayHist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPaidStudId;
        private TextBox txtPaymentId;
        private Button btnGenerateReceipt;
        private Button btnReceiptInfoReset;
        private Label lblPaidStudId;
        private Label lblPaymentId;
        private ComboBox cmbSubjSearch;
        private ComboBox cmbLevelSearch;
        private Button btnSrchAllPaid;
        private Button btnSrchPaidLvlSubj;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpPayMonth;
        private Label lblPayMonth;
        private DataGridView dgvStudPayHist;
    }
}