using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using MySql.Data.MySqlClient;

namespace AssetTracker
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Database.ModelExists(txtModel.Text))
            //    {

            //        Database.AddAsset(txtAssetName.Text, txtIPAddress.Text, dtpPurchaseDate.Text, txtNote.Text, txtModel.Text);
            //    }
            //    else
            //    {
            //        Database.AddAsset(txtAssetName.Text, txtIPAddress.Text, dtpPurchaseDate.Text, txtNote.Text, txtModel.Text, txtType.Text, txtManufacturer.Text);
            //    }
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtModel_Leave(object sender, EventArgs e)
        {
            //Connection connection = new Connection();
            //connection.Connect();
            //connection.Conn.Open();
            //MySqlCommand command = Database.SelectModelByName(txtModel.Text, connection);
            //MySqlDataReader reader = command.ExecuteReader();
            //if (reader.Read())
            //{
            //    txtType.Enabled = false;
            //    txtManufacturer.Enabled = false;
            //    txtType.Text = reader.GetString(1);
            //    txtManufacturer.Text = reader.GetString(2);
            //}
            //else
            //{
            //    txtType.Enabled = true;
            //    txtManufacturer.Enabled = true;
            //}
            //connection.Conn.Close();
        }

        private void AddAssetForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
