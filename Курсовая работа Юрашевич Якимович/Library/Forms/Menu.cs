using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Library.Controls;
using System.Xml.Serialization;
using System.IO;

namespace Library.Forms
{
    public partial class Menu : Form
    {
        private Panel childPanel;
        private Main mainFormPanel;
        public Menu(Main mainFormPanel, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormPanel = mainFormPanel;
            InitializeComponent();

        }
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(user, this, childPanel);
        }
    }
}
