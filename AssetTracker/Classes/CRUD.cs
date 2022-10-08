using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class CRUD
    {
        public static MySqlCommand SelectAllFromTable(string tableName)
        {
            Connection connection = new Connection();
            MySqlCommand command;
            connection.Connect();
            connection.Conn.Open();
            command = new MySqlCommand("SELECT * FROM " + tableName, connection.Conn);
            command.ExecuteNonQuery();            
            connection.Conn.Close();
            return command;
        }

        public static void Insert(string tableName, string columns, string values)
        {
            Connection connection = new Connection();
            MySqlCommand command;
            connection.Connect();
            connection.Conn.Open();
            command = new MySqlCommand("INSERT INTO " + tableName + " (" + columns + ") VALUES (" + values + ")", connection.Conn);
            command.ExecuteNonQuery();
            connection.Conn.Close();
        }

        public static void DeleteRowByPK(string tableName, string condition)
        {
            Connection connection = new Connection();
            MySqlCommand command;
            connection.Connect();
            connection.Conn.Open();
            command = new MySqlCommand("DELETE FROM " + tableName + " WHERE " + condition, connection.Conn);
            command.ExecuteNonQuery();
            connection.Conn.Close();
        }

        public static void UpdateRowByPK(string tableName, string values, string condition)
        {
            Connection connection = new Connection();
            MySqlCommand command;
            connection.Connect();
            connection.Conn.Open();
            command = new MySqlCommand("UPDATE " + tableName + " SET " + values + " WHERE " + condition, connection.Conn);
            command.ExecuteNonQuery();
            connection.Conn.Close();
        }
    }
}
