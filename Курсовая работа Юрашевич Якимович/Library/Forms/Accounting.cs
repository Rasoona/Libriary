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
    public partial class Accounting : Form

    {
        DataBase dataBase = new DataBase();
        private Panel childPanel;
        private Main mainFormP;
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        int selectedRow;
        public Accounting()
        {
            
            InitializeComponent();
        }
        public Accounting(Main mainFormP, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormP = mainFormP;
            InitializeComponent();
            //player1.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM full.bookuser;", connection);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                bu_id.Text = row.Cells[0].Value.ToString();
                bk_id.Text = row.Cells[1].Value.ToString();
                us_id.Text = row.Cells[2].Value.ToString();
                extradict.Text = row.Cells[3].Value.ToString();
                //returndate.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAccounting add = new AddAccounting();
            add.Show();
        }
        //Поиск
        private void Search(DataGridView dataGridView)
        {
            
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT * FROM full.bookuser where concat (bu_id, bk_id, us_id, bu_extraditionDate, bu_returnDate) like '%{textBox1.Text}%'; ", connection);
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
                string sqlCommand = $"DELETE FROM `full`.`bookuser` WHERE (`bu_id` = '{id}'); ";
                MySqlCommand command = new MySqlCommand(sqlCommand, dataBase.GetConnection(connection));
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Удалено");
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM full.bookuser;", connection);
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
        //ИЗМЕНЕНИЕ ДАННЫХ
        private void Change()
        {
           
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id= bu_id.Text;
            var bkid=bk_id.Text;
            var usid=us_id.Text;
            var ext = extradict.Text;
            var returnn= returndate.Text;

            if ((bu_id.Text != "") && (bk_id.Text != "") && (us_id.Text != ""))
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, bkid, usid, ext, returnn);
            }
            else
            {
                MessageBox.Show("Строки не должны быть пустыми!");
            }

            dataBase.openConnection(connection);

            MySqlCommand command = null;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string sqlCommand = $"UPDATE `full`.`bookuser` SET `bk_id` = '{id}', `us_id` = '{bkid}', `bu_returnDate` = '{returnn}' WHERE (`bu_id` = '{id}');;";
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Change();
        }
    }
}
