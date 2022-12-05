using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using OSVersionExtension;
using System.Text.RegularExpressions;

namespace Classes
{

    public class SoftwareAsset : Asset
    {
        public string Version { get; set; }
        public string Architecture { get; set; }

        public SoftwareAsset()
        {
            Name = string.Empty;
            Version = string.Empty;
            Manufacturer = string.Empty;
            Architecture = string.Empty;
        }

        public SoftwareAsset(string name, string version, string manufacturer, string architecture)
        {
            Name = name;
            Version = version;
            Manufacturer = manufacturer;
            Architecture = architecture;
        }

        public override void RetrieveData()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            Name += name.ToString();
            Version = OSVersion.MajorVersion10Properties().DisplayVersion;

            var manufacturer = (from x in new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Manufacturer")).FirstOrDefault();
            Manufacturer = manufacturer.ToString();

            var architecture = (from x in new ManagementObjectSearcher("SELECT OSArchitecture FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                                select x.GetPropertyValue("OSArchitecture")).FirstOrDefault();
            Architecture = architecture.ToString();
        }
    }
}
