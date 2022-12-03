using Classes;
using MySql.Data.MySqlClient;

namespace AssetTracker2
{
    public partial class AddHardwareAssetForm : Form
    {
        private string PurchaseDate;
        public AddHardwareAssetForm()
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
                HardwareAsset hardwareAsset = new(txtAssetName.Text, txtIPAddress.Text, PurchaseDate, txtNote.Text, txtModel.Text, txtType.Text, txtManufacturer.Text);
                database.Conn.Open();
                database.AddAsset(hardwareAsset);
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
            ActiveControl = null;
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
    }
}
