using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using MySql.Data.MySqlClient;

namespace AssetTracker
{
    public partial class AddAssetForm : Form
    {        
        public AddAssetForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (AssetDB.ModelExists(txtModel.Text)) {
                    AssetDB.AddAsset(txtAssetName.Text, txtIPAddress.Text, dtpPurchaseDate.Text, txtNote.Text, txtModel.Text);
                }
                else
                {
                    AssetDB.AddAsset(txtAssetName.Text, txtIPAddress.Text, dtpPurchaseDate.Text, txtNote.Text, txtModel.Text, txtType.Text, txtManufacturer.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (AssetDB.ModelExists(txtModel.Text))
            {
                txtType.Enabled = false;
                txtManufacturer.Enabled = false;
            }
            else
            {
                txtType.Enabled = true;
                txtManufacturer.Enabled = true;
            }
        }

        private void txtIPAddress_TextChanged(object sender, EventArgs e)
        {
            if (GeneralDB.KeyExists("sgasset", "ipaddress", txtIPAddress.Text))
            {
                txtAssetName.Enabled = false;
                dtpPurchaseDate.Enabled = false;
                txtNote.Enabled = false;
                txtModel.Enabled = false;
                txtType.Enabled = false;
                txtManufacturer.Enabled = false;
            }
            else
            {
                txtAssetName.Enabled = true;
                dtpPurchaseDate.Enabled = true;
                txtNote.Enabled = true;
                txtModel.Enabled = true;
                txtType.Enabled = true;
                txtManufacturer.Enabled = true;
            }
        }
    }
}
