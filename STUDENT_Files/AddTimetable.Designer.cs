namespace IOOP_GROUP_22
{
    partial class AddTimetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimetable));
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
            this.dgvFirst = new System.Windows.Forms.DataGridView();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtaddClassid = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblsubTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
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
            this.btnAddPage.Text = "   Add Request";
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
            this.btnDropPage.Text = "      Drop Request";
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
            this.btnHistoryPage.Text = "Enroll\r\n         History";
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
            this.lblDate.Location = new System.Drawing.Point(12, 12);
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
            this.lblPageTitle.Location = new System.Drawing.Point(570, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblPageTitle.Size = new System.Drawing.Size(165, 39);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Add Page";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(1188, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 23);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Time";
            // 
            // dgvFirst
            // 
            this.dgvFirst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFirst.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvFirst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirst.Location = new System.Drawing.Point(49, 274);
            this.dgvFirst.Name = "dgvFirst";
            this.dgvFirst.ReadOnly = true;
            this.dgvFirst.RowHeadersWidth = 51;
            this.dgvFirst.RowTemplate.Height = 29;
            this.dgvFirst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFirst.Size = new System.Drawing.Size(1158, 114);
            this.dgvFirst.TabIndex = 155;
            // 
            // dgvAll
            // 
            this.dgvAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAll.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Location = new System.Drawing.Point(49, 484);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersWidth = 51;
            this.dgvAll.RowTemplate.Height = 29;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAll.Size = new System.Drawing.Size(1158, 225);
            this.dgvAll.TabIndex = 156;
            this.dgvAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAll_CellClick);
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(44, 438);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(116, 26);
            this.cmbSubject.TabIndex = 157;
            this.cmbSubject.Text = "Subject";
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // txtaddClassid
            // 
            this.txtaddClassid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtaddClassid.ForeColor = System.Drawing.Color.Black;
            this.txtaddClassid.Location = new System.Drawing.Point(166, 439);
            this.txtaddClassid.Name = "txtaddClassid";
            this.txtaddClassid.ReadOnly = true;
            this.txtaddClassid.Size = new System.Drawing.Size(71, 25);
            this.txtaddClassid.TabIndex = 158;
            this.txtaddClassid.Text = "Class ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(260, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 29);
            this.btnAdd.TabIndex = 159;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(347, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 29);
            this.btnClear.TabIndex = 160;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblsubTitle
            // 
            this.lblsubTitle.AutoSize = true;
            this.lblsubTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsubTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblsubTitle.Location = new System.Drawing.Point(557, 180);
            this.lblsubTitle.Name = "lblsubTitle";
            this.lblsubTitle.Size = new System.Drawing.Size(132, 28);
            this.lblsubTitle.TabIndex = 161;
            this.lblsubTitle.Text = "ADD CLASS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(188, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 6);
            this.panel1.TabIndex = 162;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AddTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1252, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsubTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtaddClassid);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.dgvAll);
            this.Controls.Add(this.dgvFirst);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.Name = "AddTimetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTimetable";
            this.Load += new System.EventHandler(this.AddTimetable_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
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
        private DataGridView dgvFirst;
        private DataGridView dgvAll;
        private ComboBox cmbSubject;
        private TextBox txtaddClassid;
        private Button btnAdd;
        private Button btnClear;
        private Label lblsubTitle;
        private Panel panel1;
        private System.Windows.Forms.Timer timer;
    }
}