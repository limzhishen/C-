namespace IOOP_GROUP_22
{
    partial class MonthlyIncome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyIncome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.btnUsermanagement = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblSearchbar = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.pnlSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1497, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 27);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Time";
            // 
            // lblposition
            // 
            this.lblposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblposition.ForeColor = System.Drawing.Color.Honeydew;
            this.lblposition.Location = new System.Drawing.Point(666, 16);
            this.lblposition.Name = "lblposition";
            this.lblposition.Padding = new System.Windows.Forms.Padding(5);
            this.lblposition.Size = new System.Drawing.Size(281, 39);
            this.lblposition.TabIndex = 26;
            this.lblposition.Text = "Monthly Income Page";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.lblposition);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1572, 66);
            this.pnlTop.TabIndex = 25;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(12, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 27);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnAcc);
            this.pnlMenu.Controls.Add(this.btnReceptionist);
            this.pnlMenu.Controls.Add(this.btnTutor);
            this.pnlMenu.Controls.Add(this.btnUsermanagement);
            this.pnlMenu.Controls.Add(this.btnIncome);
            this.pnlMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenu.Location = new System.Drawing.Point(0, 66);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1572, 90);
            this.pnlMenu.TabIndex = 24;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(112, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(1);
            this.btnHome.Size = new System.Drawing.Size(212, 90);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcc.BackgroundImage")));
            this.btnAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAcc.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Location = new System.Drawing.Point(0, 0);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Padding = new System.Windows.Forms.Padding(1);
            this.btnAcc.Size = new System.Drawing.Size(112, 90);
            this.btnAcc.TabIndex = 1;
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReceptionist.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReceptionist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnReceptionist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceptionist.Image = ((System.Drawing.Image)(resources.GetObject("btnReceptionist.Image")));
            this.btnReceptionist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceptionist.Location = new System.Drawing.Point(724, 0);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(212, 90);
            this.btnReceptionist.TabIndex = 1;
            this.btnReceptionist.Text = "   Receptionist \r\n        Register";
            this.btnReceptionist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceptionist.UseVisualStyleBackColor = true;
            this.btnReceptionist.Click += new System.EventHandler(this.btnReceptionist_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTutor.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnTutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutor.Image = ((System.Drawing.Image)(resources.GetObject("btnTutor.Image")));
            this.btnTutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutor.Location = new System.Drawing.Point(936, 0);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Size = new System.Drawing.Size(212, 90);
            this.btnTutor.TabIndex = 1;
            this.btnTutor.Text = "       Tutor\r\n        Register";
            this.btnTutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnUsermanagement
            // 
            this.btnUsermanagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUsermanagement.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsermanagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnUsermanagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnUsermanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsermanagement.Image = ((System.Drawing.Image)(resources.GetObject("btnUsermanagement.Image")));
            this.btnUsermanagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsermanagement.Location = new System.Drawing.Point(1148, 0);
            this.btnUsermanagement.Name = "btnUsermanagement";
            this.btnUsermanagement.Size = new System.Drawing.Size(212, 90);
            this.btnUsermanagement.TabIndex = 1;
            this.btnUsermanagement.Text = "User\r\nManage";
            this.btnUsermanagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsermanagement.UseVisualStyleBackColor = true;
            this.btnUsermanagement.Click += new System.EventHandler(this.btnUsermanagement_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIncome.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(1360, 0);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(212, 90);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.Text = "Monthly \r\nIncome";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncome.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSearch.Controls.Add(this.btnPrint);
            this.pnlSearch.Controls.Add(this.btnReset);
            this.pnlSearch.Controls.Add(this.btnCheck);
            this.pnlSearch.Controls.Add(this.lblYear);
            this.pnlSearch.Controls.Add(this.lblSearchbar);
            this.pnlSearch.Controls.Add(this.lblIncome);
            this.pnlSearch.Controls.Add(this.lblTotalIncome);
            this.pnlSearch.Controls.Add(this.cmbYear);
            this.pnlSearch.Controls.Add(this.lblSubject);
            this.pnlSearch.Controls.Add(this.cmbSubject);
            this.pnlSearch.Controls.Add(this.lblForm);
            this.pnlSearch.Controls.Add(this.cmbForm);
            this.pnlSearch.Controls.Add(this.lblMonth);
            this.pnlSearch.Controls.Add(this.cmbMonth);
            this.pnlSearch.Location = new System.Drawing.Point(15, 166);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1540, 89);
            this.pnlSearch.TabIndex = 29;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(1382, 31);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 48);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(1234, 31);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 48);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Location = new System.Drawing.Point(1081, 31);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(131, 48);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 9);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 27);
            this.lblYear.TabIndex = 23;
            this.lblYear.Text = "Year";
            // 
            // lblSearchbar
            // 
            this.lblSearchbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchbar.AutoSize = true;
            this.lblSearchbar.BackColor = System.Drawing.SystemColors.Control;
            this.lblSearchbar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblSearchbar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSearchbar.Location = new System.Drawing.Point(1414, 1);
            this.lblSearchbar.Name = "lblSearchbar";
            this.lblSearchbar.Size = new System.Drawing.Size(123, 27);
            this.lblSearchbar.TabIndex = 25;
            this.lblSearchbar.Text = "Searchbar";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncome.Location = new System.Drawing.Point(616, 35);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Padding = new System.Windows.Forms.Padding(5);
            this.lblIncome.Size = new System.Drawing.Size(112, 39);
            this.lblIncome.TabIndex = 23;
            this.lblIncome.Text = "RM1400";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(604, 7);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(147, 27);
            this.lblTotalIncome.TabIndex = 23;
            this.lblTotalIncome.Text = "Total Income";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(13, 39);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(146, 35);
            this.cmbYear.TabIndex = 24;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(309, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(94, 27);
            this.lblSubject.TabIndex = 23;
            this.lblSubject.Text = "Subject";
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(309, 39);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(146, 35);
            this.cmbSubject.TabIndex = 24;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Location = new System.Drawing.Point(165, 9);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(68, 27);
            this.lblForm.TabIndex = 23;
            this.lblForm.Text = "Form";
            // 
            // cmbForm
            // 
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.Location = new System.Drawing.Point(165, 39);
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(138, 35);
            this.cmbForm.TabIndex = 24;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(461, 9);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(79, 27);
            this.lblMonth.TabIndex = 23;
            this.lblMonth.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(461, 39);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(138, 35);
            this.cmbMonth.TabIndex = 24;
            // 
            // dgvIncome
            // 
            this.dgvIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncome.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncome.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIncome.Location = new System.Drawing.Point(14, 279);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.ReadOnly = true;
            this.dgvIncome.RowHeadersWidth = 62;
            this.dgvIncome.RowTemplate.Height = 33;
            this.dgvIncome.Size = new System.Drawing.Size(1546, 639);
            this.dgvIncome.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Paymentid";
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Payid";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Studentid";
            this.Column2.FillWeight = 20F;
            this.Column2.HeaderText = "Stu_id";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Name";
            this.Column3.FillWeight = 40.90909F;
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Form";
            this.Column4.FillWeight = 20F;
            this.Column4.HeaderText = "Form";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Subject_id";
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "Sub_id";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Subject_Name";
            this.Column6.FillWeight = 40.90909F;
            this.Column6.HeaderText = "Sub_Name";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Fee";
            this.Column7.FillWeight = 20F;
            this.Column7.HeaderText = "Fee";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Payment_Date";
            this.Column8.FillWeight = 40.90909F;
            this.Column8.HeaderText = "Pay_Date";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Payment_status";
            this.Column9.FillWeight = 40.90909F;
            this.Column9.HeaderText = "Pay_Status";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnProfile);
            this.pnlSubmenu.Location = new System.Drawing.Point(2, 158);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(134, 102);
            this.pnlSubmenu.TabIndex = 46;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 50);
            this.btnLogout.TabIndex = 45;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(134, 50);
            this.btnProfile.TabIndex = 45;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // MonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1572, 930);
            this.Controls.Add(this.pnlSubmenu);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1594, 986);
            this.Name = "MonthlyIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyIncome";
            this.Load += new System.EventHandler(this.MonthlyIncome_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.pnlSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTime;
        private Label lblposition;
        private Panel pnlTop;
        private Label lblDate;
        private Panel pnlMenu;
        private Button btnHome;
        private Button btnAcc;
        private Button btnReceptionist;
        private Button btnTutor;
        private Button btnUsermanagement;
        private Button btnIncome;
        private Panel pnlSearch;
        private Button btnCheck;
        private Label lblSearchbar;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblForm;
        private ComboBox cmbForm;
        private Label lblMonth;
        private ComboBox cmbMonth;
        private Button btnReset;
        private DataGridView dgvIncome;
        private Button btnPrint;
        private Panel pnlSubmenu;
        private Button btnLogout;
        private Button btnProfile;
        private System.Windows.Forms.Timer tmrTime;
        private Label lblIncome;
        private Label lblTotalIncome;
        private Label lblYear;
        private ComboBox cmbYear;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}