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

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(book, this, childPanel);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Author author = new Author(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(author, this, childPanel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(publisher, this, childPanel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(genre, this, childPanel);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SeeBookInfo bookInfo = new SeeBookInfo(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(bookInfo, this, childPanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accounting accounting= new Accounting(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(accounting, this, childPanel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ForeignBook book = new ForeignBook(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(book, this, childPanel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(login, this, childPanel);
        }
    }
}
