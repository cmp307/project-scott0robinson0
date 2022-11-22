namespace AssetTracker2
{
    partial class AddAssetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPurchaseDate = new System.Windows.Forms.CheckBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Location = new System.Drawing.Point(43, 77);
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(191, 23);
            this.txtAssetName.TabIndex = 1;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(43, 121);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(191, 23);
            this.txtIPAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchase Date";
            // 
            // cbPurchaseDate
            // 
            this.cbPurchaseDate.AutoSize = true;
            this.cbPurchaseDate.Location = new System.Drawing.Point(43, 165);
            this.cbPurchaseDate.Name = "cbPurchaseDate";
            this.cbPurchaseDate.Size = new System.Drawing.Size(15, 14);
            this.cbPurchaseDate.TabIndex = 6;
            this.cbPurchaseDate.UseVisualStyleBackColor = true;
            this.cbPurchaseDate.CheckedChanged += new System.EventHandler(this.cbPurchaseDate_CheckedChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(43, 229);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(191, 57);
            this.txtNote.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(43, 351);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(191, 23);
            this.txtType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(43, 395);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(191, 23);
            this.txtManufacturer.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Manufacturer";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(43, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(191, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CustomFormat = " ";
            this.dtpPurchaseDate.Enabled = false;
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(43, 185);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(191, 23);
            this.dtpPurchaseDate.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(43, 307);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(191, 23);
            this.txtModel.TabIndex = 16;
            this.txtModel.Leave += new System.EventHandler(this.txtModel_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(234, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(234, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(234, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(234, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(234, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "*";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(43, 35);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(191, 23);
            this.btnLoadData.TabIndex = 22;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // AddAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 487);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPurchaseDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAssetName);
            this.Controls.Add(this.label1);
            this.Name = "AddAssetForm";
            this.Text = "Add Asset";
            this.Click += new System.EventHandler(this.AddAssetForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAssetName;
        private TextBox txtIPAddress;
        private Label label2;
        private Label label3;
        private CheckBox cbPurchaseDate;
        private TextBox txtNote;
        private Label label4;
        private TextBox txtType;
        private Label label5;
        private TextBox txtManufacturer;
        private Label label6;
        private Button btnSubmit;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtModel;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnLoadData;
    }
}