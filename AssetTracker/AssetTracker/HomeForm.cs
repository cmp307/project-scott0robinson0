using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Classes;

namespace AssetTracker
{
    public partial class HomeForm : Form
    {
        DataTable dataTable;
        MySqlDataAdapter adapter;
        public HomeForm()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void LoadData()
        {
            try
            {
                Database database = new Database();
                dataTable = new DataTable();

                database.Connect();
                database.Conn.Open();
                adapter = new MySqlDataAdapter(database.SelectAllAssets());
                database.Conn.Close();

                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            AddAssetForm addAssetForm = new AddAssetForm();
            addAssetForm.ShowDialog();
            this.LoadData();
        }
    }
}
