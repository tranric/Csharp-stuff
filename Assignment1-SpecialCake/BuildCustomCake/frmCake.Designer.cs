namespace BuildCustomCake
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
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.grpCakeType = new System.Windows.Forms.GroupBox();
            this.radSpecial = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
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
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChooseCake = new System.Windows.Forms.Label();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lstSC = new System.Windows.Forms.ListBox();
            this.grpCustInfo.SuspendLayout();
            this.grpCakeType.SuspendLayout();
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
            this.grpCustInfo.Location = new System.Drawing.Point(18, 18);
            this.grpCustInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustInfo.Size = new System.Drawing.Size(279, 135);
            this.grpCustInfo.TabIndex = 0;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer Information";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(108, 89);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 26);
            this.txtLName.TabIndex = 3;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(10, 94);
            this.lblLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(90, 20);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "&Last Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(108, 42);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(148, 26);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(9, 42);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(90, 20);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "&First Name:";
            // 
            // grpCakeType
            // 
            this.grpCakeType.Controls.Add(this.radSpecial);
            this.grpCakeType.Controls.Add(this.radCustom);
            this.grpCakeType.Location = new System.Drawing.Point(305, 18);
            this.grpCakeType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCakeType.Name = "grpCakeType";
            this.grpCakeType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCakeType.Size = new System.Drawing.Size(310, 135);
            this.grpCakeType.TabIndex = 4;
            this.grpCakeType.TabStop = false;
            this.grpCakeType.Text = "Type of Cake";
            // 
            // radSpecial
            // 
            this.radSpecial.Location = new System.Drawing.Point(150, 29);
            this.radSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(111, 52);
            this.radSpecial.TabIndex = 1;
            this.radSpecial.TabStop = true;
            this.radSpecial.Text = "&Special";
            this.radSpecial.UseVisualStyleBackColor = true;
            this.radSpecial.CheckedChanged += new System.EventHandler(this.radSpecial_CheckedChanged);
            // 
            // radCustom
            // 
            this.radCustom.Checked = true;
            this.radCustom.Location = new System.Drawing.Point(9, 29);
            this.radCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(111, 52);
            this.radCustom.TabIndex = 0;
            this.radCustom.TabStop = true;
            this.radCustom.Text = "&Custom";
            this.radCustom.UseVisualStyleBackColor = true;
            this.radCustom.CheckedChanged += new System.EventHandler(this.radCustom_CheckedChanged);
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Controls.Add(this.grpNumLayers);
            this.grpCustomCake.Controls.Add(this.grpDiameter);
            this.grpCustomCake.Controls.Add(this.grpFlavour);
            this.grpCustomCake.Location = new System.Drawing.Point(18, 178);
            this.grpCustomCake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomCake.Size = new System.Drawing.Size(606, 222);
            this.grpCustomCake.TabIndex = 1;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // grpNumLayers
            // 
            this.grpNumLayers.Controls.Add(this.rad3layers);
            this.grpNumLayers.Controls.Add(this.rad2layers);
            this.grpNumLayers.Controls.Add(this.rad1layer);
            this.grpNumLayers.Location = new System.Drawing.Point(410, 46);
            this.grpNumLayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNumLayers.Name = "grpNumLayers";
            this.grpNumLayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNumLayers.Size = new System.Drawing.Size(178, 154);
            this.grpNumLayers.TabIndex = 4;
            this.grpNumLayers.TabStop = false;
            this.grpNumLayers.Text = "Number of Layers";
            // 
            // rad3layers
            // 
            this.rad3layers.AutoSize = true;
            this.rad3layers.Location = new System.Drawing.Point(9, 100);
            this.rad3layers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad3layers.Name = "rad3layers";
            this.rad3layers.Size = new System.Drawing.Size(87, 24);
            this.rad3layers.TabIndex = 2;
            this.rad3layers.TabStop = true;
            this.rad3layers.Text = "&3 Layers";
            this.rad3layers.UseVisualStyleBackColor = true;
            // 
            // rad2layers
            // 
            this.rad2layers.AutoSize = true;
            this.rad2layers.Location = new System.Drawing.Point(9, 65);
            this.rad2layers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad2layers.Name = "rad2layers";
            this.rad2layers.Size = new System.Drawing.Size(87, 24);
            this.rad2layers.TabIndex = 1;
            this.rad2layers.TabStop = true;
            this.rad2layers.Text = "&2 Layers";
            this.rad2layers.UseVisualStyleBackColor = true;
            // 
            // rad1layer
            // 
            this.rad1layer.AutoSize = true;
            this.rad1layer.Checked = true;
            this.rad1layer.Location = new System.Drawing.Point(9, 29);
            this.rad1layer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad1layer.Name = "rad1layer";
            this.rad1layer.Size = new System.Drawing.Size(79, 24);
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
            this.grpDiameter.Location = new System.Drawing.Point(192, 46);
            this.grpDiameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDiameter.Name = "grpDiameter";
            this.grpDiameter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDiameter.Size = new System.Drawing.Size(194, 154);
            this.grpDiameter.TabIndex = 3;
            this.grpDiameter.TabStop = false;
            this.grpDiameter.Text = "Cake Size (Diameter)";
            // 
            // rad12inch
            // 
            this.rad12inch.AutoSize = true;
            this.rad12inch.Location = new System.Drawing.Point(9, 100);
            this.rad12inch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad12inch.Name = "rad12inch";
            this.rad12inch.Size = new System.Drawing.Size(78, 24);
            this.rad12inch.TabIndex = 2;
            this.rad12inch.TabStop = true;
            this.rad12inch.Text = "12 &inch";
            this.rad12inch.UseVisualStyleBackColor = true;
            // 
            // rad8inch
            // 
            this.rad8inch.AutoSize = true;
            this.rad8inch.Location = new System.Drawing.Point(9, 65);
            this.rad8inch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad8inch.Name = "rad8inch";
            this.rad8inch.Size = new System.Drawing.Size(69, 24);
            this.rad8inch.TabIndex = 1;
            this.rad8inch.TabStop = true;
            this.rad8inch.Text = "&8 inch";
            this.rad8inch.UseVisualStyleBackColor = true;
            // 
            // rad5inch
            // 
            this.rad5inch.AutoSize = true;
            this.rad5inch.Checked = true;
            this.rad5inch.Location = new System.Drawing.Point(9, 29);
            this.rad5inch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad5inch.Name = "rad5inch";
            this.rad5inch.Size = new System.Drawing.Size(69, 24);
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
            this.grpFlavour.Location = new System.Drawing.Point(9, 46);
            this.grpFlavour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlavour.Size = new System.Drawing.Size(156, 154);
            this.grpFlavour.TabIndex = 0;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(9, 100);
            this.radBanana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(83, 24);
            this.radBanana.TabIndex = 2;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "&Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(9, 65);
            this.radVanilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(74, 24);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.TabStop = true;
            this.radVanilla.Text = "&Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Checked = true;
            this.radChocolate.Location = new System.Drawing.Point(9, 29);
            this.radChocolate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(99, 24);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "&Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(698, 47);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(112, 35);
            this.btnAddCart.TabIndex = 2;
            this.btnAddCart.Text = "&Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(698, 362);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 35);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(698, 444);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChooseCake
            // 
            this.lblChooseCake.AutoSize = true;
            this.lblChooseCake.Location = new System.Drawing.Point(14, 422);
            this.lblChooseCake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseCake.Name = "lblChooseCake";
            this.lblChooseCake.Size = new System.Drawing.Size(161, 20);
            this.lblChooseCake.TabIndex = 7;
            this.lblChooseCake.Text = "Choose Special Cake";
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(698, 131);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(112, 35);
            this.btnViewCart.TabIndex = 8;
            this.btnViewCart.Text = "&View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(698, 215);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(112, 35);
            this.btnClearCart.TabIndex = 9;
            this.btnClearCart.Text = "&Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(698, 289);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(112, 34);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lstSC
            // 
            this.lstSC.Enabled = false;
            this.lstSC.FormattingEnabled = true;
            this.lstSC.ItemHeight = 20;
            this.lstSC.Items.AddRange(new object[] {
            "Holiday Cake",
            "Birthday Cake",
            "Wedding Cake",
            "SuperHero Cake"});
            this.lstSC.Location = new System.Drawing.Point(18, 456);
            this.lstSC.Name = "lstSC";
            this.lstSC.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSC.Size = new System.Drawing.Size(157, 84);
            this.lstSC.TabIndex = 2;
            this.lstSC.SelectedIndexChanged += new System.EventHandler(this.lstSC_SelectedIndexChanged);
            // 
            // frmCake
            // 
            this.AcceptButton = this.btnAddCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(904, 582);
            this.Controls.Add(this.lstSC);
            this.Controls.Add(this.grpCakeType);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.lblChooseCake);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.grpCustomCake);
            this.Controls.Add(this.grpCustInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCake_Load);
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.grpCakeType.ResumeLayout(false);
            this.grpCustomCake.ResumeLayout(false);
            this.grpNumLayers.ResumeLayout(false);
            this.grpNumLayers.PerformLayout();
            this.grpDiameter.ResumeLayout(false);
            this.grpDiameter.PerformLayout();
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpCakeType;
        private System.Windows.Forms.RadioButton radSpecial;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.Label lblChooseCake;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListBox lstSC;
    }
}

