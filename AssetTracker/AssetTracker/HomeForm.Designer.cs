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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVulnerabilities = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnFindS = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(36, 43);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(91, 30);
            this.btnAddAsset.TabIndex = 2;
            this.btnAddAsset.Text = "Add";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnFindAssets
            // 
            this.btnFindAssets.Location = new System.Drawing.Point(36, 79);
            this.btnFindAssets.Name = "btnFindAssets";
            this.btnFindAssets.Size = new System.Drawing.Size(91, 30);
            this.btnFindAssets.TabIndex = 3;
            this.btnFindAssets.Text = "Find";
            this.btnFindAssets.UseVisualStyleBackColor = true;
            this.btnFindAssets.Click += new System.EventHandler(this.btnFindAssets_Click);
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.Location = new System.Drawing.Point(36, 151);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteAsset.TabIndex = 4;
            this.btnDeleteAsset.Text = "Delete";
            this.btnDeleteAsset.UseVisualStyleBackColor = true;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // btnUpdateAsset
            // 
            this.btnUpdateAsset.Location = new System.Drawing.Point(36, 115);
            this.btnUpdateAsset.Name = "btnUpdateAsset";
            this.btnUpdateAsset.Size = new System.Drawing.Size(91, 30);
            this.btnUpdateAsset.TabIndex = 5;
            this.btnUpdateAsset.Text = "Update";
            this.btnUpdateAsset.UseVisualStyleBackColor = true;
            this.btnUpdateAsset.Click += new System.EventHandler(this.btnUpdateAsset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnLink);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddAsset);
            this.panel1.Controls.Add(this.btnUpdateAsset);
            this.panel1.Controls.Add(this.btnFindAssets);
            this.panel1.Controls.Add(this.btnDeleteAsset);
            this.panel1.Location = new System.Drawing.Point(47, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 242);
            this.panel1.TabIndex = 6;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(36, 187);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(91, 30);
            this.btnLink.TabIndex = 9;
            this.btnLink.Text = "Link";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hardware Assets";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnVulnerabilities);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAddS);
            this.panel2.Controls.Add(this.btnUpdateS);
            this.panel2.Controls.Add(this.btnFindS);
            this.panel2.Controls.Add(this.btnDeleteS);
            this.panel2.Location = new System.Drawing.Point(218, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 242);
            this.panel2.TabIndex = 8;
            // 
            // btnVulnerabilities
            // 
            this.btnVulnerabilities.Location = new System.Drawing.Point(36, 187);
            this.btnVulnerabilities.Name = "btnVulnerabilities";
            this.btnVulnerabilities.Size = new System.Drawing.Size(91, 30);
            this.btnVulnerabilities.TabIndex = 10;
            this.btnVulnerabilities.Text = "Vulnerabilities";
            this.btnVulnerabilities.UseVisualStyleBackColor = true;
            this.btnVulnerabilities.Click += new System.EventHandler(this.btnVulnerabilities_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Software Assets";
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(36, 43);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(91, 30);
            this.btnAddS.TabIndex = 2;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(36, 115);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(91, 30);
            this.btnUpdateS.TabIndex = 5;
            this.btnUpdateS.Text = "Update";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnFindS
            // 
            this.btnFindS.Location = new System.Drawing.Point(36, 79);
            this.btnFindS.Name = "btnFindS";
            this.btnFindS.Size = new System.Drawing.Size(91, 30);
            this.btnFindS.TabIndex = 3;
            this.btnFindS.Text = "Find";
            this.btnFindS.UseVisualStyleBackColor = true;
            this.btnFindS.Click += new System.EventHandler(this.btnFindS_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(36, 151);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteS.TabIndex = 4;
            this.btnDeleteS.Text = "Delete";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(447, 375);
            this.MinimumSize = new System.Drawing.Size(447, 375);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddAsset;
        private Button btnFindAssets;
        private Button btnDeleteAsset;
        private Button btnUpdateAsset;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnAddS;
        private Button btnUpdateS;
        private Button btnFindS;
        private Button btnDeleteS;
        private Button btnLink;
        private Button btnVulnerabilities;
    }
}