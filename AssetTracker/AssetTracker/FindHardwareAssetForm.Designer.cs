namespace AssetTracker
{
    partial class FindHardwareAssetForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.cbAllAssets = new System.Windows.Forms.CheckBox();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.lbAssetID = new System.Windows.Forms.Label();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 125);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(12, 52);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(148, 23);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIPAddress_KeyUp);
            // 
            // cbAllAssets
            // 
            this.cbAllAssets.AutoSize = true;
            this.cbAllAssets.Location = new System.Drawing.Point(12, 12);
            this.cbAllAssets.Name = "cbAllAssets";
            this.cbAllAssets.Size = new System.Drawing.Size(76, 19);
            this.cbAllAssets.TabIndex = 3;
            this.cbAllAssets.Text = "All Assets";
            this.cbAllAssets.UseVisualStyleBackColor = true;
            this.cbAllAssets.CheckedChanged += new System.EventHandler(this.cbAllAssets_CheckedChanged);
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Location = new System.Drawing.Point(12, 34);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(62, 15);
            this.lbIpAddress.TabIndex = 4;
            this.lbIpAddress.Text = "IP Address";
            // 
            // lbAssetID
            // 
            this.lbAssetID.AutoSize = true;
            this.lbAssetID.Location = new System.Drawing.Point(12, 78);
            this.lbAssetID.Name = "lbAssetID";
            this.lbAssetID.Size = new System.Drawing.Size(49, 15);
            this.lbAssetID.TabIndex = 6;
            this.lbAssetID.Text = "Asset ID";
            // 
            // txtAssetID
            // 
            this.txtAssetID.Location = new System.Drawing.Point(12, 96);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.Size = new System.Drawing.Size(148, 23);
            this.txtAssetID.TabIndex = 5;
            this.txtAssetID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAssetID_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 426);
            this.dataGridView1.TabIndex = 7;
            // 
            // FindHardwareAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbAssetID);
            this.Controls.Add(this.txtAssetID);
            this.Controls.Add(this.lbIpAddress);
            this.Controls.Add(this.cbAllAssets);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.btnLoad);
            this.MaximumSize = new System.Drawing.Size(1337, 489);
            this.MinimumSize = new System.Drawing.Size(1337, 489);
            this.Name = "FindHardwareAssetForm";
            this.Text = "Find Hardware Asset";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private TextBox txtIPAddress;
        private CheckBox cbAllAssets;
        private Label lbIpAddress;
        private Label lbAssetID;
        private TextBox txtAssetID;
        private DataGridView dataGridView1;
    }
}