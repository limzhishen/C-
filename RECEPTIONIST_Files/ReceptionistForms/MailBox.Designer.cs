namespace IOOP_GROUP_22.ReceptionistForms
{
    partial class MailBox
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
            this.dgvRequestDrop = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStudIdAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassCurrent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassAfter = new System.Windows.Forms.TextBox();
            this.btnAcceptChange = new System.Windows.Forms.Button();
            this.txtStudIdDrop = new System.Windows.Forms.TextBox();
            this.lblStudId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStudIdCheck = new System.Windows.Forms.TextBox();
            this.btnCheckPaid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRequestAdd = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestDrop)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequestDrop
            // 
            this.dgvRequestDrop.AllowUserToDeleteRows = false;
            this.dgvRequestDrop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestDrop.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRequestDrop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestDrop.Location = new System.Drawing.Point(12, 207);
            this.dgvRequestDrop.Name = "dgvRequestDrop";
            this.dgvRequestDrop.ReadOnly = true;
            this.dgvRequestDrop.RowHeadersWidth = 62;
            this.dgvRequestDrop.RowTemplate.Height = 33;
            this.dgvRequestDrop.Size = new System.Drawing.Size(651, 265);
            this.dgvRequestDrop.TabIndex = 0;
            this.dgvRequestDrop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestDrop_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtStudIdAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtClassCurrent);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtClassAfter);
            this.panel1.Controls.Add(this.btnAcceptChange);
            this.panel1.Controls.Add(this.txtStudIdDrop);
            this.panel1.Controls.Add(this.lblStudId);
            this.panel1.Location = new System.Drawing.Point(12, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 258);
            this.panel1.TabIndex = 1;
            // 
            // txtStudIdAdd
            // 
            this.txtStudIdAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudIdAdd.Location = new System.Drawing.Point(458, 104);
            this.txtStudIdAdd.Name = "txtStudIdAdd";
            this.txtStudIdAdd.ReadOnly = true;
            this.txtStudIdAdd.Size = new System.Drawing.Size(177, 39);
            this.txtStudIdAdd.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(325, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Student ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(689, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 46);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(689, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Class";
            // 
            // txtClassCurrent
            // 
            this.txtClassCurrent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassCurrent.Location = new System.Drawing.Point(849, 38);
            this.txtClassCurrent.Name = "txtClassCurrent";
            this.txtClassCurrent.ReadOnly = true;
            this.txtClassCurrent.Size = new System.Drawing.Size(177, 39);
            this.txtClassCurrent.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(689, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "New Class";
            // 
            // txtClassAfter
            // 
            this.txtClassAfter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClassAfter.Location = new System.Drawing.Point(849, 104);
            this.txtClassAfter.Name = "txtClassAfter";
            this.txtClassAfter.ReadOnly = true;
            this.txtClassAfter.Size = new System.Drawing.Size(177, 39);
            this.txtClassAfter.TabIndex = 15;
            // 
            // btnAcceptChange
            // 
            this.btnAcceptChange.Enabled = false;
            this.btnAcceptChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAcceptChange.Location = new System.Drawing.Point(475, 194);
            this.btnAcceptChange.Name = "btnAcceptChange";
            this.btnAcceptChange.Size = new System.Drawing.Size(186, 46);
            this.btnAcceptChange.TabIndex = 14;
            this.btnAcceptChange.Text = "Accept Change";
            this.btnAcceptChange.UseVisualStyleBackColor = true;
            this.btnAcceptChange.Click += new System.EventHandler(this.btnAcceptChange_Click);
            // 
            // txtStudIdDrop
            // 
            this.txtStudIdDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudIdDrop.Location = new System.Drawing.Point(458, 38);
            this.txtStudIdDrop.Name = "txtStudIdDrop";
            this.txtStudIdDrop.ReadOnly = true;
            this.txtStudIdDrop.Size = new System.Drawing.Size(177, 39);
            this.txtStudIdDrop.TabIndex = 11;
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudId.Location = new System.Drawing.Point(325, 41);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(127, 32);
            this.lblStudId.TabIndex = 8;
            this.lblStudId.Text = "Student ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txtStudIdCheck);
            this.panel2.Controls.Add(this.btnCheckPaid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1351, 97);
            this.panel2.TabIndex = 2;
            // 
            // txtStudIdCheck
            // 
            this.txtStudIdCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudIdCheck.Location = new System.Drawing.Point(555, 29);
            this.txtStudIdCheck.Name = "txtStudIdCheck";
            this.txtStudIdCheck.Size = new System.Drawing.Size(177, 39);
            this.txtStudIdCheck.TabIndex = 18;
            // 
            // btnCheckPaid
            // 
            this.btnCheckPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckPaid.Location = new System.Drawing.Point(767, 25);
            this.btnCheckPaid.Name = "btnCheckPaid";
            this.btnCheckPaid.Size = new System.Drawing.Size(166, 46);
            this.btnCheckPaid.TabIndex = 5;
            this.btnCheckPaid.Text = "Check Status";
            this.btnCheckPaid.UseVisualStyleBackColor = true;
            this.btnCheckPaid.Click += new System.EventHandler(this.btnCheckPaid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(1099, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Payment Status";
            // 
            // dgvRequestAdd
            // 
            this.dgvRequestAdd.AllowUserToDeleteRows = false;
            this.dgvRequestAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestAdd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRequestAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestAdd.Location = new System.Drawing.Point(691, 207);
            this.dgvRequestAdd.Name = "dgvRequestAdd";
            this.dgvRequestAdd.ReadOnly = true;
            this.dgvRequestAdd.RowHeadersWidth = 62;
            this.dgvRequestAdd.RowTemplate.Height = 33;
            this.dgvRequestAdd.Size = new System.Drawing.Size(672, 265);
            this.dgvRequestAdd.TabIndex = 3;
            this.dgvRequestAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestAdd_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(223, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Drop Class Table";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(929, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "Add Class Table";
            // 
            // MailBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 764);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRequestAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRequestDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MailBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailBox";
            this.Load += new System.EventHandler(this.MailBox_Load);
            this.Shown += new System.EventHandler(this.MailBox_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestDrop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvRequestDrop;
        private Panel panel1;
        private Button btnAcceptChange;
        private TextBox txtStudIdDrop;
        private Label lblStudId;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnCheckPaid;
        private Label label6;
        private TextBox txtClassAfter;
        private TextBox txtStudIdCheck;
        private Label label3;
        private TextBox txtClassCurrent;
        private Button btnCancel;
        private DataGridView dgvRequestAdd;
        private Label label5;
        private Label label7;
        private TextBox txtStudIdAdd;
        private Label label8;
    }
}