namespace IOOP_GROUP_22.ReceptionistForms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.pnlProfilePic = new System.Windows.Forms.Panel();
            this.btnUploadProfilePic = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.picProfilePic = new System.Windows.Forms.PictureBox();
            this.pnlProfileInfo = new System.Windows.Forms.Panel();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.llbChangePw = new System.Windows.Forms.LinkLabel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnProfileSaveChange = new System.Windows.Forms.Button();
            this.btnProfileEdit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlProfilePic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).BeginInit();
            this.pnlProfileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfilePic
            // 
            this.pnlProfilePic.BackColor = System.Drawing.Color.Azure;
            this.pnlProfilePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProfilePic.BackgroundImage")));
            this.pnlProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfilePic.Controls.Add(this.btnUploadProfilePic);
            this.pnlProfilePic.Controls.Add(this.lblUserType);
            this.pnlProfilePic.Controls.Add(this.picProfilePic);
            this.pnlProfilePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProfilePic.Location = new System.Drawing.Point(0, 0);
            this.pnlProfilePic.Name = "pnlProfilePic";
            this.pnlProfilePic.Size = new System.Drawing.Size(397, 744);
            this.pnlProfilePic.TabIndex = 0;
            // 
            // btnUploadProfilePic
            // 
            this.btnUploadProfilePic.BackColor = System.Drawing.Color.White;
            this.btnUploadProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUploadProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadProfilePic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUploadProfilePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUploadProfilePic.Location = new System.Drawing.Point(119, 364);
            this.btnUploadProfilePic.Name = "btnUploadProfilePic";
            this.btnUploadProfilePic.Size = new System.Drawing.Size(156, 34);
            this.btnUploadProfilePic.TabIndex = 2;
            this.btnUploadProfilePic.Text = "Upload Photo";
            this.btnUploadProfilePic.UseVisualStyleBackColor = false;
            this.btnUploadProfilePic.Click += new System.EventHandler(this.btnUploadProfilePic_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserType.Location = new System.Drawing.Point(100, 420);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(195, 45);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "Receptionist";
            // 
            // picProfilePic
            // 
            this.picProfilePic.BackColor = System.Drawing.Color.White;
            this.picProfilePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProfilePic.BackgroundImage")));
            this.picProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfilePic.Location = new System.Drawing.Point(91, 122);
            this.picProfilePic.Name = "picProfilePic";
            this.picProfilePic.Size = new System.Drawing.Size(212, 212);
            this.picProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfilePic.TabIndex = 0;
            this.picProfilePic.TabStop = false;
            // 
            // pnlProfileInfo
            // 
            this.pnlProfileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlProfileInfo.Controls.Add(this.txtDob);
            this.pnlProfileInfo.Controls.Add(this.lblDob);
            this.pnlProfileInfo.Controls.Add(this.llbChangePw);
            this.pnlProfileInfo.Controls.Add(this.txtUserId);
            this.pnlProfileInfo.Controls.Add(this.rdoFemale);
            this.pnlProfileInfo.Controls.Add(this.rdoMale);
            this.pnlProfileInfo.Controls.Add(this.txtContact);
            this.pnlProfileInfo.Controls.Add(this.lblGender);
            this.pnlProfileInfo.Controls.Add(this.lblContactNumber);
            this.pnlProfileInfo.Controls.Add(this.txtUsername);
            this.pnlProfileInfo.Controls.Add(this.txtEmail);
            this.pnlProfileInfo.Controls.Add(this.txtName);
            this.pnlProfileInfo.Controls.Add(this.btnProfileSaveChange);
            this.pnlProfileInfo.Controls.Add(this.btnProfileEdit);
            this.pnlProfileInfo.Controls.Add(this.lblEmail);
            this.pnlProfileInfo.Controls.Add(this.lblName);
            this.pnlProfileInfo.Controls.Add(this.lblUsername);
            this.pnlProfileInfo.Controls.Add(this.lblUserId);
            this.pnlProfileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfileInfo.Location = new System.Drawing.Point(397, 0);
            this.pnlProfileInfo.Name = "pnlProfileInfo";
            this.pnlProfileInfo.Size = new System.Drawing.Size(961, 744);
            this.pnlProfileInfo.TabIndex = 1;
            // 
            // txtDob
            // 
            this.txtDob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDob.Location = new System.Drawing.Point(253, 345);
            this.txtDob.Name = "txtDob";
            this.txtDob.ReadOnly = true;
            this.txtDob.Size = new System.Drawing.Size(274, 39);
            this.txtDob.TabIndex = 49;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.BackColor = System.Drawing.Color.Transparent;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDob.Location = new System.Drawing.Point(94, 348);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(121, 32);
            this.lblDob.TabIndex = 48;
            this.lblDob.Text = "Birth Date";
            // 
            // llbChangePw
            // 
            this.llbChangePw.AutoSize = true;
            this.llbChangePw.BackColor = System.Drawing.Color.Transparent;
            this.llbChangePw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbChangePw.Location = new System.Drawing.Point(94, 631);
            this.llbChangePw.Name = "llbChangePw";
            this.llbChangePw.Size = new System.Drawing.Size(200, 32);
            this.llbChangePw.TabIndex = 47;
            this.llbChangePw.TabStop = true;
            this.llbChangePw.Text = "Change Password";
            this.llbChangePw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbChangePw_LinkClicked);
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserId.Location = new System.Drawing.Point(162, 75);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(241, 39);
            this.txtUserId.TabIndex = 44;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoFemale.Location = new System.Drawing.Point(354, 262);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(116, 36);
            this.rdoFemale.TabIndex = 43;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoMale.Location = new System.Drawing.Point(228, 262);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(92, 36);
            this.rdoMale.TabIndex = 42;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContact.Location = new System.Drawing.Point(253, 531);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(274, 39);
            this.txtContact.TabIndex = 41;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(94, 262);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(92, 32);
            this.lblGender.TabIndex = 40;
            this.lblGender.Text = "Gender";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactNumber.Location = new System.Drawing.Point(94, 537);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(129, 32);
            this.lblContactNumber.TabIndex = 39;
            this.lblContactNumber.Text = "Contact.no";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(253, 169);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(274, 39);
            this.txtUsername.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(253, 438);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(274, 39);
            this.txtEmail.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(612, 75);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(241, 39);
            this.txtName.TabIndex = 35;
            // 
            // btnProfileSaveChange
            // 
            this.btnProfileSaveChange.Enabled = false;
            this.btnProfileSaveChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfileSaveChange.Location = new System.Drawing.Point(735, 673);
            this.btnProfileSaveChange.Name = "btnProfileSaveChange";
            this.btnProfileSaveChange.Size = new System.Drawing.Size(163, 46);
            this.btnProfileSaveChange.TabIndex = 34;
            this.btnProfileSaveChange.Text = "Save Change";
            this.btnProfileSaveChange.UseVisualStyleBackColor = true;
            this.btnProfileSaveChange.Click += new System.EventHandler(this.btnProfileSaveChange_Click_1);
            // 
            // btnProfileEdit
            // 
            this.btnProfileEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfileEdit.Location = new System.Drawing.Point(555, 673);
            this.btnProfileEdit.Name = "btnProfileEdit";
            this.btnProfileEdit.Size = new System.Drawing.Size(112, 46);
            this.btnProfileEdit.TabIndex = 33;
            this.btnProfileEdit.Text = "Edit";
            this.btnProfileEdit.UseVisualStyleBackColor = true;
            this.btnProfileEdit.Click += new System.EventHandler(this.btnProfileEdit_Click_1);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(94, 441);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 32);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(490, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 32);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(94, 172);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 32);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserId.Location = new System.Drawing.Point(94, 75);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(37, 32);
            this.lblUserId.TabIndex = 28;
            this.lblUserId.Text = "ID";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 744);
            this.Controls.Add(this.pnlProfileInfo);
            this.Controls.Add(this.pnlProfilePic);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.pnlProfilePic.ResumeLayout(false);
            this.pnlProfilePic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).EndInit();
            this.pnlProfileInfo.ResumeLayout(false);
            this.pnlProfileInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlProfilePic;
        private Label lblUserType;
        private PictureBox picProfilePic;
        private Button btnUploadProfilePic;
        private Panel pnlProfileInfo;
        private LinkLabel llbChangePw;
        private TextBox txtUserId;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private TextBox txtContact;
        private Label lblGender;
        private Label lblContactNumber;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnProfileSaveChange;
        private Button btnProfileEdit;
        private Label lblEmail;
        private Label lblName;
        private Label lblUsername;
        private Label lblUserId;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtDob;
        private Label lblDob;
    }
}