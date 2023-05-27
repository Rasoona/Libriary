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
        int filterChoice = 0;
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
            switch (filterChoice)
            {
                case 1:
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where bk_name like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dataGridView.DataSource = dataSet.Tables[0];
                    break;
                case 2:
                    MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where genre.gn_name like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet1 = new DataSet();
                    dataAdapter1.Fill(dataSet1);
                    dataGridView.DataSource = dataSet1.Tables[0];
                    break;
                case 3:
                    MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where author.au_pseudonym like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet2 = new DataSet();
                    dataAdapter2.Fill(dataSet2);
                    dataGridView.DataSource = dataSet2.Tables[0];
                    break;
                case 4:
                    MySqlDataAdapter dataAdapter3 = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where publisher.pb_name like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet3 = new DataSet();
                    dataAdapter3.Fill(dataSet3);
                    dataGridView.DataSource = dataSet3.Tables[0];
                    break;
                case 5:
                    MySqlDataAdapter dataAdapter4 = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where cover.cv_type like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet4 = new DataSet();
                    dataAdapter4.Fill(dataSet4);
                    dataGridView.DataSource = dataSet4.Tables[0];
                    break;
                case 6:
                    MySqlDataAdapter dataAdapter5 = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where book.bk_publishyear like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet5 = new DataSet();
                    dataAdapter5.Fill(dataSet5);
                    dataGridView.DataSource = dataSet5.Tables[0];
                    break;
                case 7:
                    MySqlDataAdapter dataAdapter6 = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where book.bk_pages like '{textBox1.Text}%' group by book.bk_id; ", connection);
                    DataSet dataSet6 = new DataSet();
                    dataAdapter6.Fill(dataSet6);
                    dataGridView.DataSource = dataSet6.Tables[0];
                    break;
            }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 3;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 4;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
  "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
  " Inner join book on genrebook.bk_id = book.bk_id)" +
  " inner join cover on cover.cv_id = book.cv_id" +
  " inner join author on author.au_id = book.au_id" +
  " inner join publisher on publisher.pb_id = book.pb_id" +
  $" where book.bk_availability='1' group by book.bk_id; ", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT book.bk_name as Название, (select group_concat(genre.gn_name separator ', ')) as Жанр, cover.cv_type as Обложка, author.au_pseudonym as Автор, publisher.pb_name as Издательство, book.bk_pages as Страницы, book.bk_publishyear as ГодИздания, book.bk_availability as Доступность " +
 "FROM((genrebook INNER JOIN genre ON genrebook.gn_id = genre.gn_id)" +
 " Inner join book on genrebook.bk_id = book.bk_id)" +
 " inner join cover on cover.cv_id = book.cv_id" +
 " inner join author on author.au_id = book.au_id" +
 " inner join publisher on publisher.pb_id = book.pb_id" +
 $" where book.bk_availability='0' group by book.bk_id; ", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            filterChoice = 7;
        }
    }
}
