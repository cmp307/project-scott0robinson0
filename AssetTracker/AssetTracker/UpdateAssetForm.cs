using Classes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
        private string ip;
        private string id;
        public UpdateAssetForm()
        {
            InitializeComponent();
            PurchaseDate = "";
            ip = UpdateChooseAssetForm.IpText;
            id = UpdateChooseAssetForm.IdText;

            HardwareAssetDB database = new();
            MySqlCommand command;
            MySqlDataReader reader;
            database.Conn.Open();


            if (id != "")
            {
                command = database.SelectAssetById(Int32.Parse(id));
                reader = command.ExecuteReader();
            }
            else
            {
                command = database.SelectAssetByIp(ip);
                reader = command.ExecuteReader();
            }


            while (reader.Read())
            {
                txtIPAddress.Text = reader.GetString("IP Address");
                txtAssetName.Text = reader.GetString("Name");

                if (!reader.IsDBNull("Note"))
                {
                    dtpPurchaseDate.CustomFormat = "yyyy-MM-dd";
                    dtpPurchaseDate.Value = reader.GetDateTime("Purchase Date");
                }

                if (!reader.IsDBNull("Note"))
                    txtNote.Text = reader.GetString("Note");

                txtModel.Text = reader.GetString("Model");
                txtType.Text = reader.GetString("Type");
                txtManufacturer.Text = reader.GetString("Manufacturer");
            }

            reader.Close();
            database.Conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
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

                HardwareAssetDB database = new();
                HardwareAsset hardwareAsset = new(txtAssetName.Text, txtIPAddress.Text, PurchaseDate, txtNote.Text, txtModel.Text, txtType.Text, txtManufacturer.Text);

                int added = 0;
                database.Conn.Open();
                if (id != "")
                {
                    hardwareAsset.Id = Int32.Parse(id);
                    added = database.UpdateAssetById(hardwareAsset);
                    if (added > 0)
                        MessageBox.Show("Asset " + id + " has been updated.");
                }
                else if (ip != "")
                {
                    added = database.UpdateAssetByIp(hardwareAsset);
                    if (added > 0)
                        MessageBox.Show("Asset " + ip + " has been updated.");
                }
                database.Conn.Close();

                if (added == 0)
                    MessageBox.Show("Asset could not be updated.");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            HardwareAssetDB database = new();
            database.Conn.Open();
            MySqlCommand command = database.SelectModelByName(txtModel.Text);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtType.Enabled = false;
                txtManufacturer.Enabled = false;
                txtType.Text = reader.GetString(1);
                txtManufacturer.Text = reader.GetString(2);
            }
            else
            {
                txtType.Enabled = true;
                txtManufacturer.Enabled = true;
            }
            database.Conn.Close();
        }

        private void cbPurchaseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPurchaseDate.Checked)
            {
                dtpPurchaseDate.CustomFormat = "yyyy-MM-dd";
                dtpPurchaseDate.Enabled = true;
                PurchaseDate = dtpPurchaseDate.Value.Date.ToString("yyyy-MM-dd");
            }
            else
            {
                dtpPurchaseDate.CustomFormat = " ";
                dtpPurchaseDate.Enabled = false;
                PurchaseDate = "";
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            HardwareAsset hardwareAsset = new();
            hardwareAsset.RetrieveData();

            txtAssetName.Text = hardwareAsset.Name;
            txtIPAddress.Text = hardwareAsset.IpAddress;
            txtManufacturer.Text = hardwareAsset.Manufacturer;
            txtModel.Text = hardwareAsset.ModelName;
            txtType.Text = hardwareAsset.Type;

            txtModel.Focus();
            ActiveControl = null;
        }

        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            PurchaseDate = dtpPurchaseDate.Value.ToString("yyyy-MM-dd");
        }

        private void UpdateAssetForm_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
