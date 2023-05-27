using Library.Classes;
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

namespace Library.Forms
{
    public partial class AddUserForm : Form
    {
        DataBase dataBase = new DataBase();
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public AddUserForm()
        {
            InitializeComponent();
        }
        static public void checkInput(TextBox field)
        {
            foreach (char a in field.Text)
            {
                if (!char.IsLetter(a))
                {
                    field.Text = field.Text.Remove(field.Text.Length - 1);
                    field.SelectionStart = field.Text.Length;

                }
            }
    
        }

        private void us_name_TextChanged(object sender, EventArgs e)
        {
            checkInput(us_name);
        }

        private void us_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void us_lastname_TextChanged(object sender, EventArgs e)
        {
            checkInput(us_lastname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUs =Convert.ToInt32(us_id.Text);
            var nameUS = us_name.Text;
            var lastnameUs =us_lastname.Text;
            var noteUs =us_notes.Text;


            
            string sqlCommand = $"INSERT INTO `full`.`user` (`us_id`, `us_name`, `us_lastname`, `us_note`) VALUES ('{idUs}', '{nameUS}', '{lastnameUs}', '{noteUs}'); ";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            dataBase.openConnection(connection);
            if (us_lastname.Text == "" || us_name.Text == "" || us_id.Text == "")
            {
                MessageBox.Show("Заполните поля ID, Имя, Фамилия");

            }
            else
            {
                if (checkUser() ==false && command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация прошла успешно");
                  
                }
                else MessageBox.Show("Произошла ошибка");
                dataBase.closeConnection(connection);
            }


        }
        private Boolean checkUser()
        {
            int idUser = Convert.ToInt32(us_id.Text); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
                string sqlcm = $"SELECT * FROM full.user where us_id = '{idUser}';";
                MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connection));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким id уже существует!");
                    return true;
                }
                else return false;
            }
       
    }
}
