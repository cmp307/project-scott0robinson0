namespace AssetTracker
{
    partial class LinkAssetsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHId = new System.Windows.Forms.TextBox();
            this.lblHId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtHIPAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHId);
            this.panel1.Controls.Add(this.lblHId);
            this.panel1.Location = new System.Drawing.Point(45, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtHIPAddress
            // 
            this.txtHIPAddress.Location = new System.Drawing.Point(79, 66);
            this.txtHIPAddress.Name = "txtHIPAddress";
            this.txtHIPAddress.Size = new System.Drawing.Size(188, 23);
            this.txtHIPAddress.TabIndex = 4;
            this.txtHIPAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHIPAddress_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hardware Asset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP Address";
            // 
            // txtHId
            // 
            this.txtHId.Location = new System.Drawing.Point(79, 37);
            this.txtHId.Name = "txtHId";
            this.txtHId.Size = new System.Drawing.Size(188, 23);
            this.txtHId.TabIndex = 2;
            this.txtHId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHId_KeyUp);
            // 
            // lblHId
            // 
            this.lblHId.AutoSize = true;
            this.lblHId.Location = new System.Drawing.Point(55, 40);
            this.lblHId.Name = "lblHId";
            this.lblHId.Size = new System.Drawing.Size(18, 15);
            this.lblHId.TabIndex = 1;
            this.lblHId.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtSVersion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(336, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 100);
            this.panel2.TabIndex = 5;
            // 
            // txtSVersion
            // 
            this.txtSVersion.Location = new System.Drawing.Point(79, 66);
            this.txtSVersion.Name = "txtSVersion";
            this.txtSVersion.Size = new System.Drawing.Size(188, 23);
            this.txtSVersion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Software Asset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Version";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(79, 37);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(188, 23);
            this.txtSName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(45, 151);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(576, 32);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // LinkAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 230);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(694, 269);
            this.MinimumSize = new System.Drawing.Size(694, 269);
            this.Name = "LinkAssetsForm";
            this.Text = "Link Assets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtHIPAddress;
        private Label label1;
        private Label label2;
        private TextBox txtHId;
        private Label lblHId;
        private Panel panel2;
        private TextBox txtSVersion;
        private Label label3;
        private Label label4;
        private TextBox txtSName;
        private Label label5;
        private Button btnConfirm;
    }
}