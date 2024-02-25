namespace IOOP_GROUP_22
{
    partial class TutorchangeForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cklSubject = new System.Windows.Forms.CheckedListBox();
            this.grplevel = new System.Windows.Forms.GroupBox();
            this.chkForm5 = new System.Windows.Forms.CheckBox();
            this.chkForm4 = new System.Windows.Forms.CheckBox();
            this.chkForm3 = new System.Windows.Forms.CheckBox();
            this.chkForm2 = new System.Windows.Forms.CheckBox();
            this.chkForm1 = new System.Windows.Forms.CheckBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.grplevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnReset.Location = new System.Drawing.Point(373, 503);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 51);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(181, 503);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(146, 51);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cklSubject
            // 
            this.cklSubject.FormattingEnabled = true;
            this.cklSubject.Location = new System.Drawing.Point(239, 188);
            this.cklSubject.Name = "cklSubject";
            this.cklSubject.Size = new System.Drawing.Size(210, 256);
            this.cklSubject.TabIndex = 22;
            // 
            // grplevel
            // 
            this.grplevel.Controls.Add(this.chkForm5);
            this.grplevel.Controls.Add(this.chkForm4);
            this.grplevel.Controls.Add(this.chkForm3);
            this.grplevel.Controls.Add(this.chkForm2);
            this.grplevel.Controls.Add(this.chkForm1);
            this.grplevel.Location = new System.Drawing.Point(154, 22);
            this.grplevel.Name = "grplevel";
            this.grplevel.Size = new System.Drawing.Size(508, 147);
            this.grplevel.TabIndex = 21;
            this.grplevel.TabStop = false;
            this.grplevel.Text = "Level";
            // 
            // chkForm5
            // 
            this.chkForm5.AutoSize = true;
            this.chkForm5.Location = new System.Drawing.Point(180, 89);
            this.chkForm5.Name = "chkForm5";
            this.chkForm5.Size = new System.Drawing.Size(115, 36);
            this.chkForm5.TabIndex = 13;
            this.chkForm5.Text = "Form 5";
            this.chkForm5.UseVisualStyleBackColor = true;
            // 
            // chkForm4
            // 
            this.chkForm4.AutoSize = true;
            this.chkForm4.Location = new System.Drawing.Point(20, 89);
            this.chkForm4.Name = "chkForm4";
            this.chkForm4.Size = new System.Drawing.Size(115, 36);
            this.chkForm4.TabIndex = 12;
            this.chkForm4.Text = "Form 4";
            this.chkForm4.UseVisualStyleBackColor = true;
            // 
            // chkForm3
            // 
            this.chkForm3.AutoSize = true;
            this.chkForm3.Location = new System.Drawing.Point(340, 46);
            this.chkForm3.Name = "chkForm3";
            this.chkForm3.Size = new System.Drawing.Size(115, 36);
            this.chkForm3.TabIndex = 11;
            this.chkForm3.Text = "Form 3";
            this.chkForm3.UseVisualStyleBackColor = true;
            // 
            // chkForm2
            // 
            this.chkForm2.AutoSize = true;
            this.chkForm2.Location = new System.Drawing.Point(180, 46);
            this.chkForm2.Name = "chkForm2";
            this.chkForm2.Size = new System.Drawing.Size(115, 36);
            this.chkForm2.TabIndex = 10;
            this.chkForm2.Text = "Form 2";
            this.chkForm2.UseVisualStyleBackColor = true;
            // 
            // chkForm1
            // 
            this.chkForm1.AutoSize = true;
            this.chkForm1.Location = new System.Drawing.Point(20, 46);
            this.chkForm1.Name = "chkForm1";
            this.chkForm1.Size = new System.Drawing.Size(115, 36);
            this.chkForm1.TabIndex = 9;
            this.chkForm1.Text = "Form 1";
            this.chkForm1.UseVisualStyleBackColor = true;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(20, 188);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(105, 32);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "Subject :";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(44, 35);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(81, 32);
            this.lblLevel.TabIndex = 20;
            this.lblLevel.Text = "Level :";
            // 
            // TutorchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(692, 576);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cklSubject);
            this.Controls.Add(this.grplevel);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblLevel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TutorchangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TutorchangeForm";
            this.Load += new System.EventHandler(this.TutorchangeForm_Load);
            this.grplevel.ResumeLayout(false);
            this.grplevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReset;
        private Button btnRegister;
        private CheckedListBox cklSubject;
        private GroupBox grplevel;
        private CheckBox chkForm5;
        private CheckBox chkForm4;
        private CheckBox chkForm3;
        private CheckBox chkForm2;
        private CheckBox chkForm1;
        private Label lblSubject;
        private Label lblLevel;
    }
}