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
    public partial class RetrieveAssetForm : Form
    {
        DataTable dataTable;
        MySqlDataAdapter adapter;
        public RetrieveAssetForm()
        {
            InitializeComponent();
            this.LoadData();
            //dataTable = new DataTable();
            //adapter = new MySqlDataAdapter();
        }

        private void LoadData()
        {
            try
            {
                dataTable = new DataTable();
                Database database = new Database();
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
    }
}
