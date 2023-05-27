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
    public partial class Book : Form

    {
        DataBase dataBase = new DataBase();
        private Panel childPanel;
        private Main mainFormP;
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        int selectedRow;
        public Book()
        {
            
            InitializeComponent();
        }
        public Book(Main mainFormP, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormP = mainFormP;
            InitializeComponent();
            //player1.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM full.book;", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        //private void ReadSingleRow(DataGridView dataGrid, IDataRecord record)
        //{
        //    dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
        //}
        //Копирование данных их таблицы в текстбоксы
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                bk_id.Text = row.Cells[0].Value.ToString();
                bk_name.Text = row.Cells[1].Value.ToString();
                au_id.Text = row.Cells[2].Value.ToString();
               
                pb_id.Text = row.Cells[3].Value.ToString();
                cv_id.Text = row.Cells[4].Value.ToString();
                bk_pages.Text = row.Cells[5].Value.ToString();
                //bk_publishyear.Text = row.Cells[6].Value.ToString();
                if (row.Cells[7].Value.ToString() == "True")
                { bk_avail.Checked = true; }
                else { bk_avail.Checked = false; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
        }
        //Поиск
        private void Search(DataGridView dataGridView)
        {
            
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT * FROM full.book where concat (bk_id, bk_name, au_id, pb_id, cv_id, bk_pages, bk_publishyear) like '%{textBox1.Text}%'; ", connection);
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
                string sqlCommand = $"DELETE FROM `full`.`book` WHERE (`bk_id` = '{id}'); ";
                string sqlCommand2 = $"DELETE FROM `full`.`genrebook` WHERE (`bk_id` = '{id}'); ";
                MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
                MySqlCommand command2 = new MySqlCommand(sqlCommand2, dataBase.GetConnection(connection));
                if (command2.ExecuteNonQuery() == 1 )
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Удалено");
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM full.book;", connection);
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
        //ИЗМЕНЕНИЕ ДАННЫХ
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = bk_id.Text;
            var name = bk_name.Text;
            var auID = au_id.Text;
            var cvID = cv_id.Text;
            var pbID = pb_id.Text;
            var pages = bk_pages.Text;
            var publyear = bk_publishyear.Text;
            int avail;
            if (bk_avail.Checked == true)
            { avail = 1; }
            else { avail = 0; }

            if ((bk_id.Text != "") || (bk_name.Text != ""))
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, auID, pbID, cvID, pages, publyear, avail);
            }
            else
            {
                MessageBox.Show("Строки не должны быть пустыми!");
            }

            dataBase.openConnection(connection);

            MySqlCommand command = null;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string sqlCommand = $"UPDATE `full`.`book` SET `bk_name` = '{name}', `au_id` = '{auID}', `pb_id` = '{pbID}', `cv_id` = '{cvID}', `bk_pages` = '{pages}', `bk_publishyear` = '{publyear}', `bk_availability` = '{avail}' WHERE (`bk_id` = '{id}');";
                command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
            }

            if (command.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Запись не была изменена!");
            }
            else
            {
                MessageBox.Show("Запись успешно изменена!");
            }

            dataBase.closeConnection(connection);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu book = new Menu(mainFormP, childPanel);
            mainFormP.activeForm = FormsControls.OpenChildForm(book, this, childPanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}
