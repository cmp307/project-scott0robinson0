using MySql.Data.MySqlClient;
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
using AssetTracker;

namespace AssetTracker2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            AddHardwareAssetForm addAssetForm = new();
            addAssetForm.ShowDialog();
        }

        private void btnFindAssets_Click(object sender, EventArgs e)
        {
            FindHardwareAssetForm retrieveAssetForm = new();
            retrieveAssetForm.ShowDialog();
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            DeleteHardwareAssetForm deleteAssetForm = new();
            deleteAssetForm.ShowDialog();
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            UpdateHardwareChooseAssetForm updateChooseAssetForm = new();
            updateChooseAssetForm.ShowDialog();
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            AddSoftwareAssetForm addSoftwareAssetForm = new();
            addSoftwareAssetForm.ShowDialog();
        }

        private void btnFindS_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {

        }
    }
}
