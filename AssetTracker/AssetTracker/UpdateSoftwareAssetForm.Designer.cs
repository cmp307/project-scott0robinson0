namespace AssetTracker
{
    partial class UpdateSoftwareAssetForm
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
            this.txtArchitecture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArchitecture
            // 
            this.txtArchitecture.Location = new System.Drawing.Point(104, 87);
            this.txtArchitecture.Name = "txtArchitecture";
            this.txtArchitecture.Size = new System.Drawing.Size(233, 23);
            this.txtArchitecture.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Architecture";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(104, 145);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(233, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Enabled = false;
            this.txtVersion.Location = new System.Drawing.Point(104, 58);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(233, 23);
            this.txtVersion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Version";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(104, 116);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(233, 23);
            this.txtManufacturer.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Manufacturer";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(104, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 23);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // UpdateSoftwareAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 196);
            this.Controls.Add(this.txtArchitecture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSoftwareAssetForm";
            this.Text = "Update Software Asset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtArchitecture;
        private Label label4;
        private Button btnSubmit;
        private TextBox txtVersion;
        private Label label3;
        private TextBox txtManufacturer;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}