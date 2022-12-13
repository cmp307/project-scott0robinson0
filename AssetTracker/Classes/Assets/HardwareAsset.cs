using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Management;
using System.Collections;

namespace Classes.Assets
{
    public class HardwareAsset : Asset
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public string PurchaseDate { get; set; }
        public string Note { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }

        public HardwareAsset()
        {
            Id = -1;
            Name = "";
            IpAddress = "";
            PurchaseDate = "";
            Note = "";
            ModelName = "";
            Type = "";
            Manufacturer = "";
        }

        public HardwareAsset(int id, string name, string ipaddress, string purchasedate, string note, string model, string type, string manufacturer)
        {
            Id = id;
            Name = name;
            IpAddress = ipaddress;
            PurchaseDate = purchasedate;
            Note = note;
            ModelName = model;
            Type = type;
            Manufacturer = manufacturer;
        }

        public HardwareAsset(string name, string ipaddress, string purchasedate, string note, string model, string type, string manufacturer)
        {
            Id = -1;
            Name = name;
            IpAddress = ipaddress;
            PurchaseDate = purchasedate;
            Note = note;
            ModelName = model;
            Type = type;
            Manufacturer = manufacturer;
        }

        public override void RetrieveData()
        {
            SelectQuery query = new SelectQuery("Select * from Win32_ComputerSystem");
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                foreach (ManagementObject process in searcher.Get())
                {
                    process.Get();
                    try
                    {
                        Manufacturer = process["Manufacturer"].ToString();
                        ModelName = process["Model"].ToString();
                        Type = process["SystemType"].ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        Manufacturer = "";
                        ModelName = "";
                        Type = "";
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            Name = Environment.MachineName;
            IpAddress = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
        }
    }
}
