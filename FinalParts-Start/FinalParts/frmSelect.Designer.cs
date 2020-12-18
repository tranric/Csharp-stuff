namespace FinalParts
{
    partial class frmSelect
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.cmbParts = new System.Windows.Forms.ComboBox();
            this.lbltPrice = new System.Windows.Forms.Label();
            this.lbltName = new System.Windows.Forms.Label();
            this.lbltID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(17, 62);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(139, 16);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Please choose a part:";
            // 
            // cmbParts
            // 
            this.cmbParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParts.FormattingEnabled = true;
            this.cmbParts.Location = new System.Drawing.Point(17, 82);
            this.cmbParts.Margin = new System.Windows.Forms.Padding(5);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(340, 24);
            this.cmbParts.TabIndex = 3;
            this.cmbParts.SelectedIndexChanged += new System.EventHandler(this.cmbParts_SelectedIndexChanged);
            // 
            // lbltPrice
            // 
            this.lbltPrice.AutoSize = true;
            this.lbltPrice.Location = new System.Drawing.Point(17, 224);
            this.lbltPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltPrice.Name = "lbltPrice";
            this.lbltPrice.Size = new System.Drawing.Size(42, 16);
            this.lbltPrice.TabIndex = 9;
            this.lbltPrice.Text = "Price:";
            // 
            // lbltName
            // 
            this.lbltName.AutoSize = true;
            this.lbltName.Location = new System.Drawing.Point(17, 203);
            this.lbltName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltName.Name = "lbltName";
            this.lbltName.Size = new System.Drawing.Size(48, 16);
            this.lbltName.TabIndex = 8;
            this.lbltName.Text = "Name:";
            // 
            // lbltID
            // 
            this.lbltID.AutoSize = true;
            this.lbltID.Location = new System.Drawing.Point(17, 182);
            this.lbltID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltID.Name = "lbltID";
            this.lbltID.Size = new System.Drawing.Size(24, 16);
            this.lbltID.TabIndex = 7;
            this.lbltID.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(71, 182);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 16);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Remove this text";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(72, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Remove this text";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(71, 224);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 16);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Remove this text";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(379, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 260);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbltPrice);
            this.Controls.Add(this.lbltName);
            this.Controls.Add(this.lbltID);
            this.Controls.Add(this.cmbParts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSelect";
            this.Text = "Select";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblProducts;
        internal System.Windows.Forms.ComboBox cmbParts;
        internal System.Windows.Forms.Label lbltPrice;
        internal System.Windows.Forms.Label lbltName;
        internal System.Windows.Forms.Label lbltID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

