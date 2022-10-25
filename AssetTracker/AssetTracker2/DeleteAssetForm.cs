using Classes;
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
    public partial class DeleteAssetForm : Form
    {
        private Database database;
        private string idtext;
        private string iptext;

        public DeleteAssetForm()
        {
            InitializeComponent();
            database = new Database();
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
                    database.DeleteAssetById(int.Parse(idtext));
                    database.Conn.Close();
                    //MessageBox.Show("Asset " + idtext + " deleted.");
                }
                else if (iptext != "")
                {
                    database.Conn.Open();
                    database.DeleteAssetByIp(iptext);
                    database.Conn.Close();
                    //MessageBox.Show("Asset " + iptext + " deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }
    }
}
