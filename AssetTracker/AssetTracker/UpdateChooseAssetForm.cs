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
    public partial class UpdateChooseAssetForm : Form
    {
        private HardwareAssetDB database;
        private static string ipText = "";
        private static string idText = "";

        public static string IdText { get => idText; set => idText = value; }
        public static string IpText { get => ipText; set => ipText = value; }
        public UpdateChooseAssetForm()
        {
            InitializeComponent();
            database = new HardwareAssetDB();
            IdText = "";
            IpText = "";
        }

        private void txtIPAddress_KeyUp(object sender, KeyEventArgs e)
        {
            IpText = txtIPAddress.Text;

            if (IpText != "")
            {
                txtAssetID.Text = "";
                txtAssetID.Enabled = false;
            }
            else
            {
                txtAssetID.Text = IdText;
                txtAssetID.Enabled = true;
            }
        }

        private void txtAssetID_KeyUp(object sender, KeyEventArgs e)
        {
            IdText = txtAssetID.Text;

            if (IdText != "")
            {
                txtIPAddress.Text = "";
                txtIPAddress.Enabled = false;
            }
            else
            {
                txtIPAddress.Text = IpText;
                txtIPAddress.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAssetForm updateAssetForm = new();
                if (IdText != "")
                {
                    database.Conn.Open();
                    bool exists = database.AssetExistsById(Int32.Parse(IdText));
                    database.Conn.Close();
                    if (exists)
                    {
                        updateAssetForm.ShowDialog();
                    }
                    else
                        MessageBox.Show("Asset " + IdText + " does not exist.");
                }
                else if (IpText != "")
                {
                    database.Conn.Open();
                    bool exists = database.AssetExistsByIp(IpText);
                    database.Conn.Close();
                    if (exists)
                        updateAssetForm.ShowDialog();
                    else
                        MessageBox.Show("Asset " + IpText + " does not exist.");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
