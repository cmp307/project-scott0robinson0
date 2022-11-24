using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class GeneralDB
    {
        public MySqlConnection Conn;

        protected GeneralDB()
        {
            Conn = new MySqlConnection("Server=lochnagar.abertay.ac.uk; Database=sql2203326; Uid=sql2203326; Pwd=iVGGteQzELna;");
        }

        //public static MySqlCommand CustomQuery(string condition)
        //{
        //    Connection connection = new Connection();
        //    MySqlCommand command;
        //    connection.Connect();
        //    connection.Conn.Open();
        //    command = new MySqlCommand(condition, connection.Conn);
        //    command.ExecuteNonQuery();
        //    connection.Conn.Close();
        //    return command;
        //}

        //public static MySqlCommand CustomQuery(string condition, Connection connection)
        //{
        //    MySqlCommand command;
        //    command = new MySqlCommand(condition, connection.Conn);
        //    command.ExecuteNonQuery();
        //    return command;
        //}

        protected void Insert(string tableName, List<string> columns, List<string> values)
        {
            string columnsString = String.Join(", ", columns);
            string valuesString = "'" + String.Join("', '", values) + "'";
            string sql = String.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columnsString, valuesString);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            command.ExecuteNonQuery();
        }

        //public static MySqlCommand SelectAll(string tableName)
        //{
        //    Connection connection = new Connection();
        //    MySqlCommand command;
        //    connection.Connect();
        //    connection.Conn.Open();
        //    command = new MySqlCommand("SELECT * FROM " + tableName, connection.Conn);
        //    command.ExecuteNonQuery();
        //    connection.Conn.Close();
        //    return command;
        //}

        //public static MySqlCommand Select(string tableName, string condition)
        //{
        //    Connection connection = new Connection();
        //    MySqlCommand command;
        //    connection.Connect();
        //    connection.Conn.Open();
        //    command = new MySqlCommand("SELECT * FROM " + tableName + " WHERE " + condition, connection.Conn);
        //    command.ExecuteNonQuery();
        //    connection.Conn.Close();
        //    return command;
        //}



        //public static void DeleteRowByPK(string tableName, string condition)
        //{
        //    Connection connection = new Connection();
        //    MySqlCommand command;
        //    connection.Connect();
        //    connection.Conn.Open();
        //    command = new MySqlCommand("DELETE FROM " + tableName + " WHERE " + condition, connection.Conn);
        //    command.ExecuteNonQuery();
        //    connection.Conn.Close();
        //}

        //public static void UpdateRowByPK(string tableName, string values, string condition)
        //{
        //    Connection connection = new Connection();
        //    MySqlCommand command;
        //    connection.Connect();
        //    connection.Conn.Open();
        //    command = new MySqlCommand("UPDATE " + tableName + " SET " + values + " WHERE " + condition, connection.Conn);
        //    command.ExecuteNonQuery();
        //    connection.Conn.Close();
        //}

        //public static bool KeyExists(string table, string keyName, string keyValue)
        //{
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(GeneralDB.Select(table, keyName + " = '" + keyValue + "'"));
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt.Rows.Count > 0;
        //}
    }
}
