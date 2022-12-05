namespace AssetTracker
{
    partial class FindSoftwareAssetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAssetID = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.cbAllAssets = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAssetID
            // 
            this.lbAssetID.AutoSize = true;
            this.lbAssetID.Location = new System.Drawing.Point(12, 78);
            this.lbAssetID.Name = "lbAssetID";
            this.lbAssetID.Size = new System.Drawing.Size(45, 15);
            this.lbAssetID.TabIndex = 12;
            this.lbAssetID.Text = "Version";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(12, 96);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(148, 23);
            this.txtVersion.TabIndex = 11;
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Location = new System.Drawing.Point(12, 34);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(39, 15);
            this.lbIpAddress.TabIndex = 10;
            this.lbIpAddress.Text = "Name";
            // 
            // cbAllAssets
            // 
            this.cbAllAssets.AutoSize = true;
            this.cbAllAssets.Location = new System.Drawing.Point(12, 12);
            this.cbAllAssets.Name = "cbAllAssets";
            this.cbAllAssets.Size = new System.Drawing.Size(76, 19);
            this.cbAllAssets.TabIndex = 9;
            this.cbAllAssets.Text = "All Assets";
            this.cbAllAssets.UseVisualStyleBackColor = true;
            this.cbAllAssets.CheckedChanged += new System.EventHandler(this.cbAllAssets_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 23);
            this.txtName.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 125);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 426);
            this.dataGridView1.TabIndex = 8;
            // 
            // FindSoftwareAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbAssetID);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lbIpAddress);
            this.Controls.Add(this.cbAllAssets);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLoad);
            this.MaximumSize = new System.Drawing.Size(1338, 489);
            this.MinimumSize = new System.Drawing.Size(1338, 489);
            this.Name = "FindSoftwareAssetForm";
            this.Text = "Find Software Asset";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAssetID;
        private TextBox txtVersion;
        private Label lbIpAddress;
        private CheckBox cbAllAssets;
        private TextBox txtName;
        private Button btnLoad;
        private DataGridView dataGridView1;
    }
}