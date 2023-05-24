using Library.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Classes;

namespace Library.Forms
{
    public partial class SignUp : Form
    {
        DataBase dataBase = new DataBase();
        private MySqlConnection connectionUsers = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=libraryusers ;UID=root ;PASSWORD=kukuruzka ;");
        private Panel childPanel;
        private Main mainFormPanel;
        public SignUp(Main mainFormPanel, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormPanel = mainFormPanel;
            InitializeComponent();

        }

        private void returnButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login(mainFormPanel, childPanel);
            mainFormPanel.activeForm = FormsControls.OpenChildForm(login, this, childPanel);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loginbox.Text = "";
            passwordbox.Text = "";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            passwordbox.UseSystemPasswordChar = true;
            
        }

        private void seePass_MouseDown(object sender, MouseEventArgs e)
        {
            seePass.BackColor = Color.ForestGreen;          
            passwordbox.UseSystemPasswordChar = false;

        }

        private void seePass_MouseUp(object sender, MouseEventArgs e)
        {
            seePass.BackColor = Color.PaleGreen;
            passwordbox.UseSystemPasswordChar = true;

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginbox.Text;
            var passwUser = passwordbox.Text;

            
             //MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"INSERT INTO `libraryusers`.`lib_user` (`user_login`, `user_password`) VALUES ('{loginUser}', '{passwUser}');", connectionUsers);
            string sqlCommand = $"INSERT INTO `libraryusers`.`lib_user` (`user_login`, `user_password`) VALUES('{loginUser}', '{passwUser}'); ";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connectionUsers));
            dataBase.openConnection(connectionUsers);
            if (loginbox.Text == "" || passwordbox.Text == "")
            {
                MessageBox.Show("Заполните все поля");
               
            }
            else
            {
                if (checkUser() == false && command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация прошла успешно");
                    Login login = new Login(mainFormPanel, childPanel);
                    mainFormPanel.activeForm = FormsControls.OpenChildForm(login, this, childPanel);
                }
                else MessageBox.Show("Произошла ошибка");
                dataBase.closeConnection(connectionUsers);
            }
        }

        private Boolean checkUser() 
        {
            var loginUser = loginbox.Text;
            var passwUser = passwordbox.Text;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable dataTable = new DataTable();
            string sqlcm = $"SELECT * FROM libraryusers.lib_user where user_login = '{loginUser}' and user_password = '{passwUser}';";
            MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connectionUsers));
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else return false;
        }
    }
}
