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
    public partial class AddPublisher : Form
    {
        DataBase dataBase = new DataBase();
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public AddPublisher()
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
            checkInput(pb_name);
        }

       

     

        private void button1_Click(object sender, EventArgs e)
        {
            int idPB =Convert.ToInt32(pb_id.Text);
            var name = pb_name.Text;
                    
            string sqlCommand = $"INSERT INTO `full`.`publisher` (`pb_id`, `pb_name`) VALUES ('{idPB}', '{name}'); ";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            dataBase.openConnection(connection);
            if (pb_name.Text == "" || pb_id.Text == "")
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
            int idPubl = Convert.ToInt32(pb_id.Text); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
                string sqlcm = $"SELECT * FROM full.publisher where pb_id = '{idPubl}';";
                MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connection));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Издательство с таким id уже существует!");
                    return true;
                }
                else return false;
            }
       
    }
}
