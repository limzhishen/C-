using System.Windows.Forms;

namespace IOOP_GROUP_22.ReceptionistForms
{
    partial class StudentEnrollment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEnrollment));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlStudEnrlDecide = new System.Windows.Forms.Panel();
            this.btnEnrlSave = new System.Windows.Forms.Button();
            this.btnEnrlCancel = new System.Windows.Forms.Button();
            this.btnEnrlStudInfoReset = new System.Windows.Forms.Button();
            this.pnlEnrlStudInfo = new System.Windows.Forms.Panel();
            this.pnlEnrlSubject = new System.Windows.Forms.Panel();
            this.btnBackEnrlStudInfo = new System.Windows.Forms.Button();
            this.cmbSubjSearch = new System.Windows.Forms.ComboBox();
            this.cmbLevelSearch = new System.Windows.Forms.ComboBox();
            this.btnAllEnrlLvlSubj = new System.Windows.Forms.Button();
            this.btnSrchEnrlLvlSubj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEnrlSubjResult = new System.Windows.Forms.Panel();
            this.grpEnrlLevel = new System.Windows.Forms.GroupBox();
            this.cmbEnrlLevel = new System.Windows.Forms.ComboBox();
            this.grpEnrlSubj2 = new System.Windows.Forms.GroupBox();
            this.lblEnrlClassId2 = new System.Windows.Forms.Label();
            this.lblEnrlSubjName2 = new System.Windows.Forms.Label();
            this.txtEnrlClassId2 = new System.Windows.Forms.TextBox();
            this.txtEnrlSubjName2 = new System.Windows.Forms.TextBox();
            this.grpEnrlSubj3 = new System.Windows.Forms.GroupBox();
            this.lblEnrlClassId3 = new System.Windows.Forms.Label();
            this.lblEnrlSubjName3 = new System.Windows.Forms.Label();
            this.txtEnrlClassId3 = new System.Windows.Forms.TextBox();
            this.txtEnrlSubjName3 = new System.Windows.Forms.TextBox();
            this.grpEnrlSubj1 = new System.Windows.Forms.GroupBox();
            this.lblEnrlClassId1 = new System.Windows.Forms.Label();
            this.lblEnrlSubjName1 = new System.Windows.Forms.Label();
            this.txtEnrlClassId1 = new System.Windows.Forms.TextBox();
            this.txtEnrlSubjName1 = new System.Windows.Forms.TextBox();
            this.btnEnrlSubjReset = new System.Windows.Forms.Button();
            this.dgvTutorTimetable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadStudProfilePic = new System.Windows.Forms.Button();
            this.picStudProfilePic = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEnrlUserPw = new System.Windows.Forms.Label();
            this.lblEnrlUsername = new System.Windows.Forms.Label();
            this.btnNextEnrlSubj = new System.Windows.Forms.Button();
            this.dtpEnrlDate = new System.Windows.Forms.DateTimePicker();
            this.lblEnrlDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEnrlBanner = new System.Windows.Forms.Label();
            this.txtEnrlStudContactNum = new System.Windows.Forms.TextBox();
            this.lblEnrlStudContactNum = new System.Windows.Forms.Label();
            this.txtEnrlStudEmail = new System.Windows.Forms.TextBox();
            this.lblEnrlStudEmail = new System.Windows.Forms.Label();
            this.txtEnrlStudName = new System.Windows.Forms.TextBox();
            this.lblEnrlStudName = new System.Windows.Forms.Label();
            this.rdoGenderFemale = new System.Windows.Forms.RadioButton();
            this.rdoGenderMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lstEnrlStudSubject = new System.Windows.Forms.ListBox();
            this.lblEnrlStudSubject = new System.Windows.Forms.Label();
            this.lstEnrlStudLevel = new System.Windows.Forms.ListBox();
            this.lblEnrlStudLevel = new System.Windows.Forms.Label();
            this.pnlEnrlPageButton = new System.Windows.Forms.Panel();
            this.btnEnrlStudSubj = new System.Windows.Forms.Button();
            this.btnEnrlStudInfo = new System.Windows.Forms.Button();
            this.pnlStudEnrlDecide.SuspendLayout();
            this.pnlEnrlStudInfo.SuspendLayout();
            this.pnlEnrlSubject.SuspendLayout();
            this.pnlEnrlSubjResult.SuspendLayout();
            this.grpEnrlLevel.SuspendLayout();
            this.grpEnrlSubj2.SuspendLayout();
            this.grpEnrlSubj3.SuspendLayout();
            this.grpEnrlSubj1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorTimetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudProfilePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlEnrlPageButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.BlanchedAlmond;
            // 
            // pnlStudEnrlDecide
            // 
            this.pnlStudEnrlDecide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudEnrlDecide.Controls.Add(this.btnEnrlSave);
            this.pnlStudEnrlDecide.Controls.Add(this.btnEnrlCancel);
            this.pnlStudEnrlDecide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStudEnrlDecide.Location = new System.Drawing.Point(0, 680);
            this.pnlStudEnrlDecide.Name = "pnlStudEnrlDecide";
            this.pnlStudEnrlDecide.Size = new System.Drawing.Size(1358, 64);
            this.pnlStudEnrlDecide.TabIndex = 22;
            this.pnlStudEnrlDecide.Visible = false;
            // 
            // btnEnrlSave
            // 
            this.btnEnrlSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnrlSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnrlSave.Location = new System.Drawing.Point(546, 7);
            this.btnEnrlSave.Name = "btnEnrlSave";
            this.btnEnrlSave.Size = new System.Drawing.Size(112, 46);
            this.btnEnrlSave.TabIndex = 21;
            this.btnEnrlSave.Text = "Save";
            this.btnEnrlSave.UseVisualStyleBackColor = true;
            this.btnEnrlSave.Click += new System.EventHandler(this.btnEnrlSave_Click);
            // 
            // btnEnrlCancel
            // 
            this.btnEnrlCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnrlCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnrlCancel.Location = new System.Drawing.Point(698, 7);
            this.btnEnrlCancel.Name = "btnEnrlCancel";
            this.btnEnrlCancel.Size = new System.Drawing.Size(112, 46);
            this.btnEnrlCancel.TabIndex = 19;
            this.btnEnrlCancel.Text = "Cancel";
            this.btnEnrlCancel.UseVisualStyleBackColor = true;
            this.btnEnrlCancel.Click += new System.EventHandler(this.btnEnrlCancel_Click);
            // 
            // btnEnrlStudInfoReset
            // 
            this.btnEnrlStudInfoReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnrlStudInfoReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnrlStudInfoReset.Location = new System.Drawing.Point(1091, 548);
            this.btnEnrlStudInfoReset.Name = "btnEnrlStudInfoReset";
            this.btnEnrlStudInfoReset.Size = new System.Drawing.Size(112, 46);
            this.btnEnrlStudInfoReset.TabIndex = 20;
            this.btnEnrlStudInfoReset.Text = "Reset";
            this.btnEnrlStudInfoReset.UseVisualStyleBackColor = true;
            this.btnEnrlStudInfoReset.Click += new System.EventHandler(this.btnEnrlStudInfoReset_Click);
            // 
            // pnlEnrlStudInfo
            // 
            this.pnlEnrlStudInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnrlStudInfo.Controls.Add(this.pnlEnrlSubject);
            this.pnlEnrlStudInfo.Controls.Add(this.btnUploadStudProfilePic);
            this.pnlEnrlStudInfo.Controls.Add(this.picStudProfilePic);
            this.pnlEnrlStudInfo.Controls.Add(this.txtUsername);
            this.pnlEnrlStudInfo.Controls.Add(this.txtPassword);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlUserPw);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlUsername);
            this.pnlEnrlStudInfo.Controls.Add(this.btnNextEnrlSubj);
            this.pnlEnrlStudInfo.Controls.Add(this.dtpEnrlDate);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlDate);
            this.pnlEnrlStudInfo.Controls.Add(this.panel2);
            this.pnlEnrlStudInfo.Controls.Add(this.btnEnrlStudInfoReset);
            this.pnlEnrlStudInfo.Controls.Add(this.txtEnrlStudContactNum);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlStudContactNum);
            this.pnlEnrlStudInfo.Controls.Add(this.txtEnrlStudEmail);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlStudEmail);
            this.pnlEnrlStudInfo.Controls.Add(this.txtEnrlStudName);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlStudName);
            this.pnlEnrlStudInfo.Controls.Add(this.rdoGenderFemale);
            this.pnlEnrlStudInfo.Controls.Add(this.rdoGenderMale);
            this.pnlEnrlStudInfo.Controls.Add(this.dtpBirthDate);
            this.pnlEnrlStudInfo.Controls.Add(this.lblBirthDate);
            this.pnlEnrlStudInfo.Controls.Add(this.lblGender);
            this.pnlEnrlStudInfo.Controls.Add(this.lstEnrlStudSubject);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlStudSubject);
            this.pnlEnrlStudInfo.Controls.Add(this.lstEnrlStudLevel);
            this.pnlEnrlStudInfo.Controls.Add(this.lblEnrlStudLevel);
            this.pnlEnrlStudInfo.Location = new System.Drawing.Point(0, 83);
            this.pnlEnrlStudInfo.Name = "pnlEnrlStudInfo";
            this.pnlEnrlStudInfo.Size = new System.Drawing.Size(1358, 599);
            this.pnlEnrlStudInfo.TabIndex = 21;
            // 
            // pnlEnrlSubject
            // 
            this.pnlEnrlSubject.Controls.Add(this.btnBackEnrlStudInfo);
            this.pnlEnrlSubject.Controls.Add(this.cmbSubjSearch);
            this.pnlEnrlSubject.Controls.Add(this.cmbLevelSearch);
            this.pnlEnrlSubject.Controls.Add(this.btnAllEnrlLvlSubj);
            this.pnlEnrlSubject.Controls.Add(this.btnSrchEnrlLvlSubj);
            this.pnlEnrlSubject.Controls.Add(this.label2);
            this.pnlEnrlSubject.Controls.Add(this.pnlEnrlSubjResult);
            this.pnlEnrlSubject.Controls.Add(this.dgvTutorTimetable);
            this.pnlEnrlSubject.Controls.Add(this.label1);
            this.pnlEnrlSubject.Location = new System.Drawing.Point(-1, 79);
            this.pnlEnrlSubject.Name = "pnlEnrlSubject";
            this.pnlEnrlSubject.Size = new System.Drawing.Size(1358, 519);
            this.pnlEnrlSubject.TabIndex = 51;
            this.pnlEnrlSubject.Visible = false;
            // 
            // btnBackEnrlStudInfo
            // 
            this.btnBackEnrlStudInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackEnrlStudInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackEnrlStudInfo.Location = new System.Drawing.Point(1243, 472);
            this.btnBackEnrlStudInfo.Name = "btnBackEnrlStudInfo";
            this.btnBackEnrlStudInfo.Size = new System.Drawing.Size(112, 46);
            this.btnBackEnrlStudInfo.TabIndex = 22;
            this.btnBackEnrlStudInfo.Text = "Previous";
            this.btnBackEnrlStudInfo.UseVisualStyleBackColor = true;
            this.btnBackEnrlStudInfo.Click += new System.EventHandler(this.btnBackEnrlStudInfo_Click);
            // 
            // cmbSubjSearch
            // 
            this.cmbSubjSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubjSearch.FormattingEnabled = true;
            this.cmbSubjSearch.Location = new System.Drawing.Point(401, 174);
            this.cmbSubjSearch.Name = "cmbSubjSearch";
            this.cmbSubjSearch.Size = new System.Drawing.Size(182, 40);
            this.cmbSubjSearch.TabIndex = 7;
            // 
            // cmbLevelSearch
            // 
            this.cmbLevelSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLevelSearch.FormattingEnabled = true;
            this.cmbLevelSearch.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.cmbLevelSearch.Location = new System.Drawing.Point(85, 174);
            this.cmbLevelSearch.Name = "cmbLevelSearch";
            this.cmbLevelSearch.Size = new System.Drawing.Size(182, 40);
            this.cmbLevelSearch.TabIndex = 6;
            // 
            // btnAllEnrlLvlSubj
            // 
            this.btnAllEnrlLvlSubj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAllEnrlLvlSubj.Location = new System.Drawing.Point(789, 170);
            this.btnAllEnrlLvlSubj.Name = "btnAllEnrlLvlSubj";
            this.btnAllEnrlLvlSubj.Size = new System.Drawing.Size(147, 46);
            this.btnAllEnrlLvlSubj.TabIndex = 5;
            this.btnAllEnrlLvlSubj.Text = "Show All";
            this.btnAllEnrlLvlSubj.UseVisualStyleBackColor = true;
            this.btnAllEnrlLvlSubj.Click += new System.EventHandler(this.btnAllEnrlLvlSubj_Click);
            // 
            // btnSrchEnrlLvlSubj
            // 
            this.btnSrchEnrlLvlSubj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchEnrlLvlSubj.Location = new System.Drawing.Point(652, 170);
            this.btnSrchEnrlLvlSubj.Name = "btnSrchEnrlLvlSubj";
            this.btnSrchEnrlLvlSubj.Size = new System.Drawing.Size(112, 46);
            this.btnSrchEnrlLvlSubj.TabIndex = 4;
            this.btnSrchEnrlLvlSubj.Text = "Search";
            this.btnSrchEnrlLvlSubj.UseVisualStyleBackColor = true;
            this.btnSrchEnrlLvlSubj.Click += new System.EventHandler(this.btnSrchEnrlLvlSubj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(302, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // pnlEnrlSubjResult
            // 
            this.pnlEnrlSubjResult.BackColor = System.Drawing.Color.MistyRose;
            this.pnlEnrlSubjResult.Controls.Add(this.grpEnrlLevel);
            this.pnlEnrlSubjResult.Controls.Add(this.grpEnrlSubj2);
            this.pnlEnrlSubjResult.Controls.Add(this.grpEnrlSubj3);
            this.pnlEnrlSubjResult.Controls.Add(this.grpEnrlSubj1);
            this.pnlEnrlSubjResult.Controls.Add(this.btnEnrlSubjReset);
            this.pnlEnrlSubjResult.Location = new System.Drawing.Point(10, -1);
            this.pnlEnrlSubjResult.Name = "pnlEnrlSubjResult";
            this.pnlEnrlSubjResult.Size = new System.Drawing.Size(1334, 143);
            this.pnlEnrlSubjResult.TabIndex = 2;
            // 
            // grpEnrlLevel
            // 
            this.grpEnrlLevel.BackColor = System.Drawing.Color.White;
            this.grpEnrlLevel.Controls.Add(this.cmbEnrlLevel);
            this.grpEnrlLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEnrlLevel.Location = new System.Drawing.Point(11, 13);
            this.grpEnrlLevel.Name = "grpEnrlLevel";
            this.grpEnrlLevel.Size = new System.Drawing.Size(155, 117);
            this.grpEnrlLevel.TabIndex = 5;
            this.grpEnrlLevel.TabStop = false;
            this.grpEnrlLevel.Text = "Level";
            // 
            // cmbEnrlLevel
            // 
            this.cmbEnrlLevel.FormattingEnabled = true;
            this.cmbEnrlLevel.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.cmbEnrlLevel.Location = new System.Drawing.Point(10, 45);
            this.cmbEnrlLevel.Name = "cmbEnrlLevel";
            this.cmbEnrlLevel.Size = new System.Drawing.Size(135, 40);
            this.cmbEnrlLevel.TabIndex = 0;
            // 
            // grpEnrlSubj2
            // 
            this.grpEnrlSubj2.BackColor = System.Drawing.Color.White;
            this.grpEnrlSubj2.Controls.Add(this.lblEnrlClassId2);
            this.grpEnrlSubj2.Controls.Add(this.lblEnrlSubjName2);
            this.grpEnrlSubj2.Controls.Add(this.txtEnrlClassId2);
            this.grpEnrlSubj2.Controls.Add(this.txtEnrlSubjName2);
            this.grpEnrlSubj2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEnrlSubj2.Location = new System.Drawing.Point(526, 13);
            this.grpEnrlSubj2.Name = "grpEnrlSubj2";
            this.grpEnrlSubj2.Size = new System.Drawing.Size(321, 117);
            this.grpEnrlSubj2.TabIndex = 5;
            this.grpEnrlSubj2.TabStop = false;
            this.grpEnrlSubj2.Text = "Subject 2";
            // 
            // lblEnrlClassId2
            // 
            this.lblEnrlClassId2.AutoSize = true;
            this.lblEnrlClassId2.Location = new System.Drawing.Point(14, 75);
            this.lblEnrlClassId2.Name = "lblEnrlClassId2";
            this.lblEnrlClassId2.Size = new System.Drawing.Size(90, 32);
            this.lblEnrlClassId2.TabIndex = 3;
            this.lblEnrlClassId2.Text = "ClassID";
            // 
            // lblEnrlSubjName2
            // 
            this.lblEnrlSubjName2.AutoSize = true;
            this.lblEnrlSubjName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlSubjName2.Location = new System.Drawing.Point(14, 33);
            this.lblEnrlSubjName2.Name = "lblEnrlSubjName2";
            this.lblEnrlSubjName2.Size = new System.Drawing.Size(78, 32);
            this.lblEnrlSubjName2.TabIndex = 2;
            this.lblEnrlSubjName2.Text = "Name";
            // 
            // txtEnrlClassId2
            // 
            this.txtEnrlClassId2.Location = new System.Drawing.Point(124, 72);
            this.txtEnrlClassId2.Name = "txtEnrlClassId2";
            this.txtEnrlClassId2.Size = new System.Drawing.Size(150, 39);
            this.txtEnrlClassId2.TabIndex = 1;
            // 
            // txtEnrlSubjName2
            // 
            this.txtEnrlSubjName2.Location = new System.Drawing.Point(124, 30);
            this.txtEnrlSubjName2.Name = "txtEnrlSubjName2";
            this.txtEnrlSubjName2.Size = new System.Drawing.Size(150, 39);
            this.txtEnrlSubjName2.TabIndex = 0;
            // 
            // grpEnrlSubj3
            // 
            this.grpEnrlSubj3.BackColor = System.Drawing.Color.White;
            this.grpEnrlSubj3.Controls.Add(this.lblEnrlClassId3);
            this.grpEnrlSubj3.Controls.Add(this.lblEnrlSubjName3);
            this.grpEnrlSubj3.Controls.Add(this.txtEnrlClassId3);
            this.grpEnrlSubj3.Controls.Add(this.txtEnrlSubjName3);
            this.grpEnrlSubj3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEnrlSubj3.Location = new System.Drawing.Point(867, 13);
            this.grpEnrlSubj3.Name = "grpEnrlSubj3";
            this.grpEnrlSubj3.Size = new System.Drawing.Size(321, 117);
            this.grpEnrlSubj3.TabIndex = 5;
            this.grpEnrlSubj3.TabStop = false;
            this.grpEnrlSubj3.Text = "Subject 3";
            // 
            // lblEnrlClassId3
            // 
            this.lblEnrlClassId3.AutoSize = true;
            this.lblEnrlClassId3.Location = new System.Drawing.Point(14, 75);
            this.lblEnrlClassId3.Name = "lblEnrlClassId3";
            this.lblEnrlClassId3.Size = new System.Drawing.Size(90, 32);
            this.lblEnrlClassId3.TabIndex = 3;
            this.lblEnrlClassId3.Text = "ClassID";
            // 
            // lblEnrlSubjName3
            // 
            this.lblEnrlSubjName3.AutoSize = true;
            this.lblEnrlSubjName3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlSubjName3.Location = new System.Drawing.Point(14, 33);
            this.lblEnrlSubjName3.Name = "lblEnrlSubjName3";
            this.lblEnrlSubjName3.Size = new System.Drawing.Size(78, 32);
            this.lblEnrlSubjName3.TabIndex = 2;
            this.lblEnrlSubjName3.Text = "Name";
            // 
            // txtEnrlClassId3
            // 
            this.txtEnrlClassId3.Location = new System.Drawing.Point(124, 72);
            this.txtEnrlClassId3.Name = "txtEnrlClassId3";
            this.txtEnrlClassId3.Size = new System.Drawing.Size(150, 39);
            this.txtEnrlClassId3.TabIndex = 1;
            // 
            // txtEnrlSubjName3
            // 
            this.txtEnrlSubjName3.Location = new System.Drawing.Point(124, 30);
            this.txtEnrlSubjName3.Name = "txtEnrlSubjName3";
            this.txtEnrlSubjName3.Size = new System.Drawing.Size(150, 39);
            this.txtEnrlSubjName3.TabIndex = 0;
            // 
            // grpEnrlSubj1
            // 
            this.grpEnrlSubj1.BackColor = System.Drawing.Color.White;
            this.grpEnrlSubj1.Controls.Add(this.lblEnrlClassId1);
            this.grpEnrlSubj1.Controls.Add(this.lblEnrlSubjName1);
            this.grpEnrlSubj1.Controls.Add(this.txtEnrlClassId1);
            this.grpEnrlSubj1.Controls.Add(this.txtEnrlSubjName1);
            this.grpEnrlSubj1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEnrlSubj1.Location = new System.Drawing.Point(185, 13);
            this.grpEnrlSubj1.Name = "grpEnrlSubj1";
            this.grpEnrlSubj1.Size = new System.Drawing.Size(321, 117);
            this.grpEnrlSubj1.TabIndex = 4;
            this.grpEnrlSubj1.TabStop = false;
            this.grpEnrlSubj1.Text = "Subject 1";
            // 
            // lblEnrlClassId1
            // 
            this.lblEnrlClassId1.AutoSize = true;
            this.lblEnrlClassId1.Location = new System.Drawing.Point(14, 75);
            this.lblEnrlClassId1.Name = "lblEnrlClassId1";
            this.lblEnrlClassId1.Size = new System.Drawing.Size(90, 32);
            this.lblEnrlClassId1.TabIndex = 3;
            this.lblEnrlClassId1.Text = "ClassID";
            // 
            // lblEnrlSubjName1
            // 
            this.lblEnrlSubjName1.AutoSize = true;
            this.lblEnrlSubjName1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlSubjName1.Location = new System.Drawing.Point(14, 33);
            this.lblEnrlSubjName1.Name = "lblEnrlSubjName1";
            this.lblEnrlSubjName1.Size = new System.Drawing.Size(78, 32);
            this.lblEnrlSubjName1.TabIndex = 2;
            this.lblEnrlSubjName1.Text = "Name";
            // 
            // txtEnrlClassId1
            // 
            this.txtEnrlClassId1.Location = new System.Drawing.Point(124, 72);
            this.txtEnrlClassId1.Name = "txtEnrlClassId1";
            this.txtEnrlClassId1.Size = new System.Drawing.Size(150, 39);
            this.txtEnrlClassId1.TabIndex = 1;
            // 
            // txtEnrlSubjName1
            // 
            this.txtEnrlSubjName1.Location = new System.Drawing.Point(124, 30);
            this.txtEnrlSubjName1.Name = "txtEnrlSubjName1";
            this.txtEnrlSubjName1.Size = new System.Drawing.Size(150, 39);
            this.txtEnrlSubjName1.TabIndex = 0;
            // 
            // btnEnrlSubjReset
            // 
            this.btnEnrlSubjReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnrlSubjReset.Location = new System.Drawing.Point(1212, 52);
            this.btnEnrlSubjReset.Name = "btnEnrlSubjReset";
            this.btnEnrlSubjReset.Size = new System.Drawing.Size(112, 46);
            this.btnEnrlSubjReset.TabIndex = 0;
            this.btnEnrlSubjReset.Text = "Reset";
            this.btnEnrlSubjReset.UseVisualStyleBackColor = true;
            this.btnEnrlSubjReset.Click += new System.EventHandler(this.btnEnrlSubjReset_Click);
            // 
            // dgvTutorTimetable
            // 
            this.dgvTutorTimetable.AllowUserToDeleteRows = false;
            this.dgvTutorTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutorTimetable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTutorTimetable.ColumnHeadersHeight = 34;
            this.dgvTutorTimetable.Location = new System.Drawing.Point(10, 220);
            this.dgvTutorTimetable.Name = "dgvTutorTimetable";
            this.dgvTutorTimetable.ReadOnly = true;
            this.dgvTutorTimetable.RowHeadersWidth = 62;
            this.dgvTutorTimetable.RowTemplate.Height = 33;
            this.dgvTutorTimetable.Size = new System.Drawing.Size(1334, 234);
            this.dgvTutorTimetable.TabIndex = 1;
            this.dgvTutorTimetable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutorTimetable_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            // 
            // btnUploadStudProfilePic
            // 
            this.btnUploadStudProfilePic.BackColor = System.Drawing.Color.White;
            this.btnUploadStudProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUploadStudProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadStudProfilePic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUploadStudProfilePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUploadStudProfilePic.Location = new System.Drawing.Point(1064, 401);
            this.btnUploadStudProfilePic.Name = "btnUploadStudProfilePic";
            this.btnUploadStudProfilePic.Size = new System.Drawing.Size(156, 34);
            this.btnUploadStudProfilePic.TabIndex = 60;
            this.btnUploadStudProfilePic.Text = "Upload Photo";
            this.btnUploadStudProfilePic.UseVisualStyleBackColor = false;
            this.btnUploadStudProfilePic.Click += new System.EventHandler(this.btnUploadStudProfilePic_Click);
            // 
            // picStudProfilePic
            // 
            this.picStudProfilePic.BackColor = System.Drawing.Color.White;
            this.picStudProfilePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStudProfilePic.BackgroundImage")));
            this.picStudProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picStudProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudProfilePic.Location = new System.Drawing.Point(1035, 170);
            this.picStudProfilePic.Name = "picStudProfilePic";
            this.picStudProfilePic.Size = new System.Drawing.Size(212, 212);
            this.picStudProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudProfilePic.TabIndex = 59;
            this.picStudProfilePic.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(246, 489);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 39);
            this.txtUsername.TabIndex = 58;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(600, 492);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 39);
            this.txtPassword.TabIndex = 57;
            // 
            // lblEnrlUserPw
            // 
            this.lblEnrlUserPw.AutoSize = true;
            this.lblEnrlUserPw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlUserPw.Location = new System.Drawing.Point(483, 495);
            this.lblEnrlUserPw.Name = "lblEnrlUserPw";
            this.lblEnrlUserPw.Size = new System.Drawing.Size(111, 32);
            this.lblEnrlUserPw.TabIndex = 56;
            this.lblEnrlUserPw.Text = "Password";
            // 
            // lblEnrlUsername
            // 
            this.lblEnrlUsername.AutoSize = true;
            this.lblEnrlUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlUsername.Location = new System.Drawing.Point(119, 492);
            this.lblEnrlUsername.Name = "lblEnrlUsername";
            this.lblEnrlUsername.Size = new System.Drawing.Size(121, 32);
            this.lblEnrlUsername.TabIndex = 55;
            this.lblEnrlUsername.Text = "Username";
            // 
            // btnNextEnrlSubj
            // 
            this.btnNextEnrlSubj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextEnrlSubj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextEnrlSubj.Location = new System.Drawing.Point(1241, 548);
            this.btnNextEnrlSubj.Name = "btnNextEnrlSubj";
            this.btnNextEnrlSubj.Size = new System.Drawing.Size(112, 46);
            this.btnNextEnrlSubj.TabIndex = 54;
            this.btnNextEnrlSubj.Text = "Next";
            this.btnNextEnrlSubj.UseVisualStyleBackColor = true;
            this.btnNextEnrlSubj.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // dtpEnrlDate
            // 
            this.dtpEnrlDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEnrlDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEnrlDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnrlDate.Location = new System.Drawing.Point(333, 419);
            this.dtpEnrlDate.Name = "dtpEnrlDate";
            this.dtpEnrlDate.Size = new System.Drawing.Size(185, 39);
            this.dtpEnrlDate.TabIndex = 53;
            // 
            // lblEnrlDate
            // 
            this.lblEnrlDate.AutoSize = true;
            this.lblEnrlDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlDate.Location = new System.Drawing.Point(121, 424);
            this.lblEnrlDate.Name = "lblEnrlDate";
            this.lblEnrlDate.Size = new System.Drawing.Size(187, 32);
            this.lblEnrlDate.TabIndex = 52;
            this.lblEnrlDate.Text = "Enrollment Date";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblEnrlBanner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 77);
            this.panel2.TabIndex = 50;
            // 
            // lblEnrlBanner
            // 
            this.lblEnrlBanner.AutoSize = true;
            this.lblEnrlBanner.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlBanner.Location = new System.Drawing.Point(544, 18);
            this.lblEnrlBanner.Name = "lblEnrlBanner";
            this.lblEnrlBanner.Size = new System.Drawing.Size(264, 38);
            this.lblEnrlBanner.TabIndex = 0;
            this.lblEnrlBanner.Text = "Student Information";
            // 
            // txtEnrlStudContactNum
            // 
            this.txtEnrlStudContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnrlStudContactNum.Location = new System.Drawing.Point(288, 207);
            this.txtEnrlStudContactNum.Name = "txtEnrlStudContactNum";
            this.txtEnrlStudContactNum.Size = new System.Drawing.Size(269, 39);
            this.txtEnrlStudContactNum.TabIndex = 49;
            // 
            // lblEnrlStudContactNum
            // 
            this.lblEnrlStudContactNum.AutoSize = true;
            this.lblEnrlStudContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlStudContactNum.Location = new System.Drawing.Point(123, 210);
            this.lblEnrlStudContactNum.Name = "lblEnrlStudContactNum";
            this.lblEnrlStudContactNum.Size = new System.Drawing.Size(136, 32);
            this.lblEnrlStudContactNum.TabIndex = 48;
            this.lblEnrlStudContactNum.Text = "Contact. no";
            // 
            // txtEnrlStudEmail
            // 
            this.txtEnrlStudEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnrlStudEmail.Location = new System.Drawing.Point(618, 130);
            this.txtEnrlStudEmail.Name = "txtEnrlStudEmail";
            this.txtEnrlStudEmail.Size = new System.Drawing.Size(330, 39);
            this.txtEnrlStudEmail.TabIndex = 47;
            // 
            // lblEnrlStudEmail
            // 
            this.lblEnrlStudEmail.AutoSize = true;
            this.lblEnrlStudEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlStudEmail.Location = new System.Drawing.Point(514, 133);
            this.lblEnrlStudEmail.Name = "lblEnrlStudEmail";
            this.lblEnrlStudEmail.Size = new System.Drawing.Size(71, 32);
            this.lblEnrlStudEmail.TabIndex = 46;
            this.lblEnrlStudEmail.Text = "Email";
            // 
            // txtEnrlStudName
            // 
            this.txtEnrlStudName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnrlStudName.Location = new System.Drawing.Point(223, 130);
            this.txtEnrlStudName.Name = "txtEnrlStudName";
            this.txtEnrlStudName.Size = new System.Drawing.Size(265, 39);
            this.txtEnrlStudName.TabIndex = 43;
            // 
            // lblEnrlStudName
            // 
            this.lblEnrlStudName.AutoSize = true;
            this.lblEnrlStudName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlStudName.Location = new System.Drawing.Point(119, 133);
            this.lblEnrlStudName.Name = "lblEnrlStudName";
            this.lblEnrlStudName.Size = new System.Drawing.Size(78, 32);
            this.lblEnrlStudName.TabIndex = 42;
            this.lblEnrlStudName.Text = "Name";
            // 
            // rdoGenderFemale
            // 
            this.rdoGenderFemale.AutoSize = true;
            this.rdoGenderFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoGenderFemale.Location = new System.Drawing.Point(439, 281);
            this.rdoGenderFemale.Name = "rdoGenderFemale";
            this.rdoGenderFemale.Size = new System.Drawing.Size(116, 36);
            this.rdoGenderFemale.TabIndex = 41;
            this.rdoGenderFemale.TabStop = true;
            this.rdoGenderFemale.Text = "Female";
            this.rdoGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rdoGenderMale
            // 
            this.rdoGenderMale.AutoSize = true;
            this.rdoGenderMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoGenderMale.Location = new System.Drawing.Point(286, 281);
            this.rdoGenderMale.Name = "rdoGenderMale";
            this.rdoGenderMale.Size = new System.Drawing.Size(92, 36);
            this.rdoGenderMale.TabIndex = 40;
            this.rdoGenderMale.TabStop = true;
            this.rdoGenderMale.Text = "Male";
            this.rdoGenderMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(333, 355);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(185, 39);
            this.dtpBirthDate.TabIndex = 39;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBirthDate.Location = new System.Drawing.Point(121, 355);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(150, 32);
            this.lblBirthDate.TabIndex = 38;
            this.lblBirthDate.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(121, 283);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(92, 32);
            this.lblGender.TabIndex = 37;
            this.lblGender.Text = "Gender";
            // 
            // lstEnrlStudSubject
            // 
            this.lstEnrlStudSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstEnrlStudSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEnrlStudSubject.FormattingEnabled = true;
            this.lstEnrlStudSubject.ItemHeight = 32;
            this.lstEnrlStudSubject.Items.AddRange(new object[] {
            "IOOP",
            "SAAD",
            "MCFC",
            "IDB"});
            this.lstEnrlStudSubject.Location = new System.Drawing.Point(1103, 672);
            this.lstEnrlStudSubject.Name = "lstEnrlStudSubject";
            this.lstEnrlStudSubject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstEnrlStudSubject.Size = new System.Drawing.Size(144, 100);
            this.lstEnrlStudSubject.TabIndex = 33;
            // 
            // lblEnrlStudSubject
            // 
            this.lblEnrlStudSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnrlStudSubject.AutoSize = true;
            this.lblEnrlStudSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlStudSubject.Location = new System.Drawing.Point(977, 672);
            this.lblEnrlStudSubject.Name = "lblEnrlStudSubject";
            this.lblEnrlStudSubject.Size = new System.Drawing.Size(93, 32);
            this.lblEnrlStudSubject.TabIndex = 32;
            this.lblEnrlStudSubject.Text = "Subject";
            // 
            // lstEnrlStudLevel
            // 
            this.lstEnrlStudLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstEnrlStudLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEnrlStudLevel.FormattingEnabled = true;
            this.lstEnrlStudLevel.ItemHeight = 32;
            this.lstEnrlStudLevel.Items.AddRange(new object[] {
            "Form 1",
            "Form 2",
            "Form 3",
            "Form 4",
            "Form 5"});
            this.lstEnrlStudLevel.Location = new System.Drawing.Point(747, 672);
            this.lstEnrlStudLevel.Name = "lstEnrlStudLevel";
            this.lstEnrlStudLevel.Size = new System.Drawing.Size(133, 36);
            this.lstEnrlStudLevel.TabIndex = 31;
            // 
            // lblEnrlStudLevel
            // 
            this.lblEnrlStudLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnrlStudLevel.AutoSize = true;
            this.lblEnrlStudLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrlStudLevel.Location = new System.Drawing.Point(621, 672);
            this.lblEnrlStudLevel.Name = "lblEnrlStudLevel";
            this.lblEnrlStudLevel.Size = new System.Drawing.Size(69, 32);
            this.lblEnrlStudLevel.TabIndex = 30;
            this.lblEnrlStudLevel.Text = "Level";
            // 
            // pnlEnrlPageButton
            // 
            this.pnlEnrlPageButton.Controls.Add(this.btnEnrlStudSubj);
            this.pnlEnrlPageButton.Controls.Add(this.btnEnrlStudInfo);
            this.pnlEnrlPageButton.Location = new System.Drawing.Point(0, 0);
            this.pnlEnrlPageButton.Name = "pnlEnrlPageButton";
            this.pnlEnrlPageButton.Size = new System.Drawing.Size(267, 83);
            this.pnlEnrlPageButton.TabIndex = 23;
            // 
            // btnEnrlStudSubj
            // 
            this.btnEnrlStudSubj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnrlStudSubj.Location = new System.Drawing.Point(128, 38);
            this.btnEnrlStudSubj.Name = "btnEnrlStudSubj";
            this.btnEnrlStudSubj.Size = new System.Drawing.Size(129, 46);
            this.btnEnrlStudSubj.TabIndex = 1;
            this.btnEnrlStudSubj.Text = "Enroll Subject";
            this.btnEnrlStudSubj.UseVisualStyleBackColor = true;
            this.btnEnrlStudSubj.Click += new System.EventHandler(this.btnEnrlStudSubj_Click);
            // 
            // btnEnrlStudInfo
            // 
            this.btnEnrlStudInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnrlStudInfo.Location = new System.Drawing.Point(0, 38);
            this.btnEnrlStudInfo.Name = "btnEnrlStudInfo";
            this.btnEnrlStudInfo.Size = new System.Drawing.Size(129, 46);
            this.btnEnrlStudInfo.TabIndex = 0;
            this.btnEnrlStudInfo.Text = "Student Info";
            this.btnEnrlStudInfo.UseVisualStyleBackColor = true;
            this.btnEnrlStudInfo.Click += new System.EventHandler(this.btnEnrlStudInfo_Click);
            // 
            // StudentEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1358, 744);
            this.Controls.Add(this.pnlEnrlPageButton);
            this.Controls.Add(this.pnlStudEnrlDecide);
            this.Controls.Add(this.pnlEnrlStudInfo);
            this.DoubleBuffered = true;
            this.Name = "StudentEnrollment";
            this.Text = "Student_Enrollment";
            this.Load += new System.EventHandler(this.StudentEnrollment_Load);
            this.pnlStudEnrlDecide.ResumeLayout(false);
            this.pnlEnrlStudInfo.ResumeLayout(false);
            this.pnlEnrlStudInfo.PerformLayout();
            this.pnlEnrlSubject.ResumeLayout(false);
            this.pnlEnrlSubject.PerformLayout();
            this.pnlEnrlSubjResult.ResumeLayout(false);
            this.grpEnrlLevel.ResumeLayout(false);
            this.grpEnrlSubj2.ResumeLayout(false);
            this.grpEnrlSubj2.PerformLayout();
            this.grpEnrlSubj3.ResumeLayout(false);
            this.grpEnrlSubj3.PerformLayout();
            this.grpEnrlSubj1.ResumeLayout(false);
            this.grpEnrlSubj1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorTimetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudProfilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlEnrlPageButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorDialog colorDialog1;
        private ToolTip toolTip1;
        private Panel pnlStudEnrlDecide;
        private Button btnEnrlSave;
        private Button btnEnrlStudInfoReset;
        private Button btnEnrlCancel;
        private Panel pnlEnrlStudInfo;
        private Panel panel2;
        private Label lblEnrlBanner;
        private TextBox txtEnrlStudContactNum;
        private Label lblEnrlStudContactNum;
        private TextBox txtEnrlStudEmail;
        private Label lblEnrlStudEmail;
        private TextBox txtEnrlStudName;
        private Label lblEnrlStudName;
        private RadioButton rdoGenderFemale;
        private RadioButton rdoGenderMale;
        private DateTimePicker dtpBirthDate;
        private Label lblBirthDate;
        private Label lblGender;
        private ListBox lstEnrlStudSubject;
        private Label lblEnrlStudSubject;
        private ListBox lstEnrlStudLevel;
        private Label lblEnrlStudLevel;
        private Panel pnlEnrlPageButton;
        private Button btnEnrlStudSubj;
        private Button btnEnrlStudInfo;
        private Panel pnlEnrlSubject;
        private Button btnAllEnrlLvlSubj;
        private Button btnSrchEnrlLvlSubj;
        private Label label2;
        private Panel pnlEnrlSubjResult;
        private GroupBox grpEnrlSubj2;
        private Label lblEnrlClassId2;
        private Label lblEnrlSubjName2;
        private TextBox txtEnrlClassId2;
        private TextBox txtEnrlSubjName2;
        private GroupBox grpEnrlSubj3;
        private Label lblEnrlClassId3;
        private Label lblEnrlSubjName3;
        private TextBox txtEnrlClassId3;
        private TextBox txtEnrlSubjName3;
        private GroupBox grpEnrlSubj1;
        private Label lblEnrlClassId1;
        private Label lblEnrlSubjName1;
        private TextBox txtEnrlClassId1;
        private TextBox txtEnrlSubjName1;
        private Button btnEnrlSubjReset;
        private DataGridView dgvTutorTimetable;
        private Label label1;
        private DateTimePicker dtpEnrlDate;
        private Label lblEnrlDate;
        private Button btnNextEnrlSubj;
        private ComboBox cmbSubjSearch;
        private ComboBox cmbLevelSearch;
        private GroupBox grpEnrlLevel;
        private ComboBox cmbEnrlLevel;
        private Button btnBackEnrlStudInfo;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblEnrlUserPw;
        private Label lblEnrlUsername;
        private Button btnUploadStudProfilePic;
        private PictureBox picStudProfilePic;
    }
}