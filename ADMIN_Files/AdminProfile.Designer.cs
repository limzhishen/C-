namespace IOOP_GROUP_22
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnUsermanage = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.btnTutor = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.Dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.Errorprovide = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpload = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Errorprovide)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(111, 176);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(447, 360);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 61;
            this.picAdmin.TabStop = false;
            this.picAdmin.Click += new System.EventHandler(this.picAdmin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnReset.Location = new System.Drawing.Point(1220, 736);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(182, 64);
            this.btnReset.TabIndex = 60;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(947, 736);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 64);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(247, 752);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 35);
            this.txtEmail.TabIndex = 56;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(1077, 413);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(232, 35);
            this.txtContact.TabIndex = 55;
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
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1077, 327);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 35);
            this.txtPassword.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(247, 667);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 35);
            this.txtName.TabIndex = 57;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1077, 227);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 35);
            this.txtUsername.TabIndex = 51;
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
            this.pnlMenu.Location = new System.Drawing.Point(0, 67);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1572, 90);
            this.pnlMenu.TabIndex = 42;
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(111, 755);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 27);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(905, 421);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(109, 27);
            this.lblContact.TabIndex = 45;
            this.lblContact.Text = "Contact :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(108, 667);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 27);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(885, 331);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 27);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(880, 236);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(136, 27);
            this.lblUsername.TabIndex = 43;
            this.lblUsername.Text = "Username :";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.lblposition);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1572, 66);
            this.pnlTop.TabIndex = 62;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1497, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 27);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "Time";
            // 
            // lblposition
            // 
            this.lblposition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblposition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblposition.ForeColor = System.Drawing.Color.Honeydew;
            this.lblposition.Location = new System.Drawing.Point(663, 16);
            this.lblposition.Name = "lblposition";
            this.lblposition.Padding = new System.Windows.Forms.Padding(5);
            this.lblposition.Size = new System.Drawing.Size(260, 44);
            this.lblposition.TabIndex = 24;
            this.lblposition.Text = "Admin Profile Page";
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
            // Dtp_Dob
            // 
            this.Dtp_Dob.Location = new System.Drawing.Point(1090, 619);
            this.Dtp_Dob.Name = "Dtp_Dob";
            this.Dtp_Dob.Size = new System.Drawing.Size(300, 35);
            this.Dtp_Dob.TabIndex = 69;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(1232, 514);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(117, 31);
            this.radFemale.TabIndex = 67;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(1086, 516);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(88, 31);
            this.radMale.TabIndex = 68;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Location = new System.Drawing.Point(865, 627);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(160, 27);
            this.lblDateofbirth.TabIndex = 66;
            this.lblDateofbirth.Text = "Date of Birth :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(905, 518);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(107, 27);
            this.lblGender.TabIndex = 65;
            this.lblGender.Text = "Gender :";
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnProfile);
            this.pnlSubmenu.Location = new System.Drawing.Point(2, 156);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(134, 102);
            this.pnlSubmenu.TabIndex = 71;
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
            // Errorprovide
            // 
            this.Errorprovide.ContainerControl = this;
            this.Errorprovide.Icon = ((System.Drawing.Icon)(resources.GetObject("Errorprovide.Icon")));
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpload.Location = new System.Drawing.Point(228, 579);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(182, 64);
            this.btnUpload.TabIndex = 59;
            this.btnUpload.Text = "Upload image";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // AdminProfile
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
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AdminProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Errorprovide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picAdmin;
        private Button btnReset;
        private Button btnEdit;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Button btnIncome;
        private Button btnUsermanage;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtUsername;
        private Panel pnlMenu;
        private Button btnHome;
        private Button btnAcc;
        private Button btnReceptionist;
        private Button btnTutor;
        private Label lblEmail;
        private Label lblContact;
        private Label lblName;
        private Label lblPassword;
        private Label lblUsername;
        private Panel pnlTop;
        private Label lblDate;
        private Label lblTime;
        private Label lblposition;
        private DateTimePicker Dtp_Dob;
        private RadioButton radFemale;
        private RadioButton radMale;
        private Label lblDateofbirth;
        private Label lblGender;
        private Panel pnlSubmenu;
        private Button btnLogout;
        private Button btnProfile;
        private ErrorProvider Errorprovide;
        private Button btnUpload;
        private System.Windows.Forms.Timer tmrTime;
    }
}