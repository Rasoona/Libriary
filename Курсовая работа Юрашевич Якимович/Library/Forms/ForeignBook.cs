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
    public partial class ForeignBook : Form

    {
        DataBase dataBase = new DataBase();
        private Panel childPanel;
        private Main mainFormP;
        MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        int selectedRow;
        public ForeignBook()
        {
            
            InitializeComponent();
        }
        public ForeignBook(Main mainFormP, Panel childPanel)
        {
            this.childPanel = childPanel;
            this.mainFormP = mainFormP;
            InitializeComponent();
            //player1.settings.setMode("loop", true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT foreignbook.bk_id as Id, foreignbook.bk_name as Название, language.ln_name as Язык"+
 " FROM((languagetranslator INNER JOIN language ON languagetranslator.ln_id = language.ln_id))"+
 " Inner join foreignbook on languagetranslator.lt_id = foreignbook.lt_id;", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        //Копирование данных их таблицы в текстбоксы
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                bk_id.Text = row.Cells[0].Value.ToString();
                bk_name.Text = row.Cells[1].Value.ToString();
                ln_name.Text = row.Cells[2].Value.ToString();
             
            }
        }

        //Поиск
        private void Search(DataGridView dataGridView)
        {
            //dataGridView1.Rows.Clear();
            //string searchString = $"SELECT * FROM full.user where concat (us_id, us_name, us_lastname, us_note) like '%{textBox1.Text}%'; ";
            //MySqlCommand command = new MySqlCommand(searchString, dataBase.GetConnection(connection));
            //dataBase.openConnection(connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter($"SELECT foreignbook.bk_id as Id, foreignbook.bk_name as Название, language.ln_name as Язык FROM((languagetranslator INNER JOIN language ON languagetranslator.ln_id = language.ln_id) Inner join foreignbook on languagetranslator.lt_id = foreignbook.lt_id) where concat(ln_name, foreignbook.bk_name) like '%{textBox1.Text}%'", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];

        }
        //Тоже поиск
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu book = new Menu(mainFormP, childPanel);
            mainFormP.activeForm = FormsControls.OpenChildForm(book, this, childPanel);
        }
        //Удаление


    }
}
