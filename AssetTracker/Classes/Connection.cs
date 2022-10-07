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
        public MySqlConnection conn;

        public void Connect()
        {
            conn = new MySqlConnection("Server=lochnagar.abertay.ac.uk; Database=sql2203326; Uid=sql2203326; Pwd=iVGGteQzELna;");
        }
    }
}