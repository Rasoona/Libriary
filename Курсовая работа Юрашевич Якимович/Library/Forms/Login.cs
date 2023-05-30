using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Controls;
using Library.Classes;
using MySql.Data.MySqlClient;

namespace Library.Forms
{
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();

        //private MySqlConnection connectionUsers = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=libraryusers ;UID=root ;PASSWORD=kukuruzka ;");
        private Panel childPanel;
        private Main mainFormPanel;
        public Login(Main mainFormPanel, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormPanel = mainFormPanel;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginbox.Text;
            var passwUser = passwordbox.Text;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT * FROM libraryusers.lib_user where user_login = '{loginUser}' and user_password = '{passwUser}';", dataBase.connectionUsers);
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли");
                Menu menu = new Menu(mainFormPanel, childPanel);
                mainFormPanel.activeForm = FormsControls.OpenChildForm(menu, this, childPanel);
            }
            else MessageBox.Show("Неправильный логин или пароль");
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(signUp, this, childPanel);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loginbox.Text = "";
            passwordbox.Text = "";
        }
    }
}
