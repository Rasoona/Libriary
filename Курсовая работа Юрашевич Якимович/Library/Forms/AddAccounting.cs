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
    public partial class AddAccounting : Form
    {
        DataBase dataBase = new DataBase();
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public AddAccounting()
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            int idBU =Convert.ToInt32(bu_id.Text);
            var idBK = bk_id.Text;
            var idUS =us_id.Text;
            var extrD =extrd.Text;
            var ret = returndate.Text;



            string sqlCommand = $"INSERT INTO `full`.`bookuser` (`bu_id`, `bk_id`, `us_id`, `bu_extraditionDate`, `bu_returnDate`) VALUES ('{idBU}', '{idBK}', '{idUS}', '{extrD}', '{ret}'); ";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            dataBase.openConnection(connection);
            if (bu_id.Text == "" || bk_id.Text == "" || us_id.Text == "" || extrd.Text == "")
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
            int idBU = Convert.ToInt32(bu_id.Text); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
                string sqlcm = $"SELECT * FROM full.bookuser where bu_id = '{idBU}';";
                MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connection));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Запись с таким id уже существует!");
                    return true;
                }
                else return false;
            }

        private void AddAccounting_Load(object sender, EventArgs e)
        {

        }
    }
}
