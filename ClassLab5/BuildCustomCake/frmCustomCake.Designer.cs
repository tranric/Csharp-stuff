namespace BuildCustomCake
{
    partial class frmCustomCake
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
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.grpCustomCake = new System.Windows.Forms.GroupBox();
            this.grpNumLayers = new System.Windows.Forms.GroupBox();
            this.rad3layers = new System.Windows.Forms.RadioButton();
            this.rad2layers = new System.Windows.Forms.RadioButton();
            this.rad1layer = new System.Windows.Forms.RadioButton();
            this.grpDiameter = new System.Windows.Forms.GroupBox();
            this.rad12inch = new System.Windows.Forms.RadioButton();
            this.rad8inch = new System.Windows.Forms.RadioButton();
            this.rad5inch = new System.Windows.Forms.RadioButton();
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutOrder = new System.Windows.Forms.Label();
            this.grpCustInfo.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.grpNumLayers.SuspendLayout();
            this.grpDiameter.SuspendLayout();
            this.grpFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.Controls.Add(this.txtLName);
            this.grpCustInfo.Controls.Add(this.lblLName);
            this.grpCustInfo.Controls.Add(this.txtFName);
            this.grpCustInfo.Controls.Add(this.lblFName);
            this.grpCustInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Size = new System.Drawing.Size(404, 62);
            this.grpCustInfo.TabIndex = 0;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer Information";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(273, 27);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 3;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(206, 27);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "&Last Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(72, 27);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(6, 27);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "&First Name:";
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Controls.Add(this.grpNumLayers);
            this.grpCustomCake.Controls.Add(this.grpDiameter);
            this.grpCustomCake.Controls.Add(this.grpFlavour);
            this.grpCustomCake.Location = new System.Drawing.Point(12, 95);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Size = new System.Drawing.Size(404, 144);
            this.grpCustomCake.TabIndex = 1;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custome Cake";
            // 
            // grpNumLayers
            // 
            this.grpNumLayers.Controls.Add(this.rad3layers);
            this.grpNumLayers.Controls.Add(this.rad2layers);
            this.grpNumLayers.Controls.Add(this.rad1layer);
            this.grpNumLayers.Location = new System.Drawing.Point(273, 30);
            this.grpNumLayers.Name = "grpNumLayers";
            this.grpNumLayers.Size = new System.Drawing.Size(119, 100);
            this.grpNumLayers.TabIndex = 4;
            this.grpNumLayers.TabStop = false;
            this.grpNumLayers.Text = "Number of Layers";
            // 
            // rad3layers
            // 
            this.rad3layers.AutoSize = true;
            this.rad3layers.Location = new System.Drawing.Point(6, 65);
            this.rad3layers.Name = "rad3layers";
            this.rad3layers.Size = new System.Drawing.Size(65, 17);
            this.rad3layers.TabIndex = 2;
            this.rad3layers.Text = "&3 Layers";
            this.rad3layers.UseVisualStyleBackColor = true;
            // 
            // rad2layers
            // 
            this.rad2layers.AutoSize = true;
            this.rad2layers.Location = new System.Drawing.Point(6, 42);
            this.rad2layers.Name = "rad2layers";
            this.rad2layers.Size = new System.Drawing.Size(65, 17);
            this.rad2layers.TabIndex = 1;
            this.rad2layers.Text = "&2 Layers";
            this.rad2layers.UseVisualStyleBackColor = true;
            // 
            // rad1layer
            // 
            this.rad1layer.AutoSize = true;
            this.rad1layer.Checked = true;
            this.rad1layer.Location = new System.Drawing.Point(6, 19);
            this.rad1layer.Name = "rad1layer";
            this.rad1layer.Size = new System.Drawing.Size(60, 17);
            this.rad1layer.TabIndex = 0;
            this.rad1layer.TabStop = true;
            this.rad1layer.Text = "&1 Layer";
            this.rad1layer.UseVisualStyleBackColor = true;
            // 
            // grpDiameter
            // 
            this.grpDiameter.Controls.Add(this.rad12inch);
            this.grpDiameter.Controls.Add(this.rad8inch);
            this.grpDiameter.Controls.Add(this.rad5inch);
            this.grpDiameter.Location = new System.Drawing.Point(128, 30);
            this.grpDiameter.Name = "grpDiameter";
            this.grpDiameter.Size = new System.Drawing.Size(129, 100);
            this.grpDiameter.TabIndex = 3;
            this.grpDiameter.TabStop = false;
            this.grpDiameter.Text = "Cake Size (Diameter)";
            // 
            // rad12inch
            // 
            this.rad12inch.AutoSize = true;
            this.rad12inch.Location = new System.Drawing.Point(6, 65);
            this.rad12inch.Name = "rad12inch";
            this.rad12inch.Size = new System.Drawing.Size(60, 17);
            this.rad12inch.TabIndex = 2;
            this.rad12inch.Text = "12 &inch";
            this.rad12inch.UseVisualStyleBackColor = true;
            // 
            // rad8inch
            // 
            this.rad8inch.AutoSize = true;
            this.rad8inch.Location = new System.Drawing.Point(6, 42);
            this.rad8inch.Name = "rad8inch";
            this.rad8inch.Size = new System.Drawing.Size(54, 17);
            this.rad8inch.TabIndex = 1;
            this.rad8inch.Text = "&8 inch";
            this.rad8inch.UseVisualStyleBackColor = true;
            // 
            // rad5inch
            // 
            this.rad5inch.AutoSize = true;
            this.rad5inch.Checked = true;
            this.rad5inch.Location = new System.Drawing.Point(6, 19);
            this.rad5inch.Name = "rad5inch";
            this.rad5inch.Size = new System.Drawing.Size(54, 17);
            this.rad5inch.TabIndex = 0;
            this.rad5inch.TabStop = true;
            this.rad5inch.Text = "&5 inch";
            this.rad5inch.UseVisualStyleBackColor = true;
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radBanana);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(6, 30);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Size = new System.Drawing.Size(104, 100);
            this.grpFlavour.TabIndex = 0;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(6, 65);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(62, 17);
            this.radBanana.TabIndex = 2;
            this.radBanana.Text = "&Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(6, 42);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(56, 17);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.Text = "&Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Checked = true;
            this.radChocolate.Location = new System.Drawing.Point(6, 19);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(73, 17);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "&Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(451, 29);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(451, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(451, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblOutOrder
            // 
            this.lblOutOrder.Location = new System.Drawing.Point(429, 152);
            this.lblOutOrder.Name = "lblOutOrder";
            this.lblOutOrder.Size = new System.Drawing.Size(132, 96);
            this.lblOutOrder.TabIndex = 5;
            this.lblOutOrder.Text = "Thank you ";
            // 
            // frmCustomCake
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(571, 262);
            this.Controls.Add(this.lblOutOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpCustomCake);
            this.Controls.Add(this.grpCustInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCustomCake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amrit Braich";
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.grpCustomCake.ResumeLayout(false);
            this.grpNumLayers.ResumeLayout(false);
            this.grpNumLayers.PerformLayout();
            this.grpDiameter.ResumeLayout(false);
            this.grpDiameter.PerformLayout();
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustInfo;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox grpCustomCake;
        private System.Windows.Forms.GroupBox grpNumLayers;
        private System.Windows.Forms.RadioButton rad3layers;
        private System.Windows.Forms.RadioButton rad2layers;
        private System.Windows.Forms.RadioButton rad1layer;
        private System.Windows.Forms.GroupBox grpDiameter;
        private System.Windows.Forms.RadioButton rad12inch;
        private System.Windows.Forms.RadioButton rad8inch;
        private System.Windows.Forms.RadioButton rad5inch;
        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutOrder;
    }
}

