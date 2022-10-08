using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Connection
    {
        public MySqlConnection Conn;

        public void Connect()
        {
            Conn = new MySqlConnection("Server=https://lochnagar.abertay.ac.uk/; Database=sql2203326; Uid=sql2203326; Pwd=iVGGteQzELna;");
            //Conn = new MySqlConnection("Server=localhost; Database=forum; Uid=root; Pwd=;");
        }
    }
}