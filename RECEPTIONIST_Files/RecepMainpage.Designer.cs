namespace IOOP_GROUP_22
{
    partial class RecepMainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepMainpage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBanner = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStudentEnroll = new System.Windows.Forms.Button();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnPaymentHist = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnlHomePage = new System.Windows.Forms.Panel();
            this.lblRcptId = new System.Windows.Forms.Label();
            this.btnMailBox = new System.Windows.Forms.Button();
            this.btnLogOut1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblBanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(36, 8);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(989, 7);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 28);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            // 
            // lblBanner
            // 
            this.lblBanner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBanner.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBanner.Location = new System.Drawing.Point(404, 7);
            this.lblBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(280, 26);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Welcome back, receptionist!";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Azure;
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnStudentEnroll);
            this.pnlMenu.Controls.Add(this.btnStudentList);
            this.pnlMenu.Controls.Add(this.btnMakePayment);
            this.pnlMenu.Controls.Add(this.btnPaymentHist);
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 42);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1086, 72);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(90, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 72);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStudentEnroll
            // 
            this.btnStudentEnroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStudentEnroll.ForeColor = System.Drawing.Color.Black;
            this.btnStudentEnroll.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentEnroll.Image")));
            this.btnStudentEnroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentEnroll.Location = new System.Drawing.Point(558, 0);
            this.btnStudentEnroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentEnroll.Name = "btnStudentEnroll";
            this.btnStudentEnroll.Size = new System.Drawing.Size(132, 72);
            this.btnStudentEnroll.TabIndex = 3;
            this.btnStudentEnroll.Text = "Student Enrollment";
            this.btnStudentEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentEnroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentEnroll.UseVisualStyleBackColor = true;
            this.btnStudentEnroll.Click += new System.EventHandler(this.btnStudentEnroll_Click);
            // 
            // btnStudentList
            // 
            this.btnStudentList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStudentList.ForeColor = System.Drawing.Color.Black;
            this.btnStudentList.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentList.Image")));
            this.btnStudentList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentList.Location = new System.Drawing.Point(690, 0);
            this.btnStudentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(132, 72);
            this.btnStudentList.TabIndex = 2;
            this.btnStudentList.Text = "Student List";
            this.btnStudentList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMakePayment.ForeColor = System.Drawing.Color.Black;
            this.btnMakePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnMakePayment.Image")));
            this.btnMakePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakePayment.Location = new System.Drawing.Point(822, 0);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(132, 72);
            this.btnMakePayment.TabIndex = 1;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnPaymentHist
            // 
            this.btnPaymentHist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPaymentHist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaymentHist.ForeColor = System.Drawing.Color.Black;
            this.btnPaymentHist.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentHist.Image")));
            this.btnPaymentHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentHist.Location = new System.Drawing.Point(954, 0);
            this.btnPaymentHist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentHist.Name = "btnPaymentHist";
            this.btnPaymentHist.Size = new System.Drawing.Size(132, 72);
            this.btnPaymentHist.TabIndex = 0;
            this.btnPaymentHist.Text = "Payment History";
            this.btnPaymentHist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaymentHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentHist.UseVisualStyleBackColor = true;
            this.btnPaymentHist.Click += new System.EventHandler(this.btnPaymentHist_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(90, 72);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlHomePage
            // 
            this.pnlHomePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomePage.BackgroundImage")));
            this.pnlHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomePage.Controls.Add(this.lblRcptId);
            this.pnlHomePage.Controls.Add(this.btnMailBox);
            this.pnlHomePage.Controls.Add(this.btnLogOut1);
            this.pnlHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomePage.Location = new System.Drawing.Point(0, 114);
            this.pnlHomePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHomePage.Name = "pnlHomePage";
            this.pnlHomePage.Size = new System.Drawing.Size(1086, 596);
            this.pnlHomePage.TabIndex = 2;
            // 
            // lblRcptId
            // 
            this.lblRcptId.AutoSize = true;
            this.lblRcptId.BackColor = System.Drawing.Color.LightCyan;
            this.lblRcptId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRcptId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRcptId.Location = new System.Drawing.Point(22, 20);
            this.lblRcptId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRcptId.Name = "lblRcptId";
            this.lblRcptId.Size = new System.Drawing.Size(92, 39);
            this.lblRcptId.TabIndex = 3;
            this.lblRcptId.Text = "label1";
            // 
            // btnMailBox
            // 
            this.btnMailBox.BackColor = System.Drawing.Color.Transparent;
            this.btnMailBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMailBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMailBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMailBox.Image = ((System.Drawing.Image)(resources.GetObject("btnMailBox.Image")));
            this.btnMailBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailBox.Location = new System.Drawing.Point(966, 0);
            this.btnMailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMailBox.Name = "btnMailBox";
            this.btnMailBox.Size = new System.Drawing.Size(48, 56);
            this.btnMailBox.TabIndex = 2;
            this.btnMailBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMailBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMailBox.UseVisualStyleBackColor = false;
            this.btnMailBox.Click += new System.EventHandler(this.btnMailBox_Click);
            // 
            // btnLogOut1
            // 
            this.btnLogOut1.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut1.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut1.Image")));
            this.btnLogOut1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut1.Location = new System.Drawing.Point(1038, 0);
            this.btnLogOut1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(48, 56);
            this.btnLogOut1.TabIndex = 1;
            this.btnLogOut1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut1.UseVisualStyleBackColor = false;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RecepMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 710);
            this.Controls.Add(this.pnlHomePage);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "RecepMainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainpage";
            this.Load += new System.EventHandler(this.Mainpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlHomePage.ResumeLayout(false);
            this.pnlHomePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlMenu;
        private Button btnProfile;
        private Button btnStudentEnroll;
        private Button btnStudentList;
        private Button btnMakePayment;
        private Button btnPaymentHist;
        private Button btnHome;
        private Label lblBanner;
        private Panel pnlHomePage;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Button btnLogOut1;
        private Button btnMailBox;
        private Label lblRcptId;
        private Label lblDate;
    }
}