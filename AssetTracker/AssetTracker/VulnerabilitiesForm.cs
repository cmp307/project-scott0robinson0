using Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssetTracker
{
    public partial class VulnerabilitiesForm : Form
    {
        private string name;
        private string version;
        private string architecture;
        private string manufacturer;
        public VulnerabilitiesForm()
        {
            InitializeComponent();
            name = VulnerabilitiesChooseSoftwareAssetForm.NameText;
            version = VulnerabilitiesChooseSoftwareAssetForm.VersionText;
            architecture = "";
            manufacturer = "";

            SoftwareAssetDB database = new();
            MySqlCommand command;
            MySqlDataReader reader;
            database.Conn.Open();

            command = database.SelectAsset(name, version);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                architecture = reader.GetString("Architecture");
                manufacturer = reader.GetString("Manufacturer");
                name = reader.GetString("Name");
                version = reader.GetString("Version");
            }

            reader.Close();
            database.Conn.Close();

            SoftwareAsset softwareAsset = new SoftwareAsset(name, version, manufacturer, architecture);
            List<Vulnerability> vulnerabilities = Vulnerability.CheckOperatingSystem(softwareAsset);

            lblId.Text = vulnerabilities[0].Id;
            lblName.Text = vulnerabilities[0].Name;
            lblPublishDate.Text = vulnerabilities[0].Published;
            lblSeverity.Text = vulnerabilities[0].Severity_.ToString();
            lblURL.Text = vulnerabilities[0].Url;

            lblId2.Text = vulnerabilities[1].Id;
            lblName2.Text = vulnerabilities[1].Name;
            lblPublishDate2.Text = vulnerabilities[1].Published;
            lblSeverity2.Text = vulnerabilities[1].Severity_.ToString();
            lblURL2.Text = vulnerabilities[1].Url;

            lblId3.Text = vulnerabilities[2].Id;
            lblName3.Text = vulnerabilities[2].Name;
            lblPublishDate3.Text = vulnerabilities[2].Published;
            lblSeverity3.Text = vulnerabilities[2].Severity_.ToString();
            lblURL3.Text = vulnerabilities[2].Url;
        }

        private void lblURL_Click(object sender, EventArgs e)
        {
            lblURL.LinkVisited = true;

            Process.Start(new ProcessStartInfo { FileName = lblURL.Text, UseShellExecute = true });
        }

        private void lblURL2_Click(object sender, EventArgs e)
        {
            lblURL2.LinkVisited = true;

            Process.Start(new ProcessStartInfo { FileName = lblURL2.Text, UseShellExecute = true });
        }

        private void lblURL3_Click(object sender, EventArgs e)
        {
            lblURL3.LinkVisited = true;

            Process.Start(new ProcessStartInfo { FileName = lblURL3.Text, UseShellExecute = true });
        }
    }
}
