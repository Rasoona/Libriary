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
    public partial class AddGenre : Form
    {
        DataBase dataBase = new DataBase();
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public AddGenre()
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
            checkInput(gn_name);
        }

       

     

        private void button1_Click(object sender, EventArgs e)
        {
            int idGN =Convert.ToInt32(gn_id.Text);
            var name = gn_name.Text;
                    
            string sqlCommand = $"INSERT INTO `full`.`genre` (`gn_id`, `gn_name`) VALUES ('{idGN}', '{name}'); ";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            dataBase.openConnection(connection);
            if (gn_name.Text == "" || gn_id.Text == "")
            {
                MessageBox.Show("Заполните все поля");

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
            int idGenre = Convert.ToInt32(gn_id.Text); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
                string sqlcm = $"SELECT * FROM full.genre where gn_id = '{idGenre}';";
                MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connection));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Жанр с таким id уже существует!");
                    return true;
                }
                else return false;
            }
       
    }
}
