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
    public partial class AddAuthor : Form
    {
        DataBase dataBase = new DataBase();
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public AddAuthor()
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
            checkInput(au_pseudo);
        }

       

     

        private void button1_Click(object sender, EventArgs e)
        {
            int idUs =Convert.ToInt32(us_id.Text);
            var pseudon = au_pseudo.Text;
                    
            string sqlCommand = $"INSERT INTO `full`.`author` (`au_id`, `au_pseudonym`) VALUES ('{idUs}', '{pseudon}'); ";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            dataBase.openConnection(connection);
            if (au_pseudo.Text == "" || us_id.Text == "")
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
            int idAuth = Convert.ToInt32(us_id.Text); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
                string sqlcm = $"SELECT * FROM full.author where au_id = '{idAuth}';";
                MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connection));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Автор с таким id уже существует!");
                    return true;
                }
                else return false;
            }
       
    }
}
