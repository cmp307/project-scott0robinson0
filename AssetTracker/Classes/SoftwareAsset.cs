using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Classes
{

    public class SoftwareAsset : Asset
    {
        public string Version { get; set; }

        public SoftwareAsset()
        {
            Name = string.Empty;
            Version = string.Empty;
            Manufacturer = string.Empty;
        }

        public SoftwareAsset(string name, string version, string manufacturer)
        {
            Name = name;
            Version = version;
            Manufacturer = manufacturer;
        }

        public override void RetrieveData()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            Name += name.ToString();

            string URL = "https://services.nvd.nist.gov/rest/json/cves/2.0";
            string pubStartDate = DateTime.Now.AddMonths(-3).ToString("yyyy-MM-ddTHH:mm:ss.fff");
            string pubEndDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            string cpeName = "cpe:2.3:o:microsoft:windows_10:1607";
            //string cpeName = "cpe:2.3:o:microsoft:windows_10:1607";
            string cvssV3Severity = "CRITICAL";
            string resultsPerPage = "1";

            string urlParameters = String.Format("?cpeName={0}&cvssV3Severity={1}&resultsPerPage={2}&pubStartDate={3}&pubEndDate={4}", cpeName, cvssV3Severity, resultsPerPage, pubStartDate, pubEndDate);

            HttpClient client = new();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                Manufacturer += dataObjects;
                var object_ = JObject.Parse(dataObjects);
                var vulnerabilities = object_["vulnerabilities"];
                //var references = JObject.Parse(vulnerabilities);

                Manufacturer += System.Environment.NewLine;
                Manufacturer += System.Environment.NewLine;
                Manufacturer += "--------------------------------------------------------------------------------------------------------------";
                Manufacturer += System.Environment.NewLine;
                Manufacturer += System.Environment.NewLine;

                Manufacturer += vulnerabilities;

                Manufacturer += System.Environment.NewLine;
                Manufacturer += System.Environment.NewLine;
                Manufacturer += "--------------------------------------------------------------------------------------------------------------";
                Manufacturer += System.Environment.NewLine;
                Manufacturer += System.Environment.NewLine;

                string vulnerabilityName = vulnerabilities[0]["cve"]["descriptions"][0]["value"].ToString();
                string advisory = vulnerabilities[0]["cve"]["references"][0]["url"].ToString();


                Manufacturer += advisory;
                Manufacturer += System.Environment.NewLine;
                Manufacturer += vulnerabilityName;
                //foreach (var d in dataObjects)
                //{
                //    Manufacturer += d;
                //}
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            client.Dispose();
            Version = Environment.OSVersion.ToString();
        }
    }
}
