using Classes;
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
    public partial class VulnerabilitiesChooseSoftwareAssetForm : Form
    {
        private SoftwareAssetDB database;
        private static string nameText = "";
        private static string versionText = "";

        public static string NameText { get => nameText; set => nameText = value; }
        public static string VersionText { get => versionText; set => versionText = value; }

        public VulnerabilitiesChooseSoftwareAssetForm()
        {
            InitializeComponent();
            database = new SoftwareAssetDB();
            NameText = "";
            VersionText = "";

            txtName.Text = "microsoft windows 10 home";
            txtVersion.Text = "22h2";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                    throw new Exception("Asset name is mandatory.");

                if (txtVersion.Text == "")
                    throw new Exception("Asset version is mandatory.");

                NameText = txtName.Text;
                VersionText = txtVersion.Text;

                VulnerabilitiesForm vulnerabilitiesForm = new();
                database.Conn.Open();
                bool exists = database.AssetExists(NameText, VersionText);
                database.Conn.Close();
                if (exists)
                {
                    vulnerabilitiesForm.ShowDialog();
                }
                else
                    MessageBox.Show("Asset " + NameText + ", " + VersionText + " does not exist.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
