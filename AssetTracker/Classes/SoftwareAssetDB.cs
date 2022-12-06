using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SoftwareAssetDB : GeneralDB
    {
        public void AddAsset(SoftwareAsset softwareAsset)
        {
            Dictionary<string, string> properties = OBJProperties.GetProperties(softwareAsset);

            Insert("SGSOFTWAREASSET", properties);
        }

        public MySqlCommand SelectAllAssets()
        {
            string columns = "name 'Name', version 'Version', manufacturer 'Manufacturer', architecture 'Architecture'";
            
            return Select(columns, "SGSOFTWAREASSET");
        }

        public MySqlCommand SelectAsset(string name = "%", string version = "%")
        {
            string columns = "name 'Name', version 'Version', manufacturer 'Manufacturer', architecture 'Architecture'";
            string conditions = String.Format("name LIKE '{0}' AND version LIKE '{1}'", name, version);

            return Select(columns, "SGSOFTWAREASSET", conditions);
        }

        public int UpdateAsset(SoftwareAsset softwareAsset)
        {
            Dictionary<string, string> fields = OBJProperties.GetProperties(softwareAsset);
            string condition = String.Format("(name, version) = ('{0}', '{1}')", softwareAsset.Name, softwareAsset.Version);

            return Update("SGSOFTWAREASSET", fields, condition);
        }

        public int DeleteAsset(string name, string version)
        {
            string condition = String.Format("(name, version) = ('{0}', '{1}')", name, version);

            return Delete("SGSOFTWAREASSET", condition);
        }

        public bool AssetExists(string name, string version)
        {
            string values = String.Format("('{0}', '{1}')", name, version);

            return RowExists("SGSOFTWAREASSET", "(name, version)", values);
        }
    }
}
