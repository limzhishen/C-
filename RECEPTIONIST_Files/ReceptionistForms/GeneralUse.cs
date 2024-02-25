using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_GROUP_22.ReceptionistForms
{
    
    public class GeneralUse
    {
        //Rest all text
        public void ResetEnteredValuesInControl(Control ctrl)
        {
            if (ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox))
            {
                ctrl.Text = "";

            }
            if (ctrl.GetType() == typeof(DateTimePicker))
            {
                ctrl.ResetText();
            }

            

            if (ctrl.HasChildren)
            {
                foreach (Control childCtrl in ctrl.Controls)
                {
                    ResetEnteredValuesInControl(childCtrl);
                }
            }
        }


    }
}
