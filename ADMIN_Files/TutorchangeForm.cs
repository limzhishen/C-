using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_GROUP_22
{
    public partial class TutorchangeForm : Form
    {
        private string userid="Tutor001";
        public TutorchangeForm()
        {
            InitializeComponent();
        }
        public TutorchangeForm(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void TutorchangeForm_Load(object sender, EventArgs e)
        {
            gettutorsubject();
            gettutorform();
        }
        private void gettutorform()
        {
            List<string> form=DataGetAdmin.gettutorform(userid);
            foreach(string f in form)
            {
                if(f=="Form 1")chkForm1.Checked= true;
                else if (f=="Form 2")chkForm2.Checked= true;
                else if (f=="Form 3")chkForm3.Checked= true;
                else if(f=="Form 4")chkForm4.Checked= true;
                else if (f=="Form 5")chkForm5.Checked= true;
            }
        }
        private void gettutorsubject()
        {
            DataTable subject = DataGetAdmin.getsubject();
            List<string> subject2 = DataGetAdmin.gettutorsubject(userid);
            foreach (DataRow row in subject.Rows)
            {
                int check = 0;
                foreach (string sub in subject2)
                {

                    if (row[0].ToString() == sub)
                    {
                        cklSubject.Items.Add(row[0], CheckState.Checked);
                        check = 1;
                        break;
                    }

                }
                if (check == 0)
                {
                    cklSubject.Items.Add(row[0], CheckState.Unchecked);
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkForm1.Checked= false;
            chkForm2.Checked= false;
            chkForm3.Checked= false;    
            chkForm4.Checked= false;
            chkForm5.Checked= false;
            cklSubject.Items.Clear();
            gettutorsubject();
            gettutorform();
        }
        private string getlevel()
        {
            StringBuilder level = new StringBuilder();
            if (chkForm1.Checked) level.Append("Form 1,");
            if (chkForm2.Checked) level.Append("Form 2,");
            if (chkForm3.Checked) level.Append("Form 3,");
            if (chkForm4.Checked) level.Append("Form 4,");
            if (chkForm5.Checked) level.Append("Form 5,");
            return level.ToString();
        }
        private string getsubject()
        {
            int i;
            StringBuilder subject = new StringBuilder();
            for (i = 0; i <= cklSubject.Items.Count - 1; i++)
            {
                if (cklSubject.GetItemChecked(i) == true)
                {
                    if (subject.Length == 0)
                    {
                        subject.Append(cklSubject.Items[i]);
                    }
                    else
                    {
                        subject.Append("," + cklSubject.Items[i]);
                    }
                }
            }

            return subject.ToString();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update?", "Update Tutor information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string level=getlevel();
                string subject=getsubject();
                DataGetAdmin obj=new DataGetAdmin(level,subject);
                string fo = obj.Update_Tutor_Form(userid);
                string sub = obj.Update_Tutor_subject(userid);
                if (fo=="Fail to update"&& sub=="Fail to update")
                {
                    MessageBox.Show(fo);
                }
                else
                {
                    
                    if (fo !=( "Fail to update")) MessageBox.Show(fo);
                    else MessageBox.Show(sub); 
                }
            }
        }
    }
}
