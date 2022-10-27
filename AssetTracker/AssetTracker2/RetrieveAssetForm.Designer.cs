namespace AssetTracker
{
    partial class RetrieveAssetForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbAllAssets = new System.Windows.Forms.CheckBox();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.lbAssetID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 23);
            this.textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(166, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 426);
            this.dataGridView1.TabIndex = 7;
            // 
            // RetrieveAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbAssetID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbIpAddress);
            this.Controls.Add(this.cbAllAssets);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoad);
            this.Name = "RetrieveAssetForm";
            this.Text = "Find Asset";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private TextBox textBox1;
        private CheckBox cbAllAssets;
        private Label lbIpAddress;
        private Label lbAssetID;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}