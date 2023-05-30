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
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(dataBase.connectionLib));
            dataBase.openConnection(dataBase.connectionLib);
            if (bu_id.Text == "" || bk_id.Text == "" || us_id.Text == "" || extrd.Text == "")
            {
                MessageBox.Show("Заполните все поля");

            }
            else
            {
                if (checkAcc() ==false && command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация прошла успешно");
                  
                }
                else MessageBox.Show("Произошла ошибка");
                dataBase.closeConnection(dataBase.connectionLib);
            }


        }
        private Boolean checkAcc()
        {
            int idBU = Convert.ToInt32(bu_id.Text);
            int idBK = Convert.ToInt32(bk_id.Text);
            int idUS = Convert.ToInt32(us_id.Text);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter();
            DataTable dataTable1 = new DataTable();
            MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter();
            DataTable dataTable2 = new DataTable();
            string sqlcm = $"SELECT * FROM full.bookuser where bu_id = '{idBU}';";
            string sqlcm1 = $"SELECT * FROM full.book where bk_id = '{idBK}';";
            string sqlcm2 = $"SELECT * FROM full.user where us_id = '{idUS}';";


            MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(dataBase.connectionLib));
            MySqlCommand command1 = new MySqlCommand(sqlcm1, dataBase.GetConnection(dataBase.connectionLib));
            MySqlCommand command2 = new MySqlCommand(sqlcm2, dataBase.GetConnection(dataBase.connectionLib));
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            dataAdapter1.SelectCommand = command1;
            dataAdapter1.Fill(dataTable1); 
            dataAdapter2.SelectCommand = command2;
            dataAdapter2.Fill(dataTable2);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Запись с таким id уже существует!");
                return true;
            }
            else if (dataTable1.Rows.Count ==0 || (dataTable2.Rows.Count == 0))
            { MessageBox.Show("Книги или пользователя с таким id нет");
                return true;
            
            }
            else return false;
            }

        private void AddAccounting_Load(object sender, EventArgs e)
        {

        }
    }
}
