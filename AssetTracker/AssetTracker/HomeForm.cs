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
            AddAssetForm addAssetForm = new();
            addAssetForm.ShowDialog();
        }

        private void btnFindAssets_Click(object sender, EventArgs e)
        {
            FindAssetForm retrieveAssetForm = new();
            retrieveAssetForm.ShowDialog();
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            DeleteAssetForm deleteAssetForm = new();
            deleteAssetForm.ShowDialog();
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            UpdateChooseAssetForm updateChooseAssetForm = new();
            updateChooseAssetForm.ShowDialog();
        }
    }
}
