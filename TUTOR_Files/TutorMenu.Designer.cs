namespace IOOP_GROUP_22
{
    partial class TutorMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorMenu));
            this.picAcc = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProfilepage = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTutormenu = new System.Windows.Forms.Button();
            this.btnChangeclassinformation = new System.Windows.Forms.Button();
            this.btnShowclassschedule = new System.Windows.Forms.Button();
            this.btnStudentlist = new System.Windows.Forms.Button();
            this.picTutor = new System.Windows.Forms.PictureBox();
            this.lblidtutor = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.llbEditprofile = new System.Windows.Forms.LinkLabel();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.pnlSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAcc
            // 
            this.picAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAcc.Image = ((System.Drawing.Image)(resources.GetObject("picAcc.Image")));
            this.picAcc.Location = new System.Drawing.Point(0, 0);
            this.picAcc.Name = "picAcc";
            this.picAcc.Size = new System.Drawing.Size(112, 72);
            this.picAcc.TabIndex = 0;
            this.picAcc.UseVisualStyleBackColor = true;
            this.picAcc.Click += new System.EventHandler(this.picAcc_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(110, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(135, 72);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "     Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.lblProfilepage);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1258, 53);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1127, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 23);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(27, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblProfilepage
            // 
            this.lblProfilepage.AutoSize = true;
            this.lblProfilepage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfilepage.ForeColor = System.Drawing.Color.Honeydew;
            this.lblProfilepage.Location = new System.Drawing.Point(517, 15);
            this.lblProfilepage.Name = "lblProfilepage";
            this.lblProfilepage.Size = new System.Drawing.Size(219, 24);
            this.lblProfilepage.TabIndex = 5;
            this.lblProfilepage.Text = "Welcome Back, Tutor!";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMenu.Controls.Add(this.pnlDropdown);
            this.pnlMenu.Controls.Add(this.btnTutormenu);
            this.pnlMenu.Controls.Add(this.btnChangeclassinformation);
            this.pnlMenu.Controls.Add(this.btnShowclassschedule);
            this.pnlMenu.Controls.Add(this.btnStudentlist);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Location = new System.Drawing.Point(0, 53);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1258, 72);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Controls.Add(this.button2);
            this.pnlDropdown.Controls.Add(this.button1);
            this.pnlDropdown.Controls.Add(this.picAcc);
            this.pnlDropdown.Location = new System.Drawing.Point(3, 0);
            this.pnlDropdown.MaximumSize = new System.Drawing.Size(112, 160);
            this.pnlDropdown.MinimumSize = new System.Drawing.Size(112, 73);
            this.pnlDropdown.Name = "pnlDropdown";
            this.pnlDropdown.Size = new System.Drawing.Size(112, 73);
            this.pnlDropdown.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTutormenu
            // 
            this.btnTutormenu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTutormenu.Image = ((System.Drawing.Image)(resources.GetObject("btnTutormenu.Image")));
            this.btnTutormenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutormenu.Location = new System.Drawing.Point(584, 0);
            this.btnTutormenu.Name = "btnTutormenu";
            this.btnTutormenu.Size = new System.Drawing.Size(170, 72);
            this.btnTutormenu.TabIndex = 7;
            this.btnTutormenu.Text = "       Tutor Menu";
            this.btnTutormenu.UseVisualStyleBackColor = true;
            // 
            // btnChangeclassinformation
            // 
            this.btnChangeclassinformation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeclassinformation.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeclassinformation.Image")));
            this.btnChangeclassinformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeclassinformation.Location = new System.Drawing.Point(752, 0);
            this.btnChangeclassinformation.Name = "btnChangeclassinformation";
            this.btnChangeclassinformation.Size = new System.Drawing.Size(170, 72);
            this.btnChangeclassinformation.TabIndex = 8;
            this.btnChangeclassinformation.Text = "Change Class Information";
            this.btnChangeclassinformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeclassinformation.UseVisualStyleBackColor = true;
            this.btnChangeclassinformation.Click += new System.EventHandler(this.btnChangeclassinformation_Click);
            // 
            // btnShowclassschedule
            // 
            this.btnShowclassschedule.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowclassschedule.Image = ((System.Drawing.Image)(resources.GetObject("btnShowclassschedule.Image")));
            this.btnShowclassschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowclassschedule.Location = new System.Drawing.Point(920, 0);
            this.btnShowclassschedule.Name = "btnShowclassschedule";
            this.btnShowclassschedule.Size = new System.Drawing.Size(170, 72);
            this.btnShowclassschedule.TabIndex = 9;
            this.btnShowclassschedule.Text = "     Show Class Schedule";
            this.btnShowclassschedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowclassschedule.UseVisualStyleBackColor = true;
            this.btnShowclassschedule.Click += new System.EventHandler(this.btnShowclassschedule_Click);
            // 
            // btnStudentlist
            // 
            this.btnStudentlist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudentlist.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentlist.Image")));
            this.btnStudentlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentlist.Location = new System.Drawing.Point(1088, 0);
            this.btnStudentlist.Name = "btnStudentlist";
            this.btnStudentlist.Size = new System.Drawing.Size(170, 72);
            this.btnStudentlist.TabIndex = 10;
            this.btnStudentlist.Text = "      Student List";
            this.btnStudentlist.UseVisualStyleBackColor = true;
            this.btnStudentlist.Click += new System.EventHandler(this.btnStudentlist_Click);
            // 
            // picTutor
            // 
            this.picTutor.BackColor = System.Drawing.Color.Transparent;
            this.picTutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTutor.BackgroundImage")));
            this.picTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTutor.Image = ((System.Drawing.Image)(resources.GetObject("picTutor.Image")));
            this.picTutor.Location = new System.Drawing.Point(175, 143);
            this.picTutor.Name = "picTutor";
            this.picTutor.Size = new System.Drawing.Size(300, 300);
            this.picTutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTutor.TabIndex = 4;
            this.picTutor.TabStop = false;
            // 
            // lblidtutor
            // 
            this.lblidtutor.AutoSize = true;
            this.lblidtutor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblidtutor.Location = new System.Drawing.Point(246, 468);
            this.lblidtutor.Name = "lblidtutor";
            this.lblidtutor.Size = new System.Drawing.Size(176, 35);
            this.lblidtutor.TabIndex = 5;
            this.lblidtutor.Text = "TUTOR 001";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblemail.Location = new System.Drawing.Point(203, 542);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(254, 27);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "TP068571@gmail.com";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.BlueViolet;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnShow.Location = new System.Drawing.Point(163, 599);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(332, 59);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show Class Schedule";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.button7_Click);
            // 
            // llbEditprofile
            // 
            this.llbEditprofile.AutoSize = true;
            this.llbEditprofile.LinkColor = System.Drawing.Color.Indigo;
            this.llbEditprofile.Location = new System.Drawing.Point(288, 676);
            this.llbEditprofile.Name = "llbEditprofile";
            this.llbEditprofile.Size = new System.Drawing.Size(82, 20);
            this.llbEditprofile.TabIndex = 8;
            this.llbEditprofile.TabStop = true;
            this.llbEditprofile.Text = "Edit Profile";
            this.llbEditprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEditprofile_LinkClicked);
            // 
            // picBackground
            // 
            this.picBackground.BackColor = System.Drawing.Color.Transparent;
            this.picBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackground.BackgroundImage")));
            this.picBackground.Location = new System.Drawing.Point(483, 233);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(775, 555);
            this.picBackground.TabIndex = 9;
            this.picBackground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnProfile);
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 127);
            this.pnlSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(112, 82);
            this.pnlSubmenu.TabIndex = 47;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 40);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 40);
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
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(112, 40);
            this.btnProfile.TabIndex = 45;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // TutorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.pnlSubmenu);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.llbEditprofile);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblidtutor);
            this.Controls.Add(this.picTutor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TutorMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor Menu";
            this.Load += new System.EventHandler(this.TutorMenu_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.pnlSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button picAcc;
        private Button btnHome;
        private Panel pnlTop;
        private Panel pnlMenu;
        private Label lblDate;
        private Label lblProfilepage;
        private Label lblTime;
        private Button btnTutormenu;
        private Button btnChangeclassinformation;
        private Button btnShowclassschedule;
        private Button btnStudentlist;
        private PictureBox picTutor;
        private Label lblidtutor;
        private Label lblemail;
        private Button btnShow;
        private LinkLabel llbEditprofile;
        private PictureBox picBackground;
        private Panel pnlDropdown;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlSubmenu;
        private Button btnLogout;
        private Button btnProfile;
    }
}