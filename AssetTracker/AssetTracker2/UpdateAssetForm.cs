using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetTracker
{
    public partial class UpdateAssetForm : Form
    {
        private string PurchaseDate;
        private Database database;

        public UpdateAssetForm()
        {
            InitializeComponent();
            database = new Database();
            PurchaseDate = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAssetID.Text == "")
                    throw new Exception("Asset ID is mandatory.");

                if (txtAssetName.Text == "")
                    throw new Exception("Asset name is mandatory.");

                if (txtIPAddress.Text == "")
                    throw new Exception("IP address is mandatory.");

                if (txtModel.Text == "")
                    throw new Exception("Model is mandatory.");

                if (txtType.Text == "")
                    throw new Exception("Type is mandatory.");

                if (txtManufacturer.Text == "")
                    throw new Exception("Manufacturer is mandatory.");

                
                database.Conn.Open();
                if (database.ModelExists(txtModel.Text))
                    if (dtpPurchaseDate.Enabled)
                        database.AddAsset(txtAssetName.Text, txtIPAddress.Text, PurchaseDate, txtNote.Text, txtModel.Text);
                    else
                        database.AddAsset(txtAssetName.Text, txtIPAddress.Text, txtNote.Text, txtModel.Text);
                else
                    if (dtpPurchaseDate.Enabled)
                    database.AddAsset(txtAssetName.Text, txtIPAddress.Text, PurchaseDate, txtNote.Text, txtModel.Text, txtType.Text, txtManufacturer.Text);
                else
                    database.AddAsset(txtAssetName.Text, txtIPAddress.Text, txtNote.Text, txtModel.Text, txtType.Text, txtManufacturer.Text);
                database.Conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
