namespace Lab_7
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
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSpecialCake = new System.Windows.Forms.Label();
            this.lstChooseCake = new System.Windows.Forms.ListBox();
            this.grpCakeType.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.grpNumLayers.SuspendLayout();
            this.grpDiameter.SuspendLayout();
            this.grpFlavour.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCakeType
            // 
            this.grpCakeType.Controls.Add(this.radSpecial);
            this.grpCakeType.Controls.Add(this.radCustom);
            this.grpCakeType.Location = new System.Drawing.Point(12, 12);
            this.grpCakeType.Name = "grpCakeType";
            this.grpCakeType.Size = new System.Drawing.Size(200, 59);
            this.grpCakeType.TabIndex = 4;
            this.grpCakeType.TabStop = false;
            this.grpCakeType.Text = "Type of Cake";
            // 
            // radSpecial
            // 
            this.radSpecial.Location = new System.Drawing.Point(100, 19);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(74, 34);
            this.radSpecial.TabIndex = 1;
            this.radSpecial.TabStop = true;
            this.radSpecial.Text = "&Special";
            this.radSpecial.UseVisualStyleBackColor = true;
            this.radSpecial.CheckedChanged += new System.EventHandler(this.radSpecial_CheckedChanged);
            // 
            // radCustom
            // 
            this.radCustom.Checked = true;
            this.radCustom.Location = new System.Drawing.Point(6, 23);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(74, 34);
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
            this.grpCustomCake.Location = new System.Drawing.Point(12, 77);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Size = new System.Drawing.Size(404, 144);
            this.grpCustomCake.TabIndex = 3;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
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
            this.rad3layers.TabStop = true;
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
            this.rad2layers.TabStop = true;
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
            this.rad12inch.TabStop = true;
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
            this.rad8inch.TabStop = true;
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
            this.radBanana.TabStop = true;
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
            this.radVanilla.TabStop = true;
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
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(140, 240);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddCart.TabIndex = 5;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(140, 269);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(75, 23);
            this.btnViewCart.TabIndex = 6;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(221, 240);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(75, 23);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(221, 269);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(329, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(329, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSpecialCake
            // 
            this.lblSpecialCake.AutoSize = true;
            this.lblSpecialCake.Location = new System.Drawing.Point(12, 224);
            this.lblSpecialCake.Name = "lblSpecialCake";
            this.lblSpecialCake.Size = new System.Drawing.Size(112, 13);
            this.lblSpecialCake.TabIndex = 11;
            this.lblSpecialCake.Text = "Choose Special Cake:";
            // 
            // lstChooseCake
            // 
            this.lstChooseCake.FormattingEnabled = true;
            this.lstChooseCake.Items.AddRange(new object[] {
            "Holiday Cake",
            "Birthday Cake",
            "Wedding Cake",
            "SuperHero Cake"});
            this.lstChooseCake.Location = new System.Drawing.Point(12, 240);
            this.lstChooseCake.Name = "lstChooseCake";
            this.lstChooseCake.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstChooseCake.Size = new System.Drawing.Size(120, 56);
            this.lstChooseCake.TabIndex = 12;
            // 
            // frmCake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 311);
            this.Controls.Add(this.lstChooseCake);
            this.Controls.Add(this.lblSpecialCake);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.grpCakeType);
            this.Controls.Add(this.grpCustomCake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCake";
            this.Text = "Order";
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

        private System.Windows.Forms.GroupBox grpCakeType;
        private System.Windows.Forms.RadioButton radSpecial;
        private System.Windows.Forms.RadioButton radCustom;
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
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSpecialCake;
        private System.Windows.Forms.ListBox lstChooseCake;
    }
}

