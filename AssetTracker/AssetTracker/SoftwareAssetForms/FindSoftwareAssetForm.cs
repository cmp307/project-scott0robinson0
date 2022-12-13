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
    public partial class FindSoftwareAssetForm : Form
    {
        private DataTable dataTable;
        private MySqlDataAdapter adapter;
        private SoftwareAssetDB database;
        private string nametext;
        private string versiontext;
        public FindSoftwareAssetForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
            adapter = new MySqlDataAdapter();
            database = new SoftwareAssetDB();
            nametext = "";
            versiontext = "";
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
                else if (txtName.Text != "" && txtVersion.Text == "")
                {
                    database.Conn.Open();
                    adapter.SelectCommand = database.SelectAsset(name: txtName.Text);
                    database.Conn.Close();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                }
                else if (txtName.Text == "" && txtVersion.Text != "")
                {
                    database.Conn.Open();
                    adapter.SelectCommand = database.SelectAsset(version: txtVersion.Text);
                    database.Conn.Close();

                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable.DefaultView;
                }
                else if (txtName.Text != "" && txtVersion.Text != "")
                {
                    database.Conn.Open();
                    adapter.SelectCommand = database.SelectAsset(txtName.Text, txtVersion.Text);
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
                txtName.Enabled = false;
                txtVersion.Enabled = false;
                nametext = txtName.Text;
                versiontext = txtVersion.Text;
                txtName.Text = "";
                txtVersion.Text = "";
            }
            else
            {
                txtName.Enabled = true;
                txtName.Text = nametext;
                txtVersion.Enabled = true;
                txtVersion.Text = versiontext;
            }
        }
    }
}
