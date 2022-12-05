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
    public partial class UpdateSoftwareAssetForm : Form
    {
        private string name;
        private string version;
        public UpdateSoftwareAssetForm()
        {
            InitializeComponent();
            name = UpdateChooseSoftwareAssetForm.NameText;
            version = UpdateChooseSoftwareAssetForm.VersionText;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
