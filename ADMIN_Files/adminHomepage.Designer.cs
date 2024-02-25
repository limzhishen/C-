namespace IOOP_GROUP_22
{
    partial class adminHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminHomepage));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.lbllogout = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.btnUsermanage = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbluseramount = new System.Windows.Forms.Label();
            this.lblTotaluser = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblamount = new System.Windows.Forms.Label();
            this.lblTotalamount = new System.Windows.Forms.Label();
            this.btnShowprofile = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.pnlSubmenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTop.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1497, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 27);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(12, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 27);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblposition
            // 
            this.lblposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblposition.ForeColor = System.Drawing.Color.Honeydew;
            this.lblposition.Location = new System.Drawing.Point(670, 12);
            this.lblposition.Name = "lblposition";
            this.lblposition.Padding = new System.Windows.Forms.Padding(5);
            this.lblposition.Size = new System.Drawing.Size(209, 39);
            this.lblposition.TabIndex = 0;
            this.lblposition.Text = "Welcome Admin";
            // 
            // lbllogout
            // 
            this.lbllogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllogout.AutoSize = true;
            this.lbllogout.BackColor = System.Drawing.Color.Transparent;
            this.lbllogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbllogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbllogout.Location = new System.Drawing.Point(233, 703);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(86, 27);
            this.lbllogout.TabIndex = 1;
            this.lbllogout.Text = "Logout";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
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
            this.pnlMenu.TabIndex = 1;
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
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click_1);
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
            this.btnUsermanage.Click += new System.EventHandler(this.btnUsermanage_Click);
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
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pnlSubmenu);
            this.pnlBackground.Controls.Add(this.panel3);
            this.pnlBackground.Controls.Add(this.lbllogout);
            this.pnlBackground.Controls.Add(this.picLogout);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Controls.Add(this.btnShowprofile);
            this.pnlBackground.Controls.Add(this.lblEmail);
            this.pnlBackground.Controls.Add(this.lblName);
            this.pnlBackground.Controls.Add(this.lblAdmin);
            this.pnlBackground.Controls.Add(this.picAdmin);
            this.pnlBackground.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBackground.Location = new System.Drawing.Point(2, 155);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1570, 774);
            this.pnlBackground.TabIndex = 2;
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnProfile);
            this.pnlSubmenu.Location = new System.Drawing.Point(1, 0);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(134, 102);
            this.pnlSubmenu.TabIndex = 45;
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.lbluseramount);
            this.panel3.Controls.Add(this.lblTotaluser);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(764, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 133);
            this.panel3.TabIndex = 4;
            // 
            // lbluseramount
            // 
            this.lbluseramount.AutoSize = true;
            this.lbluseramount.ForeColor = System.Drawing.Color.White;
            this.lbluseramount.Location = new System.Drawing.Point(117, 75);
            this.lbluseramount.Name = "lbluseramount";
            this.lbluseramount.Size = new System.Drawing.Size(36, 41);
            this.lbluseramount.TabIndex = 0;
            this.lbluseramount.Text = "0";
            // 
            // lblTotaluser
            // 
            this.lblTotaluser.AutoSize = true;
            this.lblTotaluser.ForeColor = System.Drawing.Color.White;
            this.lblTotaluser.Location = new System.Drawing.Point(51, 13);
            this.lblTotaluser.Name = "lblTotaluser";
            this.lblTotaluser.Size = new System.Drawing.Size(165, 41);
            this.lblTotaluser.TabIndex = 0;
            this.lblTotaluser.Text = "Total User";
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.BackColor = System.Drawing.Color.Transparent;
            this.picLogout.Image = ((System.Drawing.Image)(resources.GetObject("picLogout.Image")));
            this.picLogout.Location = new System.Drawing.Point(325, 700);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(43, 27);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 2;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.lblamount);
            this.panel2.Controls.Add(this.lblTotalamount);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(1208, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 133);
            this.panel2.TabIndex = 3;
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.ForeColor = System.Drawing.Color.White;
            this.lblamount.Location = new System.Drawing.Point(114, 75);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(36, 41);
            this.lblamount.TabIndex = 0;
            this.lblamount.Text = "0";
            // 
            // lblTotalamount
            // 
            this.lblTotalamount.AutoSize = true;
            this.lblTotalamount.ForeColor = System.Drawing.Color.White;
            this.lblTotalamount.Location = new System.Drawing.Point(34, 13);
            this.lblTotalamount.Name = "lblTotalamount";
            this.lblTotalamount.Size = new System.Drawing.Size(209, 41);
            this.lblTotalamount.TabIndex = 0;
            this.lblTotalamount.Text = "Total Amount";
            // 
            // btnShowprofile
            // 
            this.btnShowprofile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowprofile.AutoSize = true;
            this.btnShowprofile.BackColor = System.Drawing.Color.Indigo;
            this.btnShowprofile.FlatAppearance.BorderSize = 0;
            this.btnShowprofile.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowprofile.ForeColor = System.Drawing.Color.White;
            this.btnShowprofile.Location = new System.Drawing.Point(149, 620);
            this.btnShowprofile.Name = "btnShowprofile";
            this.btnShowprofile.Size = new System.Drawing.Size(305, 55);
            this.btnShowprofile.TabIndex = 2;
            this.btnShowprofile.Text = "Show Profile";
            this.btnShowprofile.UseVisualStyleBackColor = false;
            this.btnShowprofile.Click += new System.EventHandler(this.btnShowprofile_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(149, 569);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(321, 27);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Tp069606@mail.apu.edu.my";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(193, 506);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "LIM ZHI SHEN";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(248, 455);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(120, 37);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "ADMIN";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAdmin
            // 
            this.picAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picAdmin.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(110, 56);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(377, 377);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // adminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1572, 930);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "adminHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Homepage";
            this.Load += new System.EventHandler(this.adminHomepage_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlSubmenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlTop;
        private Label lblposition;
        private Panel pnlMenu;
        private Button btnIncome;
        private Button btnHome;
        private Button btnAcc;
        private Button btnReceptionist;
        private Button btnTutor;
        private Button btnUsermanage;
        private Label lbllogout;
        private Panel pnlBackground;
        private Button btnShowprofile;
        private Label lblName;
        private Label lblAdmin;
        private PictureBox picAdmin;
        private Label lblEmail;
        private Panel panel3;
        private Label lbluseramount;
        private Label lblTotaluser;
        private Panel panel2;
        private Label lblamount;
        private Label lblTotalamount;
        private Label lblDate;
        private System.Windows.Forms.Timer tmrTime;
        private Label lblTime;
        private Panel pnlSubmenu;
        private Button btnLogout;
        private Button btnProfile;
        private PictureBox picLogout;
    }
}