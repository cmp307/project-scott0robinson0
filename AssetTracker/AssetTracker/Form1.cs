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
    public partial class Form1 : Form
    {
        Connection connection = new Connection();
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            connection.Connect();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Conn.Open();
                command = new MySqlCommand("SELECT * FROM item", connection.Conn);
                command.ExecuteNonQuery();
                dataTable = new DataTable();
                adapter = new MySqlDataAdapter(command);
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
