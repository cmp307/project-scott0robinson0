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
        DataTable dataTable;
        MySqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            try
            {
                //CRUD.Insert("user_", "firstname, lastname, username, email, password", "'first1', 'last1', 'username1', 'email1', 'password1'");
                //CRUD.DeleteRowByPK("user_", "userid = 36");
                //CRUD.UpdateRowByPK("user_", "firstname = 'new name'", "userid = 37");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable = new DataTable();
                adapter = new MySqlDataAdapter(CRUD.SelectAllFromTable("user_"));
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
