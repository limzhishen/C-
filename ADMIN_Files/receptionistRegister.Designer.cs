namespace IOOP_GROUP_22
{
    partial class receptionistRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receptionistRegister));
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picRecp = new System.Windows.Forms.PictureBox();
            this.Dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.Errorprovide = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Errorprovide)).BeginInit();
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
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Time";
            // 
            // lblposition
            // 
            this.lblposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblposition.ForeColor = System.Drawing.Color.Honeydew;
            this.lblposition.Location = new System.Drawing.Point(615, 16);
            this.lblposition.Name = "lblposition";
            this.lblposition.Padding = new System.Windows.Forms.Padding(5);
            this.lblposition.Size = new System.Drawing.Size(350, 39);
            this.lblposition.TabIndex = 18;
            this.lblposition.Text = "Receptionist Register Page";
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
            this.pnlTop.TabIndex = 17;
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
            this.pnlMenu.TabIndex = 16;
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnReset.Location = new System.Drawing.Point(1242, 811);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(182, 64);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(1004, 811);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(182, 64);
            this.btnRegister.TabIndex = 38;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(318, 526);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 35);
            this.txtEmail.TabIndex = 33;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(318, 632);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(264, 35);
            this.txtContact.TabIndex = 32;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(318, 324);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(264, 35);
            this.txtPassword.TabIndex = 30;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(318, 426);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 35);
            this.txtName.TabIndex = 34;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(318, 221);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(264, 35);
            this.txtUsername.TabIndex = 28;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(182, 526);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 27);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(159, 635);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(109, 27);
            this.lblContact.TabIndex = 20;
            this.lblContact.Text = "Contact :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 426);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(165, 27);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Recep Name :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(137, 327);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 27);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(132, 229);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(136, 27);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username :";
            // 
            // picRecp
            // 
            this.picRecp.Image = ((System.Drawing.Image)(resources.GetObject("picRecp.Image")));
            this.picRecp.Location = new System.Drawing.Point(833, 286);
            this.picRecp.Name = "picRecp";
            this.picRecp.Size = new System.Drawing.Size(527, 424);
            this.picRecp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecp.TabIndex = 40;
            this.picRecp.TabStop = false;
            // 
            // Dtp_Dob
            // 
            this.Dtp_Dob.Location = new System.Drawing.Point(318, 748);
            this.Dtp_Dob.Name = "Dtp_Dob";
            this.Dtp_Dob.Size = new System.Drawing.Size(264, 35);
            this.Dtp_Dob.TabIndex = 74;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(1214, 200);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(117, 31);
            this.radFemale.TabIndex = 72;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(1019, 200);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(88, 31);
            this.radMale.TabIndex = 73;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Location = new System.Drawing.Point(108, 756);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(160, 27);
            this.lblDateofbirth.TabIndex = 71;
            this.lblDateofbirth.Text = "Date of Birth :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(829, 204);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(107, 27);
            this.lblGender.TabIndex = 70;
            this.lblGender.Text = "Gender :";
            // 
            // Errorprovide
            // 
            this.Errorprovide.ContainerControl = this;
            this.Errorprovide.Icon = ((System.Drawing.Icon)(resources.GetObject("Errorprovide.Icon")));
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnProfile);
            this.pnlSubmenu.Location = new System.Drawing.Point(2, 157);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(134, 102);
            this.pnlSubmenu.TabIndex = 75;
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
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(771, 811);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(182, 64);
            this.btnUpload.TabIndex = 38;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // receptionistRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1572, 930);
            this.Controls.Add(this.pnlSubmenu);
            this.Controls.Add(this.Dtp_Dob);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.lblDateofbirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.picRecp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "receptionistRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receptionistRegister";
            this.Load += new System.EventHandler(this.receptionistRegister_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRecp)).EndInit();
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
        private Button btnReset;
        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblContact;
        private Label lblName;
        private Label lblPassword;
        private Label lblUsername;
        private PictureBox picRecp;
        private DateTimePicker Dtp_Dob;
        private RadioButton radFemale;
        private RadioButton radMale;
        private Label lblDateofbirth;
        private Label lblGender;
        private ErrorProvider Errorprovide;
        private Panel pnlSubmenu;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnUpload;
        private System.Windows.Forms.Timer tmrTime;
    }
}