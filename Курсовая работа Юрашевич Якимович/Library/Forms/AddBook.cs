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
    public partial class AddBook : Form
    {
        DataBase dataBase = new DataBase();
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public AddBook()
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
            int idBK =Convert.ToInt32(bk_id.Text);
            var nameBook = bk_name.Text;
            int auID = Convert.ToInt32(au_id.Text);
            int cv_ID = Convert.ToInt32(cv_id.Text);
            int gn_ID = Convert.ToInt32(gn_id.Text);
            int pb_ID = Convert.ToInt32(pb_id.Text);
            int pagesBK = Convert.ToInt32(bk_pages.Text);
            var publYear = bk_publishyear.Text;
            int avail = Convert.ToInt32(bk_avail.Tag);
            string sqlCommand = $"INSERT INTO `full`.`book` (`bk_id`, `bk_name`, `au_id`, `pb_id`, `cv_id`, `bk_pages`, `bk_publishyear`, `bk_availability`) VALUES ('{idBK}', '{nameBook}', '{auID}', '{pb_ID}', '{cv_ID}', '{pagesBK}', '{publYear}', '{avail}'); ";
            string addGenre = $"INSERT INTO `full`.`genrebook` (`bk_id`, `gn_id`) VALUES ('{idBK}', '{gn_ID}');";
            MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            MySqlCommand command2 = new MySqlCommand(addGenre, dataBase.GetConnection(connection));
            dataBase.openConnection(connection);
            if (bk_name.Text == "" || bk_id.Text == "" || au_id.Text =="" || pb_id.Text == "" || cv_id.Text == "" || gn_id.Text =="")
            { MessageBox.Show("Заполните поля");}
            else
            {
                if (checkUser() ==false && command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {MessageBox.Show("Регистрация прошла успешно");}
                else MessageBox.Show("Произошла ошибка");
                dataBase.closeConnection(connection);
            }


        }
        private Boolean checkUser()
        {
            int idBK = Convert.ToInt32(bk_id.Text); 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataTable dataTable = new DataTable();
                string sqlcm = $"SELECT * FROM full.book where bk_id = '{idBK}';";
                MySqlCommand command = new MySqlCommand(sqlcm, dataBase.GetConnection(connection));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Книга с таким id уже существует!");
                    return true;
                }
                else return false;
            }

        private void bk_avail_CheckedChanged(object sender, EventArgs e)
        {

            if (bk_avail.Checked == true)
            { bk_avail.Tag = "1"; }
            else bk_avail.Tag = "0";

        }
    }
}
