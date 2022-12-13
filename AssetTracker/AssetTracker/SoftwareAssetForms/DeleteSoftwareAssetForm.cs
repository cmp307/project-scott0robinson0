using Classes.Database;
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
    public partial class DeleteSoftwareAssetForm : Form
    {
        private SoftwareAssetDB database;
        public DeleteSoftwareAssetForm()
        {
            InitializeComponent();
            database = new SoftwareAssetDB();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                    throw new Exception("Name is mandatory.");

                if (txtVersion.Text == "")
                    throw new Exception("Version is mandatory.");


                database.Conn.Open();
                int deleted = database.DeleteAsset(txtName.Text, txtVersion.Text);
                database.Conn.Close();
                if (deleted > 0)
                    MessageBox.Show("Deleted asset: " + txtName.Text + ", " + txtVersion.Text);
                else
                    MessageBox.Show("Asset " + txtName.Text + ", " + txtVersion.Text + " did not exist.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
