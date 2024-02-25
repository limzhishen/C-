namespace IOOP_GROUP_22
{
    partial class userManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userManage));
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
            this.btnUsermanage = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbUserrole = new System.Windows.Forms.ComboBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchname = new System.Windows.Forms.Label();
            this.txtSearchname = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tooltiptutor = new System.Windows.Forms.ToolTip(this.components);
            this.Errorprovide = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errorprovide)).BeginInit();
            this.pnlSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1480, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 27);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Time";
            // 
            // lblposition
            // 
            this.lblposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblposition.ForeColor = System.Drawing.Color.Honeydew;
            this.lblposition.Location = new System.Drawing.Point(692, 16);
            this.lblposition.Name = "lblposition";
            this.lblposition.Padding = new System.Windows.Forms.Padding(5);
            this.lblposition.Size = new System.Drawing.Size(250, 39);
            this.lblposition.TabIndex = 22;
            this.lblposition.Text = "User Manage Page";
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
            this.pnlTop.TabIndex = 21;
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
            this.pnlMenu.Controls.Add(this.btnUsermanage);
            this.pnlMenu.Controls.Add(this.btnIncome);
            this.pnlMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenu.Location = new System.Drawing.Point(0, 66);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1572, 90);
            this.pnlMenu.TabIndex = 20;
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
            // btnUsermanage
            // 
            this.btnUsermanage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUsermanage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsermanage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnUsermanage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnUsermanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsermanage.Image = ((System.Drawing.Image)(resources.GetObject("btnUsermanage.Image")));
            this.btnUsermanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsermanage.Location = new System.Drawing.Point(1148, 0);
            this.btnUsermanage.Name = "btnUsermanage";
            this.btnUsermanage.Size = new System.Drawing.Size(212, 90);
            this.btnUsermanage.TabIndex = 1;
            this.btnUsermanage.Text = "User\r\nManage";
            this.btnUsermanage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsermanage.UseVisualStyleBackColor = true;
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
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvUser.Location = new System.Drawing.Point(14, 367);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 33;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(1540, 551);
            this.dgvUser.TabIndex = 22;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Userid";
            this.Column1.HeaderText = "Userid";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Username";
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name";
            this.Column4.HeaderText = "Name";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Contact";
            this.Column6.HeaderText = "Contact";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Gender";
            this.Column7.HeaderText = "Gender";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Dob";
            this.Column8.HeaderText = "Date of Birth";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "User_Role";
            this.Column9.HeaderText = "User role";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Profile_image";
            this.Column10.HeaderText = "Profile Image";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(118, 27);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "User Role";
            // 
            // cmbUserrole
            // 
            this.cmbUserrole.FormattingEnabled = true;
            this.cmbUserrole.Location = new System.Drawing.Point(21, 39);
            this.cmbUserrole.Name = "cmbUserrole";
            this.cmbUserrole.Size = new System.Drawing.Size(204, 35);
            this.cmbUserrole.TabIndex = 24;
            this.cmbUserrole.SelectedIndexChanged += new System.EventHandler(this.cmbUserrole_SelectedIndexChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(192, 194);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(183, 35);
            this.txtusername.TabIndex = 25;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(47, 201);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 27);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(401, 201);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 27);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(543, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 35);
            this.txtPassword.TabIndex = 25;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlSearch.Controls.Add(this.btnAssign);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.lblSearchname);
            this.pnlSearch.Controls.Add(this.txtSearchname);
            this.pnlSearch.Controls.Add(this.lblUser);
            this.pnlSearch.Controls.Add(this.cmbUserrole);
            this.pnlSearch.Location = new System.Drawing.Point(14, 262);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1540, 89);
            this.pnlSearch.TabIndex = 26;
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.Location = new System.Drawing.Point(1388, 12);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(134, 64);
            this.btnAssign.TabIndex = 27;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            this.btnAssign.MouseHover += new System.EventHandler(this.btnAssign_MouseHover);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(745, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 65);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(587, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 65);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Assign Tutor Form and Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchname
            // 
            this.lblSearchname.AutoSize = true;
            this.lblSearchname.Location = new System.Drawing.Point(299, 9);
            this.lblSearchname.Name = "lblSearchname";
            this.lblSearchname.Size = new System.Drawing.Size(205, 27);
            this.lblSearchname.TabIndex = 26;
            this.lblSearchname.Text = "Search with name";
            // 
            // txtSearchname
            // 
            this.txtSearchname.Location = new System.Drawing.Point(299, 41);
            this.txtSearchname.Name = "txtSearchname";
            this.txtSearchname.Size = new System.Drawing.Size(211, 35);
            this.txtSearchname.TabIndex = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(908, 178);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 64);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1141, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 64);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(1372, 178);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(182, 64);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Errorprovide
            // 
            this.Errorprovide.ContainerControl = this;
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnProfile);
            this.pnlSubmenu.Location = new System.Drawing.Point(4, 157);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(134, 102);
            this.pnlSubmenu.TabIndex = 76;
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
            // userManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1572, 930);
            this.Controls.Add(this.pnlSubmenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "userManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userManage";
            this.Load += new System.EventHandler(this.userManage_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errorprovide)).EndInit();
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
        private Button btnUsermanage;
        private Button btnIncome;
        private DataGridView dgvUser;
        private Label lblUser;
        private ComboBox cmbUserrole;
        private TextBox txtusername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Panel pnlSearch;
        private Button btnSearch;
        private Label lblSearchname;
        private TextBox txtSearchname;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnReset;
        private Label label1;
        private Button btnAssign;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private ToolTip tooltiptutor;
        private ErrorProvider Errorprovide;
        private Panel pnlSubmenu;
        private Button btnLogout;
        private Button btnProfile;
        private System.Windows.Forms.Timer tmrTime;
    }
}