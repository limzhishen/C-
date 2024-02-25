namespace IOOP_GROUP_22
{
    partial class DropTimetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropTimetable));
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
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.btnDrop = new System.Windows.Forms.Button();
            this.txtdropClassid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsubTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
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
            this.pnlMenu.Location = new System.Drawing.Point(0, 53);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1258, 72);
            this.pnlMenu.TabIndex = 156;
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
            this.pnlTop.TabIndex = 155;
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
            this.lblPageTitle.Location = new System.Drawing.Point(545, 9);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblPageTitle.Size = new System.Drawing.Size(165, 39);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Drop Page";
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
            // dgvTimetable
            // 
            this.dgvTimetable.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(112, 331);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersWidth = 51;
            this.dgvTimetable.RowTemplate.Height = 29;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimetable.Size = new System.Drawing.Size(1022, 188);
            this.dgvTimetable.TabIndex = 157;
            this.dgvTimetable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetable_CellClick);
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.Crimson;
            this.btnDrop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDrop.ForeColor = System.Drawing.Color.White;
            this.btnDrop.Location = new System.Drawing.Point(206, 539);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(81, 29);
            this.btnDrop.TabIndex = 163;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // txtdropClassid
            // 
            this.txtdropClassid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdropClassid.Location = new System.Drawing.Point(110, 539);
            this.txtdropClassid.Name = "txtdropClassid";
            this.txtdropClassid.ReadOnly = true;
            this.txtdropClassid.Size = new System.Drawing.Size(71, 25);
            this.txtdropClassid.TabIndex = 162;
            this.txtdropClassid.Text = "Class ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(188, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 6);
            this.panel1.TabIndex = 165;
            // 
            // lblsubTitle
            // 
            this.lblsubTitle.AutoSize = true;
            this.lblsubTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblsubTitle.Location = new System.Drawing.Point(545, 180);
            this.lblsubTitle.Name = "lblsubTitle";
            this.lblsubTitle.Size = new System.Drawing.Size(168, 28);
            this.lblsubTitle.TabIndex = 164;
            this.lblsubTitle.Text = "DELETE CLASS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DropTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1252, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsubTitle);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.txtdropClassid);
            this.Controls.Add(this.dgvTimetable);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Name = "DropTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DropTimetable";
            this.Load += new System.EventHandler(this.DropTimetable_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DataGridView dgvTimetable;
        private Button btnDrop;
        private TextBox txtdropClassid;
        private Panel panel1;
        private Label lblsubTitle;
        private System.Windows.Forms.Timer timer1;
    }
}