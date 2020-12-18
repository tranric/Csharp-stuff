namespace ClassLab3
{
    partial class frmCake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCake));
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.radbtnSpecial = new System.Windows.Forms.RadioButton();
            this.radbtnCustom = new System.Windows.Forms.RadioButton();
            this.imgCake = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpCake = new System.Windows.Forms.GroupBox();
            this.grpNumber = new System.Windows.Forms.GroupBox();
            this.radbtn3Layers = new System.Windows.Forms.RadioButton();
            this.radbtn2Layers = new System.Windows.Forms.RadioButton();
            this.radbtn1Layer = new System.Windows.Forms.RadioButton();
            this.grpCakeSize = new System.Windows.Forms.GroupBox();
            this.radbtn12Inch = new System.Windows.Forms.RadioButton();
            this.radbtn8Inch = new System.Windows.Forms.RadioButton();
            this.radbtn5Inch = new System.Windows.Forms.RadioButton();
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radbtnBanana = new System.Windows.Forms.RadioButton();
            this.radbtnVanila = new System.Windows.Forms.RadioButton();
            this.radbtnChocolate = new System.Windows.Forms.RadioButton();
            this.drpbxSpecialCake = new System.Windows.Forms.ComboBox();
            this.grpOrder.SuspendLayout();
            this.grpInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCake)).BeginInit();
            this.grpCake.SuspendLayout();
            this.grpNumber.SuspendLayout();
            this.grpCakeSize.SuspendLayout();
            this.grpFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblLastName);
            this.grpOrder.Controls.Add(this.lblFirstName);
            this.grpOrder.Controls.Add(this.txtFirstName);
            this.grpOrder.Controls.Add(this.txtLastName);
            this.grpOrder.Controls.Add(this.grpInputs);
            this.grpOrder.Location = new System.Drawing.Point(12, 19);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(372, 81);
            this.grpOrder.TabIndex = 6;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Customer Infomantion";
            this.grpOrder.Enter += new System.EventHandler(this.grpOrder_Enter);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "&Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "&First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(85, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(85, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.radbtnSpecial);
            this.grpInputs.Controls.Add(this.radbtnCustom);
            this.grpInputs.Location = new System.Drawing.Point(201, 17);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(154, 46);
            this.grpInputs.TabIndex = 8;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Type of Cake";
            // 
            // radbtnSpecial
            // 
            this.radbtnSpecial.AutoSize = true;
            this.radbtnSpecial.Checked = true;
            this.radbtnSpecial.Location = new System.Drawing.Point(72, 15);
            this.radbtnSpecial.Name = "radbtnSpecial";
            this.radbtnSpecial.Size = new System.Drawing.Size(60, 17);
            this.radbtnSpecial.TabIndex = 17;
            this.radbtnSpecial.TabStop = true;
            this.radbtnSpecial.Text = "Special";
            this.radbtnSpecial.UseVisualStyleBackColor = true;
            // 
            // radbtnCustom
            // 
            this.radbtnCustom.AutoSize = true;
            this.radbtnCustom.Location = new System.Drawing.Point(6, 15);
            this.radbtnCustom.Name = "radbtnCustom";
            this.radbtnCustom.Size = new System.Drawing.Size(60, 17);
            this.radbtnCustom.TabIndex = 16;
            this.radbtnCustom.Text = "Custom";
            this.radbtnCustom.UseVisualStyleBackColor = true;
            this.radbtnCustom.CheckedChanged += new System.EventHandler(this.radbtnCustom_CheckedChanged);
            // 
            // imgCake
            // 
            this.imgCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgCake.Image = global::ClassLab3.Properties.Resources.Cake;
            this.imgCake.Location = new System.Drawing.Point(413, 123);
            this.imgCake.Name = "imgCake";
            this.imgCake.Size = new System.Drawing.Size(61, 51);
            this.imgCake.TabIndex = 12;
            this.imgCake.TabStop = false;
            this.imgCake.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(413, 19);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 77);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(9, 234);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(109, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Please fill out all fields";
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // grpCake
            // 
            this.grpCake.Controls.Add(this.grpNumber);
            this.grpCake.Controls.Add(this.grpCakeSize);
            this.grpCake.Controls.Add(this.grpFlavour);
            this.grpCake.Enabled = false;
            this.grpCake.Location = new System.Drawing.Point(12, 119);
            this.grpCake.Name = "grpCake";
            this.grpCake.Size = new System.Drawing.Size(372, 109);
            this.grpCake.TabIndex = 11;
            this.grpCake.TabStop = false;
            this.grpCake.Text = "Customer Infomantion";
            // 
            // grpNumber
            // 
            this.grpNumber.Controls.Add(this.radbtn3Layers);
            this.grpNumber.Controls.Add(this.radbtn2Layers);
            this.grpNumber.Controls.Add(this.radbtn1Layer);
            this.grpNumber.Location = new System.Drawing.Point(251, 19);
            this.grpNumber.Name = "grpNumber";
            this.grpNumber.Size = new System.Drawing.Size(104, 84);
            this.grpNumber.TabIndex = 10;
            this.grpNumber.TabStop = false;
            this.grpNumber.Text = "Number of Layers";
            // 
            // radbtn3Layers
            // 
            this.radbtn3Layers.AutoSize = true;
            this.radbtn3Layers.Location = new System.Drawing.Point(6, 61);
            this.radbtn3Layers.Name = "radbtn3Layers";
            this.radbtn3Layers.Size = new System.Drawing.Size(65, 17);
            this.radbtn3Layers.TabIndex = 24;
            this.radbtn3Layers.Text = "3 Layers";
            this.radbtn3Layers.UseVisualStyleBackColor = true;
            // 
            // radbtn2Layers
            // 
            this.radbtn2Layers.AutoSize = true;
            this.radbtn2Layers.Location = new System.Drawing.Point(6, 39);
            this.radbtn2Layers.Name = "radbtn2Layers";
            this.radbtn2Layers.Size = new System.Drawing.Size(65, 17);
            this.radbtn2Layers.TabIndex = 23;
            this.radbtn2Layers.Text = "2 Layers";
            this.radbtn2Layers.UseVisualStyleBackColor = true;
            // 
            // radbtn1Layer
            // 
            this.radbtn1Layer.AutoSize = true;
            this.radbtn1Layer.Checked = true;
            this.radbtn1Layer.Location = new System.Drawing.Point(6, 19);
            this.radbtn1Layer.Name = "radbtn1Layer";
            this.radbtn1Layer.Size = new System.Drawing.Size(60, 17);
            this.radbtn1Layer.TabIndex = 22;
            this.radbtn1Layer.TabStop = true;
            this.radbtn1Layer.Text = "1 Layer";
            this.radbtn1Layer.UseVisualStyleBackColor = true;
            // 
            // grpCakeSize
            // 
            this.grpCakeSize.Controls.Add(this.radbtn12Inch);
            this.grpCakeSize.Controls.Add(this.radbtn8Inch);
            this.grpCakeSize.Controls.Add(this.radbtn5Inch);
            this.grpCakeSize.Location = new System.Drawing.Point(141, 19);
            this.grpCakeSize.Name = "grpCakeSize";
            this.grpCakeSize.Size = new System.Drawing.Size(104, 84);
            this.grpCakeSize.TabIndex = 9;
            this.grpCakeSize.TabStop = false;
            this.grpCakeSize.Text = "Cake Size";
            // 
            // radbtn12Inch
            // 
            this.radbtn12Inch.AutoSize = true;
            this.radbtn12Inch.Location = new System.Drawing.Point(6, 61);
            this.radbtn12Inch.Name = "radbtn12Inch";
            this.radbtn12Inch.Size = new System.Drawing.Size(60, 17);
            this.radbtn12Inch.TabIndex = 21;
            this.radbtn12Inch.Text = "12 inch";
            this.radbtn12Inch.UseVisualStyleBackColor = true;
            // 
            // radbtn8Inch
            // 
            this.radbtn8Inch.AutoSize = true;
            this.radbtn8Inch.Location = new System.Drawing.Point(6, 39);
            this.radbtn8Inch.Name = "radbtn8Inch";
            this.radbtn8Inch.Size = new System.Drawing.Size(54, 17);
            this.radbtn8Inch.TabIndex = 20;
            this.radbtn8Inch.Text = "8 inch";
            this.radbtn8Inch.UseVisualStyleBackColor = true;
            // 
            // radbtn5Inch
            // 
            this.radbtn5Inch.AutoSize = true;
            this.radbtn5Inch.Checked = true;
            this.radbtn5Inch.Location = new System.Drawing.Point(6, 19);
            this.radbtn5Inch.Name = "radbtn5Inch";
            this.radbtn5Inch.Size = new System.Drawing.Size(54, 17);
            this.radbtn5Inch.TabIndex = 19;
            this.radbtn5Inch.TabStop = true;
            this.radbtn5Inch.Text = "5 inch";
            this.radbtn5Inch.UseVisualStyleBackColor = true;
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radbtnBanana);
            this.grpFlavour.Controls.Add(this.radbtnVanila);
            this.grpFlavour.Controls.Add(this.radbtnChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(9, 19);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Size = new System.Drawing.Size(104, 84);
            this.grpFlavour.TabIndex = 8;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radbtnBanana
            // 
            this.radbtnBanana.AutoSize = true;
            this.radbtnBanana.Location = new System.Drawing.Point(6, 61);
            this.radbtnBanana.Name = "radbtnBanana";
            this.radbtnBanana.Size = new System.Drawing.Size(62, 17);
            this.radbtnBanana.TabIndex = 20;
            this.radbtnBanana.Text = "Banana";
            this.radbtnBanana.UseVisualStyleBackColor = true;
            // 
            // radbtnVanila
            // 
            this.radbtnVanila.AutoSize = true;
            this.radbtnVanila.Location = new System.Drawing.Point(6, 39);
            this.radbtnVanila.Name = "radbtnVanila";
            this.radbtnVanila.Size = new System.Drawing.Size(54, 17);
            this.radbtnVanila.TabIndex = 19;
            this.radbtnVanila.Text = "Vanila";
            this.radbtnVanila.UseVisualStyleBackColor = true;
            // 
            // radbtnChocolate
            // 
            this.radbtnChocolate.AutoSize = true;
            this.radbtnChocolate.Checked = true;
            this.radbtnChocolate.Location = new System.Drawing.Point(6, 19);
            this.radbtnChocolate.Name = "radbtnChocolate";
            this.radbtnChocolate.Size = new System.Drawing.Size(73, 17);
            this.radbtnChocolate.TabIndex = 18;
            this.radbtnChocolate.TabStop = true;
            this.radbtnChocolate.Text = "Chocolate";
            this.radbtnChocolate.UseVisualStyleBackColor = true;
            // 
            // drpbxSpecialCake
            // 
            this.drpbxSpecialCake.AccessibleName = "";
            this.drpbxSpecialCake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpbxSpecialCake.FormattingEnabled = true;
            this.drpbxSpecialCake.Items.AddRange(new object[] {
            "Holiday Cake",
            "Birthday Cake ",
            "Super Hero Cake",
            "Wedding Cake"});
            this.drpbxSpecialCake.Location = new System.Drawing.Point(390, 207);
            this.drpbxSpecialCake.Name = "drpbxSpecialCake";
            this.drpbxSpecialCake.Size = new System.Drawing.Size(98, 21);
            this.drpbxSpecialCake.TabIndex = 14;
            this.drpbxSpecialCake.Tag = "";
            this.drpbxSpecialCake.SelectedIndexChanged += new System.EventHandler(this.drpbxSpecialCake_SelectedIndexChanged_1);
            // 
            // frmCake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 253);
            this.Controls.Add(this.drpbxSpecialCake);
            this.Controls.Add(this.grpCake);
            this.Controls.Add(this.imgCake);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCake";
            this.Text = "Cake Order";
            this.Load += new System.EventHandler(this.frmCake_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCake)).EndInit();
            this.grpCake.ResumeLayout(false);
            this.grpNumber.ResumeLayout(false);
            this.grpNumber.PerformLayout();
            this.grpCakeSize.ResumeLayout(false);
            this.grpCakeSize.PerformLayout();
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox imgCake;
        private System.Windows.Forms.RadioButton radbtnSpecial;
        private System.Windows.Forms.RadioButton radbtnCustom;
        private System.Windows.Forms.GroupBox grpCake;
        private System.Windows.Forms.GroupBox grpNumber;
        private System.Windows.Forms.GroupBox grpCakeSize;
        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radbtn3Layers;
        private System.Windows.Forms.RadioButton radbtn2Layers;
        private System.Windows.Forms.RadioButton radbtn1Layer;
        private System.Windows.Forms.RadioButton radbtn12Inch;
        private System.Windows.Forms.RadioButton radbtn8Inch;
        private System.Windows.Forms.RadioButton radbtn5Inch;
        private System.Windows.Forms.RadioButton radbtnBanana;
        private System.Windows.Forms.RadioButton radbtnVanila;
        private System.Windows.Forms.RadioButton radbtnChocolate;
        private System.Windows.Forms.ComboBox drpbxSpecialCake;
    }
}

