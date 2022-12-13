using Classes;
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
using Classes.Assets;

namespace AssetTracker
{
    public partial class UpdateSoftwareAssetForm : Form
    {
        private string name;
        private string version;
        public UpdateSoftwareAssetForm()
        {
            InitializeComponent();
            name = UpdateChooseSoftwareAssetForm.NameText;
            version = UpdateChooseSoftwareAssetForm.VersionText;

            SoftwareAssetDB database = new();
            MySqlCommand command;
            MySqlDataReader reader;
            database.Conn.Open();

            command = database.SelectAsset(name, version);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtArchitecture.Text = reader.GetString("Architecture");
                txtManufacturer.Text = reader.GetString("Manufacturer");
                txtName.Text = reader.GetString("Name");
                txtVersion.Text = reader.GetString("Version");
            }

            reader.Close();
            database.Conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                    throw new Exception("Name is mandatory.");

                if (txtVersion.Text == "")
                    throw new Exception("Version is mandatory.");

                if (txtArchitecture.Text == "")
                    throw new Exception("Architecture is mandatory.");

                if (txtManufacturer.Text == "")
                    throw new Exception("Manufacturer is mandatory.");

                SoftwareAssetDB database = new();
                SoftwareAsset softwareAsset = new SoftwareAsset(txtName.Text, txtVersion.Text, txtManufacturer.Text, txtArchitecture.Text);

                int added = 0;
                database.Conn.Open();
                added = database.UpdateAsset(softwareAsset);
                if (added > 0)
                    MessageBox.Show("Asset " + name + ", " + version + " has been updated.");
                else
                    MessageBox.Show("Asset " + name + ", " + version + " could not be updated.");
                database.Conn.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
