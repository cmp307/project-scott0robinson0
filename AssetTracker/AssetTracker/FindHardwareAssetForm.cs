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
using MySql.Data.MySqlClient;

namespace AssetTracker
{
    public partial class FindHardwareAssetForm : Form
    {
        private DataTable dataTable;
        private MySqlDataAdapter adapter;
        private HardwareAssetDB database;
        private string idtext;
        private string iptext;

        public FindHardwareAssetForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
            adapter = new MySqlDataAdapter();
            database = new HardwareAssetDB();
            idtext = "";
            iptext = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                database.Conn.Close();
                dataTable.Clear();
                dataTable.Columns.Clear();
                if (cbAllAssets.Checked)
                {                    
                    database.Conn.Open();
                    adapter.SelectCommand = database.SelectAllAssets();
                    database.Conn.Close();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                }
                else if (txtAssetID.Text != "")
                {
                    database.Conn.Open();
                    adapter.SelectCommand = database.SelectAssetById(int.Parse(txtAssetID.Text));
                    database.Conn.Close();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                }
                else if (txtIPAddress.Text != "")
                {
                    database.Conn.Open();
                    adapter.SelectCommand = database.SelectAssetByIp(txtIPAddress.Text);
                    database.Conn.Close();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAllAssets_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllAssets.Checked)
            {
                txtAssetID.Enabled = false;
                txtIPAddress.Enabled = false;
                txtAssetID.Text = "";
                txtIPAddress.Text = "";
            }
            else
            {
                if (iptext == "")
                {
                    txtAssetID.Enabled = true;
                    txtAssetID.Text = idtext;
                }

                if (idtext == "")
                {
                    txtIPAddress.Enabled = true;
                    txtIPAddress.Text = iptext;
                }
            }
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
    }
}
