namespace AssetTracker2
{
    partial class HomeForm
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
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.btnFindAssets = new System.Windows.Forms.Button();
            this.btnDeleteAsset = new System.Windows.Forms.Button();
            this.btnUpdateAsset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(67, 53);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(91, 30);
            this.btnAddAsset.TabIndex = 2;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnFindAssets
            // 
            this.btnFindAssets.Location = new System.Drawing.Point(67, 89);
            this.btnFindAssets.Name = "btnFindAssets";
            this.btnFindAssets.Size = new System.Drawing.Size(91, 30);
            this.btnFindAssets.TabIndex = 3;
            this.btnFindAssets.Text = "Find Asset(s)";
            this.btnFindAssets.UseVisualStyleBackColor = true;
            this.btnFindAssets.Click += new System.EventHandler(this.btnFindAssets_Click);
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.Location = new System.Drawing.Point(67, 161);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteAsset.TabIndex = 4;
            this.btnDeleteAsset.Text = "Delete Asset";
            this.btnDeleteAsset.UseVisualStyleBackColor = true;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // btnUpdateAsset
            // 
            this.btnUpdateAsset.Location = new System.Drawing.Point(67, 125);
            this.btnUpdateAsset.Name = "btnUpdateAsset";
            this.btnUpdateAsset.Size = new System.Drawing.Size(91, 30);
            this.btnUpdateAsset.TabIndex = 5;
            this.btnUpdateAsset.Text = "Update Asset";
            this.btnUpdateAsset.UseVisualStyleBackColor = true;
            this.btnUpdateAsset.Click += new System.EventHandler(this.btnUpdateAsset_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 263);
            this.Controls.Add(this.btnUpdateAsset);
            this.Controls.Add(this.btnDeleteAsset);
            this.Controls.Add(this.btnFindAssets);
            this.Controls.Add(this.btnAddAsset);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddAsset;
        private Button btnFindAssets;
        private Button btnDeleteAsset;
        private Button btnUpdateAsset;
    }
}