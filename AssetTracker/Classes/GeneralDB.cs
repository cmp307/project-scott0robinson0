using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes
{
    public class GeneralDB
    {
        public MySqlConnection Conn;

        public GeneralDB()
        {
            Conn = new MySqlConnection("Server=lochnagar.abertay.ac.uk; Database=sql2203326; Uid=sql2203326; Pwd=iVGGteQzELna;");
        }

        public GeneralDB(string conn)
        {
            Conn = new MySqlConnection(conn);
        }

        public MySqlCommand CustomQuery(string query)
        {
            MySqlCommand command;
            command = new MySqlCommand(query, Conn);
            return command;
        }

        public int Insert(string tableName, List<string> columns, List<string> values)
        {
            string columnsString = ListToColumnsString(columns);
            string valuesString = ListToValuesString(values);
            string sql = String.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columnsString, valuesString);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command.ExecuteNonQuery();
        }

        public int Insert(string tableName, Dictionary<string, string> columnValuePairs)
        {
            List<string> columns = new();
            List<string> values = new();
            string columnsString;
            string valuesString;

            foreach (KeyValuePair<string, string> pair in columnValuePairs)
            {
                columns.Add(pair.Key);
                values.Add(pair.Value);
            }

            columnsString = ListToColumnsString(columns);
            valuesString = ListToValuesString(values);

            string sql = String.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columnsString, valuesString);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command.ExecuteNonQuery();
        }

        public MySqlCommand Select(string columns, string tableName, string condition = "1=1")
        {
            string sql = String.Format("SELECT {0} FROM {1} WHERE {2}", columns, tableName, condition);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command;
        }

        public MySqlCommand Select(List<string> columns, string tableName, string condition = "1=1")
        {
            string columnsString = ListToColumnsString(columns);
            string sql = String.Format("SELECT {0} FROM {1} WHERE {2}", columnsString, tableName, condition);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command;
        }

        public int Delete(string tableName, string condition)
        {
            string sql = String.Format("DELETE FROM {0} WHERE {1}", tableName, condition);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command.ExecuteNonQuery();
        }

        public int Update(string tableName, string values, string condition)
        {
            string sql = String.Format("UPDATE {0} SET {1} WHERE {2}", tableName, values, condition);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command.ExecuteNonQuery();
        }

        public int Update(string tableName, Dictionary<string, string> values, string condition)
        {
            string valuesString = DictionaryToSetValuesString(values);
            string sql = String.Format("UPDATE {0} SET {1} WHERE {2}", tableName, valuesString, condition);
            MySqlCommand command;
            command = new MySqlCommand(sql, Conn);
            return command.ExecuteNonQuery();
        }

        public bool RowExists(string table, string keyName, string keyValue)
        {

            string condition = String.Format("{0} = '{1}'", keyName, keyValue);

            MySqlCommand command = Select("*", table, condition);

            using MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
                return true;
            return false;
        }

        protected static string ListToColumnsString(List<string> columns)
        {
            return String.Join(", ", columns);
        }

        protected static string ListToValuesString(List<string> values)
        {
            return "'" + String.Join("', '", values) + "'";
        }

        protected static string DictionaryToSetValuesString(Dictionary<string, string> values)
        {
            string SetValuesString;
            List<string> valueStrings = new();
            
            foreach (KeyValuePair<string, string> pair in values)
                valueStrings.Add(String.Format("{0} = '{1}'", pair.Key, pair.Value));

            SetValuesString = String.Join(", ", valueStrings);

            return SetValuesString;
        }
    }
}
