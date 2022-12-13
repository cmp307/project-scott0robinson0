using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Assets;
using Classes.Database;
using MySqlX.XDevAPI;

namespace AssetTracker
{
    public partial class AddSoftwareAssetForm : Form
    {
        public AddSoftwareAssetForm()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                    throw new Exception("Name is mandatory.");

                if (txtVersion.Text == "")
                    throw new Exception("Version name is mandatory.");

                if (txtArchitecture.Text == "")
                    throw new Exception("Architecture is mandatory.");

                if (txtManufacturer.Text == "")
                    throw new Exception("Manufacturer is mandatory.");

                SoftwareAssetDB database = new();
                SoftwareAsset softwareAsset = new(txtName.Text, txtVersion.Text, txtManufacturer.Text, txtArchitecture.Text);

                database.Conn.Open();
                database.AddAsset(softwareAsset);
                database.Conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            SoftwareAsset softwareAsset = new();
            softwareAsset.RetrieveData();

            txtName.Text = softwareAsset.Name;
            txtVersion.Text = softwareAsset.Version;
            txtManufacturer.Text = softwareAsset.Manufacturer;
            txtArchitecture.Text = softwareAsset.Architecture;
        }
    }
}
