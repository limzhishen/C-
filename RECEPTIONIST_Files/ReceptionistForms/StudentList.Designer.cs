namespace IOOP_GROUP_22.ReceptionistForms
{
    partial class StudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentList));
            this.dgvStudList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelStudId = new System.Windows.Forms.TextBox();
            this.txtSrchStudId = new System.Windows.Forms.TextBox();
            this.btnSrchStud = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudList
            // 
            this.dgvStudList.AllowUserToDeleteRows = false;
            this.dgvStudList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStudList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudList.Location = new System.Drawing.Point(12, 374);
            this.dgvStudList.Name = "dgvStudList";
            this.dgvStudList.ReadOnly = true;
            this.dgvStudList.RowHeadersWidth = 62;
            this.dgvStudList.RowTemplate.Height = 33;
            this.dgvStudList.Size = new System.Drawing.Size(1334, 358);
            this.dgvStudList.TabIndex = 0;
            this.dgvStudList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudList_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(758, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // txtDelStudId
            // 
            this.txtDelStudId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDelStudId.Location = new System.Drawing.Point(709, 157);
            this.txtDelStudId.Name = "txtDelStudId";
            this.txtDelStudId.Size = new System.Drawing.Size(268, 50);
            this.txtDelStudId.TabIndex = 3;
            // 
            // txtSrchStudId
            // 
            this.txtSrchStudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSrchStudId.Location = new System.Drawing.Point(855, 326);
            this.txtSrchStudId.Name = "txtSrchStudId";
            this.txtSrchStudId.Size = new System.Drawing.Size(150, 39);
            this.txtSrchStudId.TabIndex = 4;
            // 
            // btnSrchStud
            // 
            this.btnSrchStud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchStud.Location = new System.Drawing.Point(1030, 322);
            this.btnSrchStud.Name = "btnSrchStud";
            this.btnSrchStud.Size = new System.Drawing.Size(183, 46);
            this.btnSrchStud.TabIndex = 5;
            this.btnSrchStud.Text = "Search Student";
            this.btnSrchStud.UseVisualStyleBackColor = true;
            this.btnSrchStud.Click += new System.EventHandler(this.btnSrchStud_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelStud.Location = new System.Drawing.Point(788, 233);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(112, 46);
            this.btnDelStud.TabIndex = 6;
            this.btnDelStud.Text = "Delete";
            this.btnDelStud.UseVisualStyleBackColor = true;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAll.Location = new System.Drawing.Point(1222, 322);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(124, 46);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1358, 744);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelStud);
            this.Controls.Add(this.btnSrchStud);
            this.Controls.Add(this.txtSrchStudId);
            this.Controls.Add(this.txtDelStudId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvStudList);
            this.Name = "StudentList";
            this.Text = "Student_List";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvStudList;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtDelStudId;
        private TextBox txtSrchStudId;
        private Button btnSrchStud;
        private Button btnDelStud;
        private Button btnShowAll;
    }
}