using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Classes
{
    public class Database
    {
        public MySqlConnection Conn;

        public Database()
        {
            Conn = new MySqlConnection("Server=lochnagar.abertay.ac.uk; Database=sql2203326; Uid=sql2203326; Pwd=iVGGteQzELna;");
        }

        public MySqlCommand SelectAllAssets()
        {
            string sql = @"
                SELECT SGASSET.id 'ID', SGASSET.name 'Name', SGASSET.ipaddress 'IP Address', SGASSET.purchasedate 'Purchase Date', SGASSET.note 'Note', SGASSET.model 'Model', SGMODEL.type 'Type', SGMODEL.manufacturer 'Manufacturer'
                FROM SGASSET
                INNER JOIN SGMODEL ON SGASSET.model = SGMODEL.name;
            ";

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public MySqlCommand SelectAssetById(int id)
        {
            string sql = @"
                SELECT SGASSET.id, SGASSET.name, SGASSET.ipaddress, SGASSET.purchasedate, SGASSET.note, SGMODEL.name, SGMODEL.type, SGMODEL.manufacturer
                FROM SGASSET
                JOIN SGMODEL
                ON SGASSET.model = SGMODEL.name
                WHERE SGASSET.id = " + id;
            MySqlCommand cmd;
            cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public MySqlCommand SelectAssetByIp(string ip)
        {
            string sql = @"
                SELECT SGASSET.id, SGASSET.name, SGASSET.ipaddress, SGASSET.purchasedate, SGASSET.note, SGMODEL.name, SGMODEL.type, SGMODEL.manufacturer
                FROM SGASSET
                JOIN SGMODEL
                ON SGASSET.model = SGMODEL.name
                WHERE SGASSET.ipaddress = " + ip;
            MySqlCommand cmd;
            cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public MySqlCommand SelectModelByName(string name)
        {
            string sql = @"
                SELECT *
                FROM SGMODEL
                WHERE name = '" + name + @"';
            ";

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public void AddAsset(string name, string ipaddress, string purchasedate, string note, string model)
        {
            string sql = @"INSERT INTO SGASSET (name, ipaddress, purchasedate, note, model)
                           VALUES " + String.Format("('{0}', '{1}', '{2}', '{3}', '{4}')", name, ipaddress, purchasedate, note, model);

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
        }

        public void AddAsset(string name, string ipaddress, string note, string model)
        {
            string sql = @"INSERT INTO SGASSET (name, ipaddress, note, model)
                           VALUES " + String.Format("('{0}', '{1}', '{2}', '{3}')", name, ipaddress, note, model);

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
        }

        public void AddAsset(string name, string ipaddress, string purchasedate, string note, string model, string type, string manufacturer)
        {
            AddModel(model, type, manufacturer);
            AddAsset(name, ipaddress, purchasedate, note, model);
        }

        public void AddAsset(string name, string ipaddress, string note, string model, string type, string manufacturer)
        {
            AddModel(model, type, manufacturer);
            AddAsset(name, ipaddress, note, model);
        }

        public void AddModel(string name, string type, string manufacturer)
        {
            string sql = @"INSERT INTO SGMODEL (name, type, manufacturer)
                           VALUES " + String.Format("('{0}', '{1}', '{2}')", name, type, manufacturer);

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
        }

        public void DeleteAssetById(int id)
        {
            string sql = "DELETE FROM SGASSET WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
        }

        public void DeleteAssetByIp(string ip)
        {
            string sql = String.Format("DELETE FROM SGASSET WHERE ipaddress = '{0}'",  ip);
            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();
        }

        public bool ModelExists(string name)
        {
            MySqlCommand cmd = this.SelectModelByName(name);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool exists = reader.Read();
            reader.Close();
            return exists;
        }
    }
}
