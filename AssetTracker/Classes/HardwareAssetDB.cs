using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Classes
{
    public class HardwareAssetDB : GeneralDB
    {
        //private const string selectAllFromAsset = @"
        //        SELECT SGHARDWAREASSET.id 'ID', SGHARDWAREASSET.name 'Name', SGHARDWAREASSET.ipaddress 'IP Address', SGHARDWAREASSET.purchasedate 'Purchase Date', SGHARDWAREASSET.note 'Note', SGHARDWAREASSET.modelname 'Model', SGMODEL.type 'Type', SGMODEL.manufacturer 'Manufacturer'
        //        FROM SGHARDWAREASSET
        //        INNER JOIN SGMODEL ON SGHARDWAREASSET.modelname = SGMODEL.modelname
        //    ";

        private const string selectAllFromAsset = @"
                SELECT SGHARDWAREASSET.id 'ID', SGHARDWAREASSET.name 'Name', SGHARDWAREASSET.ipaddress 'IP Address', SGHARDWAREASSET.purchasedate 'Purchase Date', SGHARDWAREASSET.note 'Note', SGHARDWAREASSET.modelname 'Model', SGMODEL.type 'Type', SGMODEL.manufacturer 'Manufacturer', SGHARDWAREASSET.softwareassetname 'OS Name', SGHARDWAREASSET.softwareassetversion 'OS Version', SGSOFTWAREASSET.manufacturer 'OS Manufacturer', SGSOFTWAREASSET.architecture 'OS Architecture'
                FROM SGHARDWAREASSET
                INNER JOIN SGMODEL ON SGHARDWAREASSET.modelname = SGMODEL.modelname
                LEFT JOIN SGSOFTWAREASSET ON (SGHARDWAREASSET.softwareassetname, SGHARDWAREASSET.softwareassetversion) = (SGSOFTWAREASSET.name, SGSOFTWAREASSET.version)
            ";

        public void AddAsset(HardwareAsset hardwareAsset)
        {
            Dictionary<string, string> properties = OBJProperties.GetProperties(hardwareAsset);
            List<string> columns = new();
            List<string> values = new();

            foreach (KeyValuePair<string, string> property in properties)
            {
                if (property.Key != "type" && property.Key != "manufacturer")
                {
                    columns.Add(property.Key);
                    values.Add(property.Value);
                }
            }

            AddModel(hardwareAsset);
            Insert("SGHARDWAREASSET", columns, values);        
        }

        private void AddModel(HardwareAsset hardwareAsset)
        {
            Dictionary<string, string> properties = OBJProperties.GetProperties(hardwareAsset);
            List<string> columns = new();
            List<string> values = new();

            foreach (KeyValuePair<string, string> property in properties)
            {
                if (property.Key == "modelname" || property.Key == "type" || property.Key == "manufacturer")
                {
                    columns.Add(property.Key);
                    values.Add(property.Value);
                }
            }

            if (!ModelExists(properties["modelname"]))
                Insert("SGMODEL", columns, values);
        }

        public MySqlCommand SelectAllAssets()
        {
            return CustomQuery(selectAllFromAsset);
        }

        public MySqlCommand SelectAssetById(int id)
        {
            string sql = String.Format("{0} WHERE SGHARDWAREASSET.id = '{1}'", selectAllFromAsset, id);

            return CustomQuery(sql);
        }

        public MySqlCommand SelectAssetByIp(string ip)
        {
            string sql = String.Format("{0} WHERE SGHARDWAREASSET.ipaddress = '{1}'", selectAllFromAsset, ip);

            return CustomQuery(sql);
        }

        public MySqlCommand SelectModelByName(string name)
        {
            string condition = String.Format("modelname = '{0}'", name);

            return Select("*", "SGMODEL", condition);
        }

        public int UpdateAssetById(HardwareAsset hardwareAsset)
        {
            Dictionary<string, string> fields = new();

            foreach (KeyValuePair<string, string> property in OBJProperties.GetProperties(hardwareAsset))
            {
                if (property.Key != "type" && property.Key != "manufacturer")
                    fields.Add(property.Key, property.Value);
            }

            string setValues = DictionaryToSetValuesString(fields);
            string condition = String.Format("id = '{0}'", hardwareAsset.Id);
            UpdateModel(hardwareAsset);
            return Update("SGHARDWAREASSET", setValues, condition);
        }

        public int UpdateAssetByIp(HardwareAsset hardwareAsset)
        {
            Dictionary<string, string> fields = new();

            foreach (KeyValuePair<string, string> property in OBJProperties.GetProperties(hardwareAsset))
            {
                if (property.Key != "type" && property.Key != "manufacturer")
                    fields.Add(property.Key, property.Value);
            }

            string setValues = DictionaryToSetValuesString(fields);
            string condition = String.Format("ipaddress = '{0}'", hardwareAsset.IpAddress);
            UpdateModel(hardwareAsset);
            return Update("SGHARDWAREASSET", setValues, condition);
        }

        public void UpdateModel(HardwareAsset hardwareAsset)
        {
            Dictionary<string, string> hardwareAssetFields = OBJProperties.GetProperties(hardwareAsset);
            Dictionary<string, string> modelFields = new();

            foreach (KeyValuePair<string, string> field in hardwareAssetFields)
            {
                if (field.Key == "modelname" || field.Key == "type" || field.Key == "manufacturer")
                    modelFields.Add(field.Key, field.Value);
            }


            string condition = String.Format("modelname = '{0}'", hardwareAsset.ModelName);
            if (ModelExists(hardwareAsset.ModelName))
                Update("SGMODEL", modelFields, condition);
            else
                Insert("SGMODEL", modelFields);
        }

        public int DeleteAssetById(int id)
        {
            string condition = String.Format("id = '{0}'", id);

            return Delete("SGHARDWAREASSET", condition);
        }

        public int DeleteAssetByIp(string ip)
        {
            string condition = String.Format("ipaddress = '{0}'", ip);

            return Delete("SGHARDWAREASSET", condition);
        }

        public bool ModelExists(string name)
        {
            return RowExists("SGMODEL", "modelname", name);
        }

        public bool AssetExistsById(int id)
        {
            return RowExists("SGHARDWAREASSET", "id", id.ToString());
        }

        public bool AssetExistsByIp(string ip)
        {
            return RowExists("SGHARDWAREASSET", "ipaddress", ip);
        }
    }
}
