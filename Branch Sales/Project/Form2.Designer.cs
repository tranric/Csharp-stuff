namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.picCity = new System.Windows.Forms.PictureBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCityAdd = new System.Windows.Forms.Label();
            this.lblStreetAdd = new System.Windows.Forms.Label();
            this.lblPostalAdd = new System.Windows.Forms.Label();
            this.lblPhoneAdd = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAmountWarning = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.browseToolStripMenuItem.Text = "Browse ...";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cmbCities
            // 
            this.cmbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Items.AddRange(new object[] {
            "Brampton",
            "Hamilton",
            "Mississauga",
            "Oakville",
            "Toronto",
            "Cakeville"});
            this.cmbCities.Location = new System.Drawing.Point(12, 27);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(187, 28);
            this.cmbCities.TabIndex = 0;
            this.cmbCities.SelectedIndexChanged += new System.EventHandler(this.cmbCities_SelectedIndexChanged);
            // 
            // picCity
            // 
            this.picCity.Location = new System.Drawing.Point(228, 27);
            this.picCity.Name = "picCity";
            this.picCity.Size = new System.Drawing.Size(186, 148);
            this.picCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCity.TabIndex = 2;
            this.picCity.TabStop = false;
            this.picCity.Click += new System.EventHandler(this.picCity_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 78);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(12, 98);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 20);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street:";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(12, 118);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(57, 20);
            this.lblPostal.TabIndex = 5;
            this.lblPostal.Text = "Postal:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 138);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // lblCityAdd
            // 
            this.lblCityAdd.AutoSize = true;
            this.lblCityAdd.Location = new System.Drawing.Point(79, 78);
            this.lblCityAdd.Name = "lblCityAdd";
            this.lblCityAdd.Size = new System.Drawing.Size(120, 20);
            this.lblCityAdd.TabIndex = 7;
            this.lblCityAdd.Text = "[text listed here]";
            // 
            // lblStreetAdd
            // 
            this.lblStreetAdd.AutoSize = true;
            this.lblStreetAdd.Location = new System.Drawing.Point(79, 98);
            this.lblStreetAdd.Name = "lblStreetAdd";
            this.lblStreetAdd.Size = new System.Drawing.Size(120, 20);
            this.lblStreetAdd.TabIndex = 8;
            this.lblStreetAdd.Text = "[text listed here]";
            // 
            // lblPostalAdd
            // 
            this.lblPostalAdd.AutoSize = true;
            this.lblPostalAdd.Location = new System.Drawing.Point(79, 118);
            this.lblPostalAdd.Name = "lblPostalAdd";
            this.lblPostalAdd.Size = new System.Drawing.Size(120, 20);
            this.lblPostalAdd.TabIndex = 9;
            this.lblPostalAdd.Text = "[text listed here]";
            // 
            // lblPhoneAdd
            // 
            this.lblPhoneAdd.AutoSize = true;
            this.lblPhoneAdd.Location = new System.Drawing.Point(79, 138);
            this.lblPhoneAdd.Name = "lblPhoneAdd";
            this.lblPhoneAdd.Size = new System.Drawing.Size(120, 20);
            this.lblPhoneAdd.TabIndex = 10;
            this.lblPhoneAdd.Text = "[text listed here]";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 195);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(109, 189);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(161, 26);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(83, 229);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(98, 32);
            this.btnAccept.TabIndex = 13;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 32);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAmountWarning
            // 
            this.lblAmountWarning.AutoSize = true;
            this.lblAmountWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAmountWarning.Location = new System.Drawing.Point(276, 192);
            this.lblAmountWarning.Name = "lblAmountWarning";
            this.lblAmountWarning.Size = new System.Drawing.Size(139, 20);
            this.lblAmountWarning.TabIndex = 15;
            this.lblAmountWarning.Text = "Please enter value";
            this.lblAmountWarning.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 273);
            this.Controls.Add(this.lblAmountWarning);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPhoneAdd);
            this.Controls.Add(this.lblPostalAdd);
            this.Controls.Add(this.lblStreetAdd);
            this.Controls.Add(this.lblCityAdd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.picCity);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Branches";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.PictureBox picCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCityAdd;
        private System.Windows.Forms.Label lblStreetAdd;
        private System.Windows.Forms.Label lblPostalAdd;
        private System.Windows.Forms.Label lblPhoneAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAmountWarning;
    }
}