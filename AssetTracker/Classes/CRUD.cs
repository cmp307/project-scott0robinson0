using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class CRUD
    {
        public MySqlDataAdapter SelectAllFromTable(string tableName)
        {
            Connection connection = new Connection();
            MySqlCommand command;
            MySqlDataAdapter adapter;
            connection.Connect();
            connection.Conn.Open();
            command = new MySqlCommand("SELECT * FROM item", connection.Conn);
            command.ExecuteNonQuery();            
            adapter = new MySqlDataAdapter(command);
            return adapter;
        }
    }
}
