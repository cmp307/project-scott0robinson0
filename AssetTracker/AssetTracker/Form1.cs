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
using MySqlX.XDevAPI.CRUD;

namespace AssetTracker
{
    public partial class Form1 : Form
    {
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
                connection.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
