using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class AssetDB
    {
        public static MySqlCommand SelectAllAssets()
        {
            return GeneralDB.CustomQuery(@"
                SELECT SGASSET.id, SGASSET.name, SGASSET.ipaddress, SGASSET.purchasedate, SGASSET.note, SGASSET.model, SGMODEL.type, SGMODEL.manufacturer
                FROM SGASSET
                INNER JOIN SGMODEL ON SGASSET.model = SGMODEL.name;
            ");
        }

        public static MySqlCommand SelectModelByName(string name, Connection connection)
        {
            return GeneralDB.CustomQuery2(@"
                SELECT *
                FROM SGMODEL
                WHERE name = '" + name + @"';
            ", connection);
        }

        public static void AddAsset(string name, string ipaddress, string purchasedate, string note, string model)
        {
            GeneralDB.Insert("SGASSET", "name, ipaddress, purchasedate, note, model", String.Format("'{0}', '{1}', '{2}', '{3}', '{4}'", name, ipaddress, purchasedate, note, model));
        }

        public static void AddAsset(string name, string ipaddress, string purchasedate, string note, string model, string type, string manufacturer)
        {
            AddModel(model, type, manufacturer);
            AddAsset(name, ipaddress, purchasedate, note, model);
        }

        public static void AddModel(string name, string type, string manufacturer)
        {
            GeneralDB.Insert("SGMODEL", "name, type, manufacturer", String.Format("'{0}', '{1}', '{2}'", name, type, manufacturer));
        }

        public static bool ModelExists(string name)
        {
            return GeneralDB.KeyExists("SGMODEL", "name", name);
        }
    }
}
