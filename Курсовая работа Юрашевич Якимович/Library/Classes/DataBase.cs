using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Library.Classes
{
    public class DataBase
    {
        public MySqlConnection connectionLib = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=full ;UID=root ;PASSWORD=kukuruzka ;");
        public MySqlConnection connectionUsers = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=libraryusers ;UID=root ;PASSWORD=kukuruzka ;");

       

        public void openConnection(MySqlConnection sqlConnection) 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
               sqlConnection.Open();
            }
        
        }

        public void closeConnection(MySqlConnection sqlConnection)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public MySqlConnection GetConnection(MySqlConnection sqlConnection)
        {
            return sqlConnection;
        }






    }
}
