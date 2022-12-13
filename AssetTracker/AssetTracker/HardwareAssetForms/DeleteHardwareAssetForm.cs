using Classes.Database;
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

namespace AssetTracker
{
    public partial class DeleteHardwareAssetForm : Form
    {
        private HardwareAssetDB database;
        private string idtext;
        private string iptext;

        public DeleteHardwareAssetForm()
        {
            InitializeComponent();
            database = new HardwareAssetDB();
            idtext = "";
            iptext = "";
        }

        private void txtIPAddress_KeyUp(object sender, KeyEventArgs e)
        {
            iptext = txtIPAddress.Text;

            if (iptext != "")
            {
                txtAssetID.Text = "";
                txtAssetID.Enabled = false;
            }
            else
            {
                txtAssetID.Text = idtext;
                txtAssetID.Enabled = true;
            } 
        }

        private void txtAssetID_KeyUp(object sender, KeyEventArgs e)
        {
            idtext = txtAssetID.Text;

            if (idtext != "")
            {
                txtIPAddress.Text = "";
                txtIPAddress.Enabled = false;
            }
            else
            {
                txtIPAddress.Text = iptext;
                txtIPAddress.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //database.Conn.Close();
            try
            {
                if (idtext != "")
                {
                    database.Conn.Open();
                    int deleted = database.DeleteAssetById(int.Parse(idtext));
                    database.Conn.Close();
                    if (deleted > 0)
                        MessageBox.Show("Deleted asset: " + idtext);
                    else
                        MessageBox.Show("Asset " + idtext + " did not exist.");
                }
                else if (iptext != "")
                {
                    database.Conn.Open();
                    int deleted = database.DeleteAssetByIp(iptext);
                    database.Conn.Close();
                    if (deleted > 0)
                        MessageBox.Show("Deleted asset: " + iptext);
                    else
                        MessageBox.Show("Asset " + iptext + " did not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
}
