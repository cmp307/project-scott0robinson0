using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

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

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            SoftwareAsset softwareAsset = new();
            softwareAsset.RetrieveData();

            txtName.Text = softwareAsset.Name;
            txtVersion.Text = softwareAsset.Version;
            //txtManufacturer.Text = softwareAsset.Manufacturer;
            txtTest.Text = softwareAsset.Manufacturer;
        }
    }
}
