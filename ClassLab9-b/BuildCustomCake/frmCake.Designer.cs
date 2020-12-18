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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChooseCake = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstCakes = new System.Windows.Forms.ListBox();
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
            this.grpCakeType.Location = new System.Drawing.Point(18, 18);
            this.grpCakeType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCakeType.Name = "grpCakeType";
            this.grpCakeType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCakeType.Size = new System.Drawing.Size(193, 64);
            this.grpCakeType.TabIndex = 4;
            this.grpCakeType.TabStop = false;
            this.grpCakeType.Text = "Type of Cake";
            // 
            // radSpecial
            // 
            this.radSpecial.Location = new System.Drawing.Point(100, 29);
            this.radSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(82, 28);
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
            this.radCustom.Size = new System.Drawing.Size(83, 28);
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
            this.grpCustomCake.Location = new System.Drawing.Point(18, 92);
            this.grpCustomCake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCustomCake.Size = new System.Drawing.Size(490, 149);
            this.grpCustomCake.TabIndex = 1;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // grpNumLayers
            // 
            this.grpNumLayers.Controls.Add(this.rad3layers);
            this.grpNumLayers.Controls.Add(this.rad2layers);
            this.grpNumLayers.Controls.Add(this.rad1layer);
            this.grpNumLayers.Location = new System.Drawing.Point(326, 29);
            this.grpNumLayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNumLayers.Name = "grpNumLayers";
            this.grpNumLayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNumLayers.Size = new System.Drawing.Size(152, 108);
            this.grpNumLayers.TabIndex = 4;
            this.grpNumLayers.TabStop = false;
            this.grpNumLayers.Text = "Number of Layers";
            // 
            // rad3layers
            // 
            this.rad3layers.AutoSize = true;
            this.rad3layers.Location = new System.Drawing.Point(9, 76);
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
            this.rad2layers.Location = new System.Drawing.Point(9, 54);
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
            this.grpDiameter.Location = new System.Drawing.Point(137, 29);
            this.grpDiameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDiameter.Name = "grpDiameter";
            this.grpDiameter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDiameter.Size = new System.Drawing.Size(181, 108);
            this.grpDiameter.TabIndex = 3;
            this.grpDiameter.TabStop = false;
            this.grpDiameter.Text = "Cake Size (Diameter)";
            // 
            // rad12inch
            // 
            this.rad12inch.AutoSize = true;
            this.rad12inch.Location = new System.Drawing.Point(8, 76);
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
            this.rad8inch.Location = new System.Drawing.Point(8, 54);
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
            this.rad5inch.Location = new System.Drawing.Point(8, 29);
            this.rad5inch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad5inch.Name = "rad5inch";
            this.rad5inch.Size = new System.Drawing.Size(69, 24);
            this.rad5inch.TabIndex = 0;
            this.rad5inch.TabStop = true;
            this.rad5inch.Text = "&5 inch";
            this.rad5inch.UseVisualStyleBackColor = true;
            this.rad5inch.CheckedChanged += new System.EventHandler(this.rad5inch_CheckedChanged);
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radBanana);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(9, 29);
            this.grpFlavour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFlavour.Size = new System.Drawing.Size(120, 108);
            this.grpFlavour.TabIndex = 0;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(8, 76);
            this.radBanana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(83, 24);
            this.radBanana.TabIndex = 2;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "&Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            this.radBanana.CheckedChanged += new System.EventHandler(this.radBanana_CheckedChanged);
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(8, 54);
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
            this.radChocolate.Location = new System.Drawing.Point(8, 29);
            this.radChocolate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(99, 24);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "&Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCheck.Location = new System.Drawing.Point(344, 269);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(99, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Out";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReset.Location = new System.Drawing.Point(344, 302);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(344, 330);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChooseCake
            // 
            this.lblChooseCake.AutoSize = true;
            this.lblChooseCake.Location = new System.Drawing.Point(14, 246);
            this.lblChooseCake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseCake.Name = "lblChooseCake";
            this.lblChooseCake.Size = new System.Drawing.Size(165, 20);
            this.lblChooseCake.TabIndex = 7;
            this.lblChooseCake.Text = "Choose Special Cake:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdd.Location = new System.Drawing.Point(213, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnView.Location = new System.Drawing.Point(213, 298);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(99, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View Cart";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(213, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstCakes
            // 
            this.lstCakes.Enabled = false;
            this.lstCakes.FormattingEnabled = true;
            this.lstCakes.ItemHeight = 20;
            this.lstCakes.Items.AddRange(new object[] {
            "Holiday Cake",
            "Birthday Cake",
            "Wedding Cake",
            "Superhero Cake"});
            this.lstCakes.Location = new System.Drawing.Point(18, 269);
            this.lstCakes.Name = "lstCakes";
            this.lstCakes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCakes.Size = new System.Drawing.Size(161, 84);
            this.lstCakes.TabIndex = 11;
            // 
            // frmCake
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(525, 375);
            this.Controls.Add(this.grpCakeType);
            this.Controls.Add(this.lstCakes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblChooseCake);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grpCustomCake);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Info";
            this.Load += new System.EventHandler(this.frmCake_Load);
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
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpCakeType;
        private System.Windows.Forms.RadioButton radSpecial;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.Label lblChooseCake;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstCakes;
    }
}

