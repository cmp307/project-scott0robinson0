using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Management;
using System.Collections;

namespace Classes
{
    public class HardwareAsset : Asset
    {
        public override string Name { get; set; }
        public string IpAddress { get; set; }
        public string PurchaseDate { get; set; }
        public string Note { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public override string Manufacturer { get; set; }

        public HardwareAsset()
        {
            Name = "";
            IpAddress = "";
            PurchaseDate = "";
            Note = "";
            Model = "";
            Type = "";
            Manufacturer = "";
        }

        public HardwareAsset(string name, string ipaddress, string purchasedate, string note, string model, string type, string manufacturer)
        {
            Name = name;
            IpAddress = ipaddress;
            PurchaseDate = purchasedate;
            Note = note;
            Model = model;
            Type = type;
            Manufacturer = manufacturer;
        }

        public override void RetrieveData()
        {
            System.Management.SelectQuery query = new System.Management.SelectQuery("Select * from Win32_ComputerSystem");
            using (System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query))
            {
                foreach (System.Management.ManagementObject process in searcher.Get())
                {
                    process.Get();
                    try
                    {
                        Manufacturer = process["Manufacturer"].ToString();
                        Model = process["Model"].ToString();
                        Type = process["SystemType"].ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        Manufacturer = "";
                        Model = "";
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
