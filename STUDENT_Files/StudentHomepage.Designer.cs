namespace IOOP_GROUP_22
{
    partial class StudentHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHomepage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.btnDropPage = new System.Windows.Forms.Button();
            this.btnProfilePage = new System.Windows.Forms.Button();
            this.btnHistoryPage = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(762, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnAddPage);
            this.pnlMenu.Controls.Add(this.btnDropPage);
            this.pnlMenu.Controls.Add(this.btnProfilePage);
            this.pnlMenu.Controls.Add(this.btnHistoryPage);
            this.pnlMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMenu.ForeColor = System.Drawing.Color.Black;
            this.pnlMenu.Location = new System.Drawing.Point(0, 54);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1258, 72);
            this.pnlMenu.TabIndex = 154;
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
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(1);
            this.btnHome.Size = new System.Drawing.Size(135, 72);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "   Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnAddPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPage.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPage.Image")));
            this.btnAddPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPage.Location = new System.Drawing.Point(578, 0);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(170, 72);
            this.btnAddPage.TabIndex = 1;
            this.btnAddPage.Text = "Add Request";
            this.btnAddPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // btnDropPage
            // 
            this.btnDropPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDropPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDropPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnDropPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnDropPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropPage.Image = ((System.Drawing.Image)(resources.GetObject("btnDropPage.Image")));
            this.btnDropPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDropPage.Location = new System.Drawing.Point(748, 0);
            this.btnDropPage.Name = "btnDropPage";
            this.btnDropPage.Size = new System.Drawing.Size(170, 72);
            this.btnDropPage.TabIndex = 1;
            this.btnDropPage.Text = "Drop Request";
            this.btnDropPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDropPage.UseVisualStyleBackColor = true;
            this.btnDropPage.Click += new System.EventHandler(this.btnDropPage_Click);
            // 
            // btnProfilePage
            // 
            this.btnProfilePage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProfilePage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfilePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnProfilePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnProfilePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePage.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilePage.Image")));
            this.btnProfilePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfilePage.Location = new System.Drawing.Point(918, 0);
            this.btnProfilePage.Name = "btnProfilePage";
            this.btnProfilePage.Size = new System.Drawing.Size(170, 72);
            this.btnProfilePage.TabIndex = 1;
            this.btnProfilePage.Text = "Profile";
            this.btnProfilePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfilePage.UseVisualStyleBackColor = true;
            this.btnProfilePage.Click += new System.EventHandler(this.btnProfilePage_Click);
            // 
            // btnHistoryPage
            // 
            this.btnHistoryPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistoryPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistoryPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnHistoryPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.btnHistoryPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryPage.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryPage.Image")));
            this.btnHistoryPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryPage.Location = new System.Drawing.Point(1088, 0);
            this.btnHistoryPage.Name = "btnHistoryPage";
            this.btnHistoryPage.Size = new System.Drawing.Size(170, 72);
            this.btnHistoryPage.TabIndex = 1;
            this.btnHistoryPage.Text = "Enroll\r\nHistory";
            this.btnHistoryPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistoryPage.UseVisualStyleBackColor = true;
            this.btnHistoryPage.Click += new System.EventHandler(this.btnHistoryPage_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.lblPageTitle);
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1252, 53);
            this.pnlTop.TabIndex = 153;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(12, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPageTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPageTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.ForeColor = System.Drawing.Color.Honeydew;
            this.lblPageTitle.Location = new System.Drawing.Point(543, 9);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblPageTitle.Size = new System.Drawing.Size(165, 39);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Home Page";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1188, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 23);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Time";
            // 
            // picStudent
            // 
            this.picStudent.Image = ((System.Drawing.Image)(resources.GetObject("picStudent.Image")));
            this.picStudent.Location = new System.Drawing.Point(112, 226);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(300, 300);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 155;
            this.picStudent.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(129, 542);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 42);
            this.lblUsername.TabIndex = 156;
            this.lblUsername.Text = "label1";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoll.Location = new System.Drawing.Point(129, 593);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(186, 32);
            this.lblRoll.TabIndex = 157;
            this.lblRoll.Text = "S T U D E N T";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(112, 642);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 40);
            this.btnLogout.TabIndex = 158;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StudentHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1252, 753);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentHomepage";
            this.Load += new System.EventHandler(this.StudentHomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnlMenu;
        private Button btnHome;
        private Button btnAddPage;
        private Button btnDropPage;
        private Button btnProfilePage;
        private Button btnHistoryPage;
        private Panel pnlTop;
        private Label lblDate;
        private Label lblPageTitle;
        private Label lblTime;
        private PictureBox picStudent;
        private Label lblUsername;
        private Label lblRoll;
        private Button btnLogout;
        private System.Windows.Forms.Timer timer;
    }
}