using System.Windows.Forms;

namespace IOOP_GROUP_22.ReceptionistForms
{
    partial class MakePayment
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
            this.btnGenerateLstMthPay = new System.Windows.Forms.Button();
            this.dgvStudPay = new System.Windows.Forms.DataGridView();
            this.dtpPayMonth = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPayStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPayMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtPaidSubject = new System.Windows.Forms.TextBox();
            this.txtPaidFees = new System.Windows.Forms.TextBox();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.txtPaidStudId = new System.Windows.Forms.TextBox();
            this.txtPaidLevel = new System.Windows.Forms.TextBox();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.btnReceiptInfoReset = new System.Windows.Forms.Button();
            this.lblPaidFees = new System.Windows.Forms.Label();
            this.lblPaidSubj = new System.Windows.Forms.Label();
            this.lblPaidStudId = new System.Windows.Forms.Label();
            this.lblPaidLevel = new System.Windows.Forms.Label();
            this.cmbSubjSearch = new System.Windows.Forms.ComboBox();
            this.cmbLevelSearch = new System.Windows.Forms.ComboBox();
            this.btnSrchAllPaid = new System.Windows.Forms.Button();
            this.btnSrchPaidLvlSubj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudPay)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateLstMthPay);
            this.panel1.Controls.Add(this.dgvStudPay);
            this.panel1.Controls.Add(this.dtpPayMonth);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.lblPayStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPayMonth);
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
            // btnGenerateLstMthPay
            // 
            this.btnGenerateLstMthPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateLstMthPay.Location = new System.Drawing.Point(982, 267);
            this.btnGenerateLstMthPay.Name = "btnGenerateLstMthPay";
            this.btnGenerateLstMthPay.Size = new System.Drawing.Size(365, 46);
            this.btnGenerateLstMthPay.TabIndex = 49;
            this.btnGenerateLstMthPay.Text = "Generate Last Month Payment";
            this.btnGenerateLstMthPay.UseVisualStyleBackColor = true;
            this.btnGenerateLstMthPay.Click += new System.EventHandler(this.btnGenerateLstMthPay_Click);
            // 
            // dgvStudPay
            // 
            this.dgvStudPay.AllowUserToDeleteRows = false;
            this.dgvStudPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudPay.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStudPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudPay.Location = new System.Drawing.Point(12, 365);
            this.dgvStudPay.Name = "dgvStudPay";
            this.dgvStudPay.ReadOnly = true;
            this.dgvStudPay.RowHeadersWidth = 62;
            this.dgvStudPay.RowTemplate.Height = 33;
            this.dgvStudPay.Size = new System.Drawing.Size(1334, 367);
            this.dgvStudPay.TabIndex = 48;
            this.dgvStudPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudPay_CellClick);
            // 
            // dtpPayMonth
            // 
            this.dtpPayMonth.CustomFormat = "dd/MM/yyyy";
            this.dtpPayMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPayMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayMonth.Location = new System.Drawing.Point(1143, 222);
            this.dtpPayMonth.Name = "dtpPayMonth";
            this.dtpPayMonth.Size = new System.Drawing.Size(181, 39);
            this.dtpPayMonth.TabIndex = 47;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cmbStatus.Location = new System.Drawing.Point(1211, 321);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(134, 40);
            this.cmbStatus.TabIndex = 46;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblPayStatus
            // 
            this.lblPayStatus.AutoSize = true;
            this.lblPayStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayStatus.Location = new System.Drawing.Point(1127, 322);
            this.lblPayStatus.Name = "lblPayStatus";
            this.lblPayStatus.Size = new System.Drawing.Size(78, 32);
            this.lblPayStatus.TabIndex = 45;
            this.lblPayStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1216, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 43;
            // 
            // lblPayMonth
            // 
            this.lblPayMonth.AutoSize = true;
            this.lblPayMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayMonth.Location = new System.Drawing.Point(994, 227);
            this.lblPayMonth.Name = "lblPayMonth";
            this.lblPayMonth.Size = new System.Drawing.Size(134, 32);
            this.lblPayMonth.TabIndex = 42;
            this.lblPayMonth.Text = "Pay Month:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPaymentId);
            this.panel2.Controls.Add(this.txtPaidSubject);
            this.panel2.Controls.Add(this.txtPaidFees);
            this.panel2.Controls.Add(this.lblPaymentId);
            this.panel2.Controls.Add(this.txtPaidStudId);
            this.panel2.Controls.Add(this.txtPaidLevel);
            this.panel2.Controls.Add(this.btnGenerateReceipt);
            this.panel2.Controls.Add(this.btnReceiptInfoReset);
            this.panel2.Controls.Add(this.lblPaidFees);
            this.panel2.Controls.Add(this.lblPaidSubj);
            this.panel2.Controls.Add(this.lblPaidStudId);
            this.panel2.Controls.Add(this.lblPaidLevel);
            this.panel2.Location = new System.Drawing.Point(12, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 185);
            this.panel2.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(162, 122);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(150, 39);
            this.txtName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Name";
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaymentId.Location = new System.Drawing.Point(850, 72);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.ReadOnly = true;
            this.txtPaymentId.Size = new System.Drawing.Size(150, 39);
            this.txtPaymentId.TabIndex = 34;
            // 
            // txtPaidSubject
            // 
            this.txtPaidSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaidSubject.Location = new System.Drawing.Point(509, 45);
            this.txtPaidSubject.Name = "txtPaidSubject";
            this.txtPaidSubject.ReadOnly = true;
            this.txtPaidSubject.Size = new System.Drawing.Size(150, 39);
            this.txtPaidSubject.TabIndex = 32;
            // 
            // txtPaidFees
            // 
            this.txtPaidFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaidFees.Location = new System.Drawing.Point(509, 90);
            this.txtPaidFees.Name = "txtPaidFees";
            this.txtPaidFees.ReadOnly = true;
            this.txtPaidFees.Size = new System.Drawing.Size(150, 39);
            this.txtPaidFees.TabIndex = 31;
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentId.Location = new System.Drawing.Point(708, 72);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(136, 32);
            this.lblPaymentId.TabIndex = 33;
            this.lblPaymentId.Text = "Payment ID";
            // 
            // txtPaidStudId
            // 
            this.txtPaidStudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaidStudId.Location = new System.Drawing.Point(162, 72);
            this.txtPaidStudId.Name = "txtPaidStudId";
            this.txtPaidStudId.ReadOnly = true;
            this.txtPaidStudId.Size = new System.Drawing.Size(150, 39);
            this.txtPaidStudId.TabIndex = 29;
            // 
            // txtPaidLevel
            // 
            this.txtPaidLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaidLevel.Location = new System.Drawing.Point(162, 20);
            this.txtPaidLevel.Name = "txtPaidLevel";
            this.txtPaidLevel.ReadOnly = true;
            this.txtPaidLevel.Size = new System.Drawing.Size(150, 39);
            this.txtPaidLevel.TabIndex = 28;
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReceipt.Location = new System.Drawing.Point(1107, 95);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(204, 46);
            this.btnGenerateReceipt.TabIndex = 27;
            this.btnGenerateReceipt.Text = "Make Payment";
            this.btnGenerateReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // btnReceiptInfoReset
            // 
            this.btnReceiptInfoReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceiptInfoReset.Location = new System.Drawing.Point(1153, 43);
            this.btnReceiptInfoReset.Name = "btnReceiptInfoReset";
            this.btnReceiptInfoReset.Size = new System.Drawing.Size(112, 46);
            this.btnReceiptInfoReset.TabIndex = 26;
            this.btnReceiptInfoReset.Text = "Reset";
            this.btnReceiptInfoReset.UseVisualStyleBackColor = true;
            this.btnReceiptInfoReset.Click += new System.EventHandler(this.btnReceiptInfoReset_Click);
            // 
            // lblPaidFees
            // 
            this.lblPaidFees.AutoSize = true;
            this.lblPaidFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaidFees.Location = new System.Drawing.Point(359, 93);
            this.lblPaidFees.Name = "lblPaidFees";
            this.lblPaidFees.Size = new System.Drawing.Size(110, 32);
            this.lblPaidFees.TabIndex = 3;
            this.lblPaidFees.Text = "Total Fee";
            // 
            // lblPaidSubj
            // 
            this.lblPaidSubj.AutoSize = true;
            this.lblPaidSubj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaidSubj.Location = new System.Drawing.Point(359, 45);
            this.lblPaidSubj.Name = "lblPaidSubj";
            this.lblPaidSubj.Size = new System.Drawing.Size(144, 32);
            this.lblPaidSubj.TabIndex = 2;
            this.lblPaidSubj.Text = "Paid Subject";
            // 
            // lblPaidStudId
            // 
            this.lblPaidStudId.AutoSize = true;
            this.lblPaidStudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaidStudId.Location = new System.Drawing.Point(29, 75);
            this.lblPaidStudId.Name = "lblPaidStudId";
            this.lblPaidStudId.Size = new System.Drawing.Size(127, 32);
            this.lblPaidStudId.TabIndex = 1;
            this.lblPaidStudId.Text = "Student ID";
            // 
            // lblPaidLevel
            // 
            this.lblPaidLevel.AutoSize = true;
            this.lblPaidLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaidLevel.Location = new System.Drawing.Point(29, 23);
            this.lblPaidLevel.Name = "lblPaidLevel";
            this.lblPaidLevel.Size = new System.Drawing.Size(69, 32);
            this.lblPaidLevel.TabIndex = 0;
            this.lblPaidLevel.Text = "Level";
            // 
            // cmbSubjSearch
            // 
            this.cmbSubjSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubjSearch.FormattingEnabled = true;
            this.cmbSubjSearch.Location = new System.Drawing.Point(414, 319);
            this.cmbSubjSearch.Name = "cmbSubjSearch";
            this.cmbSubjSearch.Size = new System.Drawing.Size(182, 40);
            this.cmbSubjSearch.TabIndex = 40;
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
            this.cmbLevelSearch.Location = new System.Drawing.Point(86, 319);
            this.cmbLevelSearch.Name = "cmbLevelSearch";
            this.cmbLevelSearch.Size = new System.Drawing.Size(182, 40);
            this.cmbLevelSearch.TabIndex = 39;
            // 
            // btnSrchAllPaid
            // 
            this.btnSrchAllPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchAllPaid.Location = new System.Drawing.Point(720, 315);
            this.btnSrchAllPaid.Name = "btnSrchAllPaid";
            this.btnSrchAllPaid.Size = new System.Drawing.Size(147, 46);
            this.btnSrchAllPaid.TabIndex = 38;
            this.btnSrchAllPaid.Text = "Show All";
            this.btnSrchAllPaid.UseVisualStyleBackColor = true;
            this.btnSrchAllPaid.Click += new System.EventHandler(this.btnSrchAllPaid_Click);
            // 
            // btnSrchPaidLvlSubj
            // 
            this.btnSrchPaidLvlSubj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchPaidLvlSubj.Location = new System.Drawing.Point(602, 315);
            this.btnSrchPaidLvlSubj.Name = "btnSrchPaidLvlSubj";
            this.btnSrchPaidLvlSubj.Size = new System.Drawing.Size(112, 46);
            this.btnSrchPaidLvlSubj.TabIndex = 37;
            this.btnSrchPaidLvlSubj.Text = "Search";
            this.btnSrchPaidLvlSubj.UseVisualStyleBackColor = true;
            this.btnSrchPaidLvlSubj.Click += new System.EventHandler(this.btnSrchPaidLvlSubj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(315, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Level";
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1358, 744);
            this.Controls.Add(this.panel1);
            this.Name = "MakePayment";
            this.Text = "Make_Payment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudPay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPaidFees;
        private TextBox txtPaidStudId;
        private TextBox txtPaidLevel;
        private Button btnGenerateReceipt;
        private Button btnReceiptInfoReset;
        private Label lblPaidFees;
        private Label lblPaidSubj;
        private Label lblPaidStudId;
        private Label lblPaidLevel;
        private ComboBox cmbSubjSearch;
        private ComboBox cmbLevelSearch;
        private Button btnSrchAllPaid;
        private Button btnSrchPaidLvlSubj;
        private Label label2;
        private Label label1;
        private Label lblPayMonth;
        private Label label3;
        private ComboBox cmbStatus;
        private Label lblPayStatus;
        private DateTimePicker dtpPayMonth;
        private DataGridView dgvStudPay;
        private Button btnGenerateLstMthPay;
        private TextBox txtPaidSubject;
        private TextBox txtPaymentId;
        private Label lblPaymentId;
        private TextBox txtName;
        private Label label4;
    }
}