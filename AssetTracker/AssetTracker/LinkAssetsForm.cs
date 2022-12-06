using Classes;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssetTracker
{
    public partial class LinkAssetsForm : Form
    {
        private HardwareAssetDB database;
        
        private string ipText = "";
        private string idText = "";

        public LinkAssetsForm()
        {
            InitializeComponent();
            database = new HardwareAssetDB();
            ipText = string.Empty;
            idText = string.Empty;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //UPDATE `SGHARDWAREASSET` SET `softwareassetname` = 'Microsoft Windows 10 Home', `softwareassetversion` = '22H2' WHERE `SGHARDWAREASSET`.`id` = 60
            try
            {
                if (txtHId.Text == "" && txtHIPAddress.Text == "")
                    throw new Exception("IP address or ID are mandatory.");

                if (txtSName.Text == "")
                    throw new Exception("Software asset name is mandatory.");

                if (txtSVersion.Text == "")
                    throw new Exception("Software asset version is mandatory.");

                int updated = 0;
                if (idText != "")
                {
                    database.Conn.Open();
                    string setValues = String.Format("softwareassetname = '{0}', softwareassetversion = '{1}'", txtSName.Text, txtSVersion.Text);
                    string condition = String.Format("SGHARDWAREASSET.id = '{0}'", idText);
                    updated = database.Update("SGHARDWAREASSET", setValues, condition);
                    database.Conn.Close();
                }
                else if (ipText != "")
                {
                    database.Conn.Open();
                    string setValues = String.Format("softwareassetname = '{0}', softwareassetversion = '{1}'", txtSName.Text, txtSVersion.Text);
                    string condition = String.Format("SGHARDWAREASSET.ipaddress = '{0}'", ipText);
                    updated = database.Update("SGHARDWAREASSET", setValues, condition);
                    database.Conn.Close();
                }

                if (updated > 0)
                {
                    MessageBox.Show("Assets successfully linked.");
                    Close();
                }
                else
                    MessageBox.Show("Assets could not be linked.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtHIPAddress_KeyUp(object sender, KeyEventArgs e)
        {
            ipText = txtHIPAddress.Text;

            if (ipText != "")
            {
                txtHId.Text = "";
                txtHId.Enabled = false;
            }
            else
            {
                txtHId.Text = idText;
                txtHId.Enabled = true;
            }
        }

        private void txtHId_KeyUp(object sender, KeyEventArgs e)
        {
            idText = txtHId.Text;

            if (idText != "")
            {
                txtHIPAddress.Text = "";
                txtHIPAddress.Enabled = false;
            }
            else
            {
                txtHIPAddress.Text = ipText;
                txtHIPAddress.Enabled = true;
            }
        }
    }
}
