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
using Library.Controls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Library.Forms
{
    public partial class SeeBookInfo : Form

    {
        DataBase dataBase = new DataBase();
        private Panel childPanel;
        private Main mainFormP;
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        int selectedRow;
        public SeeBookInfo()
        {
            
            InitializeComponent();
        }
        public SeeBookInfo(Main mainFormP, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormP = mainFormP;
            InitializeComponent();
            //player1.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " + 
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id"+
 " group by book.bk_id", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ReadSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }
        //сортировка
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
            
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAuthor add = new AddAuthor();
            add.Show();
        }
        //Поиск
        private void Search(DataGridView dataGridView)
        {
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " + 
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 " group by book.bk_id like '%{textBox1.Text}%'; ", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];

        }
        //Тоже поиск
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        //Удаление
        private void deleteRow() 
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить?", "Выбор", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                //dataGridView1.Rows[index].Visible = false;
                dataBase.openConnection(connection);
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                string sqlCommand = $"DELETE FROM `full`.`author` WHERE (`au_id` = '{id}'); ";
                MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Удалено");
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM full.author;", connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];

                }
                else { }
                dataBase.closeConnection(connection);
            }
            else { }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu book = new Menu(mainFormP, childPanel);
            mainFormP.activeForm = FormsControls.OpenChildForm(book, this, childPanel);
        }
    }
}
