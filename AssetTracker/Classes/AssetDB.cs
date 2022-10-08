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
                SELECT sgasset.id, sgasset.name, sgasset.ipaddress, sgasset.purchasedate, sgasset.note, sgasset.model, sgmodel.type, sgmodel.manufacturer
                FROM sgasset
                INNER JOIN sgmodel ON sgasset.model = sgmodel.name;
            ");
        }

        public static void AddAsset(string name, string ipaddress, string purchasedate, string note, string model)
        {
            GeneralDB.Insert("sgasset", "name, ipaddress, purchasedate, note, model", String.Format("'{0}', '{1}', '{2}', '{3}', '{4}'", name, ipaddress, purchasedate, note, model));
        }

        public static void AddAsset(string name, string ipaddress, string purchasedate, string note, string model, string type, string manufacturer)
        {
            AddModel(model, type, manufacturer);
            AddAsset(name, ipaddress, purchasedate, note, model);
        }

        public static void AddModel(string name, string type, string manufacturer)
        {
            GeneralDB.Insert("sgmodel", "name, type, manufacturer", String.Format("'{0}', '{1}', '{2}'", name, type, manufacturer));
        }

        public static bool ModelExists(string name)
        {
            return GeneralDB.KeyExists("sgmodel", "name", name);
        }
    }
}
