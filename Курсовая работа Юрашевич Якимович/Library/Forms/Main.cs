﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Controls;
using System.Xml.Serialization;
using System.IO;


namespace Library
{
    public partial class Main : Form
    {
        public Form activeForm = null;
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Forms.Login login = new Forms.Login(this, childPanel);
            activeForm = FormsControls.OpenChildForm(login, activeForm, childPanel);
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LogControl.SaveLogs();
        }
    }
}
