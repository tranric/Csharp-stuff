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
            this.lblNumberOfCakes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.grpOrderComplete = new System.Windows.Forms.GroupBox();
            this.lblFinalCost = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblFinalName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.imgCake = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.nudNumberOfCakes = new System.Windows.Forms.NumericUpDown();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            this.grpOrderComplete.SuspendLayout();
            this.grpInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCakes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfCakes
            // 
            this.lblNumberOfCakes.AutoSize = true;
            this.lblNumberOfCakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCakes.Location = new System.Drawing.Point(6, 73);
            this.lblNumberOfCakes.Name = "lblNumberOfCakes";
            this.lblNumberOfCakes.Size = new System.Drawing.Size(110, 16);
            this.lblNumberOfCakes.TabIndex = 4;
            this.lblNumberOfCakes.Text = "&Number of cakes";
            this.lblNumberOfCakes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 104);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "&Total:";
            this.lblTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblLastName);
            this.grpOrder.Controls.Add(this.lblFirstName);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.lblNumberOfCakes);
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(168, 128);
            this.grpOrder.TabIndex = 6;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
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
            // grpOrderComplete
            // 
            this.grpOrderComplete.Controls.Add(this.lblFinalCost);
            this.grpOrderComplete.Controls.Add(this.lblFinalTotal);
            this.grpOrderComplete.Controls.Add(this.lblFinalName);
            this.grpOrderComplete.Location = new System.Drawing.Point(12, 13);
            this.grpOrderComplete.Name = "grpOrderComplete";
            this.grpOrderComplete.Size = new System.Drawing.Size(295, 127);
            this.grpOrderComplete.TabIndex = 12;
            this.grpOrderComplete.TabStop = false;
            this.grpOrderComplete.Visible = false;
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.AutoSize = true;
            this.lblFinalCost.Location = new System.Drawing.Point(11, 72);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(207, 13);
            this.lblFinalCost.TabIndex = 2;
            this.lblFinalCost.Text = "The final cost comes to [Cost Listed Here] ";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Location = new System.Drawing.Point(11, 49);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(252, 13);
            this.lblFinalTotal.TabIndex = 1;
            this.lblFinalTotal.Text = "Your order of [Number Of Cakes] has been received";
            // 
            // lblFinalName
            // 
            this.lblFinalName.AutoSize = true;
            this.lblFinalName.Location = new System.Drawing.Point(11, 25);
            this.lblFinalName.Name = "lblFinalName";
            this.lblFinalName.Size = new System.Drawing.Size(229, 13);
            this.lblFinalName.TabIndex = 0;
            this.lblFinalName.Text = "Thank you [First Name Here] [Last Name Here]";
            this.lblFinalName.Click += new System.EventHandler(this.lblFinalName_Click);
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
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.imgCake);
            this.grpInputs.Controls.Add(this.txtTotal);
            this.grpInputs.Controls.Add(this.nudNumberOfCakes);
            this.grpInputs.Controls.Add(this.txtLastName);
            this.grpInputs.Controls.Add(this.txtFirstName);
            this.grpInputs.Location = new System.Drawing.Point(190, 12);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(117, 128);
            this.grpInputs.TabIndex = 8;
            this.grpInputs.TabStop = false;
            // 
            // imgCake
            // 
            this.imgCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgCake.Image = global::ClassLab3.Properties.Resources.Cake;
            this.imgCake.Location = new System.Drawing.Point(45, 69);
            this.imgCake.Name = "imgCake";
            this.imgCake.Size = new System.Drawing.Size(61, 51);
            this.imgCake.TabIndex = 12;
            this.imgCake.TabStop = false;
            this.imgCake.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(6, 100);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(33, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "22.60";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // nudNumberOfCakes
            // 
            this.nudNumberOfCakes.Location = new System.Drawing.Point(6, 69);
            this.nudNumberOfCakes.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfCakes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfCakes.Name = "nudNumberOfCakes";
            this.nudNumberOfCakes.Size = new System.Drawing.Size(33, 20);
            this.nudNumberOfCakes.TabIndex = 9;
            this.nudNumberOfCakes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumberOfCakes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfCakes.ValueChanged += new System.EventHandler(this.nudNumberOfCakes_ValueChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(105, 163);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 163);
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
            this.lblMessage.Location = new System.Drawing.Point(12, 143);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(109, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Please fill out all fields";
            this.lblMessage.Visible = false;
            // 
            // frmCake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 205);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpOrderComplete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpInputs);
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
            this.grpOrderComplete.ResumeLayout(false);
            this.grpOrderComplete.PerformLayout();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfCakes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.NumericUpDown nudNumberOfCakes;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpOrderComplete;
        private System.Windows.Forms.Label lblFinalCost;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblFinalName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox imgCake;
    }
}

