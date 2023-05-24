using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Controls
{
    class FormsControls
    {
        //Метод, позволяющий передвать формы на панель Main формы
        static public Form OpenChildForm(Form childForm, Form activeForm, Panel panelChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            //LogControl.Log("OpenChildForm", "Открытие дочерней формы");
            return activeForm;
        }
    }
}
