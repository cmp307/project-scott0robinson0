using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Internal;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using MySql.Data.MySqlClient;
using System.Management;

namespace AssetTracker2
{
    public partial class AddAssetForm : Form
    {
        private string PurchaseDate;
        public AddAssetForm()
        {
            InitializeComponent();
            PurchaseDate = "";
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

        private void AddAssetForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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
            txtAssetName.Text = Environment.MachineName;
            txtIPAddress.Text = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
            //txtIPAddress.Text = new HttpClient().GetStringAsync("http://icanhazip.com").Result; PUBLIC IP

            // https://stackoverflow.com/questions/26253423/get-system-information-using-c-sharp
            System.Management.SelectQuery query = new System.Management.SelectQuery("Select * from Win32_ComputerSystem");

            using (System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query))
            {
                foreach (System.Management.ManagementObject process in searcher.Get())
                {
                    process.Get();
                    txtManufacturer.Text = process["Manufacturer"].ToString();
                    txtModel.Text = process["Model"].ToString();
                    txtType.Text = process["SystemType"].ToString();
                }
            }
            txtModel.Focus();
            this.ActiveControl = null;
        }
    }
}
