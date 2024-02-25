namespace IOOP_GROUP_22
{
    partial class EnrollHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollHistory));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnaddClear = new System.Windows.Forms.Button();
            this.btnaddCancel = new System.Windows.Forms.Button();
            this.txtaddClassid = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbAddSubject = new System.Windows.Forms.ComboBox();
            this.txtdropClassid = new System.Windows.Forms.TextBox();
            this.btndropCancel = new System.Windows.Forms.Button();
            this.btndropClear = new System.Windows.Forms.Button();
            this.cmbDropSubject = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsubTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.pnlMenu.TabIndex = 158;
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
            this.pnlTop.TabIndex = 157;
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
            this.lblPageTitle.Location = new System.Drawing.Point(562, 9);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblPageTitle.Size = new System.Drawing.Size(165, 39);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "History Page";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 320);
            this.dataGridView1.TabIndex = 159;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnaddClear
            // 
            this.btnaddClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnaddClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddClear.ForeColor = System.Drawing.Color.White;
            this.btnaddClear.Location = new System.Drawing.Point(399, 322);
            this.btnaddClear.Name = "btnaddClear";
            this.btnaddClear.Size = new System.Drawing.Size(81, 29);
            this.btnaddClear.TabIndex = 168;
            this.btnaddClear.Text = "Clear";
            this.btnaddClear.UseVisualStyleBackColor = false;
            this.btnaddClear.Click += new System.EventHandler(this.btnaddClear_Click);
            // 
            // btnaddCancel
            // 
            this.btnaddCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnaddCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddCancel.ForeColor = System.Drawing.Color.White;
            this.btnaddCancel.Location = new System.Drawing.Point(312, 322);
            this.btnaddCancel.Name = "btnaddCancel";
            this.btnaddCancel.Size = new System.Drawing.Size(81, 29);
            this.btnaddCancel.TabIndex = 167;
            this.btnaddCancel.Text = "Cancel";
            this.btnaddCancel.UseVisualStyleBackColor = false;
            this.btnaddCancel.Click += new System.EventHandler(this.btnaddCancel_Click);
            // 
            // txtaddClassid
            // 
            this.txtaddClassid.Location = new System.Drawing.Point(193, 322);
            this.txtaddClassid.Name = "txtaddClassid";
            this.txtaddClassid.ReadOnly = true;
            this.txtaddClassid.Size = new System.Drawing.Size(80, 27);
            this.txtaddClassid.TabIndex = 166;
            this.txtaddClassid.Text = "Requestid";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(684, 368);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(495, 320);
            this.dataGridView2.TabIndex = 159;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // cmbAddSubject
            // 
            this.cmbAddSubject.FormattingEnabled = true;
            this.cmbAddSubject.Items.AddRange(new object[] {
            "add",
            "Unaccepted"});
            this.cmbAddSubject.Location = new System.Drawing.Point(72, 321);
            this.cmbAddSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddSubject.Name = "cmbAddSubject";
            this.cmbAddSubject.Size = new System.Drawing.Size(116, 28);
            this.cmbAddSubject.TabIndex = 169;
            this.cmbAddSubject.SelectedIndexChanged += new System.EventHandler(this.cmbAddSubject_SelectedIndexChanged);
            // 
            // txtdropClassid
            // 
            this.txtdropClassid.Location = new System.Drawing.Point(805, 322);
            this.txtdropClassid.Name = "txtdropClassid";
            this.txtdropClassid.ReadOnly = true;
            this.txtdropClassid.Size = new System.Drawing.Size(80, 27);
            this.txtdropClassid.TabIndex = 166;
            this.txtdropClassid.Text = "Requestid";
            // 
            // btndropCancel
            // 
            this.btndropCancel.BackColor = System.Drawing.Color.Crimson;
            this.btndropCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndropCancel.ForeColor = System.Drawing.Color.White;
            this.btndropCancel.Location = new System.Drawing.Point(920, 322);
            this.btndropCancel.Name = "btndropCancel";
            this.btndropCancel.Size = new System.Drawing.Size(81, 29);
            this.btndropCancel.TabIndex = 167;
            this.btndropCancel.Text = "Cancel";
            this.btndropCancel.UseVisualStyleBackColor = false;
            this.btndropCancel.Click += new System.EventHandler(this.btndropCancel_Click);
            // 
            // btndropClear
            // 
            this.btndropClear.BackColor = System.Drawing.Color.LightBlue;
            this.btndropClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndropClear.ForeColor = System.Drawing.Color.White;
            this.btndropClear.Location = new System.Drawing.Point(1007, 322);
            this.btndropClear.Name = "btndropClear";
            this.btndropClear.Size = new System.Drawing.Size(81, 29);
            this.btndropClear.TabIndex = 168;
            this.btndropClear.Text = "Clear";
            this.btndropClear.UseVisualStyleBackColor = false;
            this.btndropClear.Click += new System.EventHandler(this.btndropClear_Click);
            // 
            // cmbDropSubject
            // 
            this.cmbDropSubject.FormattingEnabled = true;
            this.cmbDropSubject.Items.AddRange(new object[] {
            "drop",
            "Unaccepted"});
            this.cmbDropSubject.Location = new System.Drawing.Point(684, 321);
            this.cmbDropSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDropSubject.Name = "cmbDropSubject";
            this.cmbDropSubject.Size = new System.Drawing.Size(116, 28);
            this.cmbDropSubject.TabIndex = 169;
            this.cmbDropSubject.SelectedIndexChanged += new System.EventHandler(this.cmbDropSubject_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(188, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 6);
            this.panel1.TabIndex = 171;
            // 
            // lblsubTitle
            // 
            this.lblsubTitle.AutoSize = true;
            this.lblsubTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblsubTitle.Location = new System.Drawing.Point(544, 180);
            this.lblsubTitle.Name = "lblsubTitle";
            this.lblsubTitle.Size = new System.Drawing.Size(193, 28);
            this.lblsubTitle.TabIndex = 170;
            this.lblsubTitle.Text = "ENROLL HISTORY";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EnrollHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1252, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsubTitle);
            this.Controls.Add(this.cmbDropSubject);
            this.Controls.Add(this.cmbAddSubject);
            this.Controls.Add(this.btndropClear);
            this.Controls.Add(this.btndropCancel);
            this.Controls.Add(this.btnaddClear);
            this.Controls.Add(this.txtdropClassid);
            this.Controls.Add(this.btnaddCancel);
            this.Controls.Add(this.txtaddClassid);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Name = "EnrollHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrollHistory";
            this.Load += new System.EventHandler(this.EnrollHistory_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnaddClear;
        private Button btnaddCancel;
        private TextBox txtaddClassid;
        private DataGridView dataGridView2;
        private ComboBox cmbAddSubject;
        private TextBox txtdropClassid;
        private Button btndropCancel;
        private Button btndropClear;
        private ComboBox cmbDropSubject;
        private Panel panel1;
        private Label lblsubTitle;
        private System.Windows.Forms.Timer timer1;
    }
}