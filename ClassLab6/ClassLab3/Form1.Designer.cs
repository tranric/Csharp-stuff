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
            this.grpOrderComplete = new System.Windows.Forms.GroupBox();
            this.lblThankyouMessage = new System.Windows.Forms.Label();
            this.imgCake = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstCake = new System.Windows.Forms.ListBox();
            this.grpOrderComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCake)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrderComplete
            // 
            this.grpOrderComplete.Controls.Add(this.lblThankyouMessage);
            this.grpOrderComplete.Location = new System.Drawing.Point(10, 5);
            this.grpOrderComplete.Name = "grpOrderComplete";
            this.grpOrderComplete.Size = new System.Drawing.Size(120, 125);
            this.grpOrderComplete.TabIndex = 12;
            this.grpOrderComplete.TabStop = false;
            this.grpOrderComplete.Visible = false;
            this.grpOrderComplete.Enter += new System.EventHandler(this.grpOrderComplete_Enter);
            // 
            // lblThankyouMessage
            // 
            this.lblThankyouMessage.AutoSize = true;
            this.lblThankyouMessage.Location = new System.Drawing.Point(6, 15);
            this.lblThankyouMessage.Name = "lblThankyouMessage";
            this.lblThankyouMessage.Size = new System.Drawing.Size(95, 13);
            this.lblThankyouMessage.TabIndex = 0;
            this.lblThankyouMessage.Text = "You have ordered:";
            this.lblThankyouMessage.Click += new System.EventHandler(this.lblFinalName_Click);
            // 
            // imgCake
            // 
            this.imgCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgCake.Image = global::ClassLab3.Properties.Resources.Cake;
            this.imgCake.Location = new System.Drawing.Point(217, 34);
            this.imgCake.Name = "imgCake";
            this.imgCake.Size = new System.Drawing.Size(61, 51);
            this.imgCake.TabIndex = 12;
            this.imgCake.TabStop = false;
            this.imgCake.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(136, 19);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(136, 77);
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
            this.lblMessage.Location = new System.Drawing.Point(12, 118);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(109, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Please fill out all fields";
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // lstCake
            // 
            this.lstCake.FormattingEnabled = true;
            this.lstCake.Items.AddRange(new object[] {
            "Holiday Cake",
            "Birthday Cake",
            "Wedding Cake",
            "Super Hero Cake"});
            this.lstCake.Location = new System.Drawing.Point(12, 19);
            this.lstCake.Name = "lstCake";
            this.lstCake.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCake.Size = new System.Drawing.Size(118, 82);
            this.lstCake.TabIndex = 14;
            this.lstCake.SelectedIndexChanged += new System.EventHandler(this.lstCake_SelectedIndexChanged);
            // 
            // frmCake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 142);
            this.Controls.Add(this.grpOrderComplete);
            this.Controls.Add(this.imgCake);
            this.Controls.Add(this.lstCake);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCake";
            this.Text = "Cake Order";
            this.Load += new System.EventHandler(this.frmCake_Load);
            this.grpOrderComplete.ResumeLayout(false);
            this.grpOrderComplete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpOrderComplete;
        private System.Windows.Forms.Label lblThankyouMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox imgCake;
        private System.Windows.Forms.ListBox lstCake;
    }
}

