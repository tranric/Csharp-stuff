namespace Lab_7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblFirst = new System.Windows.Forms.Label();
            this.LblLast = new System.Windows.Forms.Label();
            this.txtboxfirst = new System.Windows.Forms.TextBox();
            this.txtboxlast = new System.Windows.Forms.TextBox();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.LblAddress = new System.Windows.Forms.Label();
            this.Txtboxaddress = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblProvince = new System.Windows.Forms.Label();
            this.lblpostal = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtprovince = new System.Windows.Forms.TextBox();
            this.txtpostal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblFirst
            // 
            this.LblFirst.AutoSize = true;
            this.LblFirst.Location = new System.Drawing.Point(12, 9);
            this.LblFirst.Name = "LblFirst";
            this.LblFirst.Size = new System.Drawing.Size(90, 20);
            this.LblFirst.TabIndex = 0;
            this.LblFirst.Text = "First Name:";
            // 
            // LblLast
            // 
            this.LblLast.AutoSize = true;
            this.LblLast.Location = new System.Drawing.Point(12, 38);
            this.LblLast.Name = "LblLast";
            this.LblLast.Size = new System.Drawing.Size(90, 20);
            this.LblLast.TabIndex = 1;
            this.LblLast.Text = "Last Name:";
            // 
            // txtboxfirst
            // 
            this.txtboxfirst.Location = new System.Drawing.Point(108, 6);
            this.txtboxfirst.Name = "txtboxfirst";
            this.txtboxfirst.Size = new System.Drawing.Size(171, 26);
            this.txtboxfirst.TabIndex = 2;
            // 
            // txtboxlast
            // 
            this.txtboxlast.Location = new System.Drawing.Point(108, 38);
            this.txtboxlast.Name = "txtboxlast";
            this.txtboxlast.Size = new System.Drawing.Size(171, 26);
            this.txtboxlast.TabIndex = 3;
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.Location = new System.Drawing.Point(295, 6);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(119, 26);
            this.BtnPlaceOrder.TabIndex = 4;
            this.BtnPlaceOrder.Text = "Place Order";
            this.BtnPlaceOrder.UseVisualStyleBackColor = true;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(295, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 26);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(295, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(30, 68);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(72, 20);
            this.LblAddress.TabIndex = 7;
            this.LblAddress.Text = "Address:";
            // 
            // Txtboxaddress
            // 
            this.Txtboxaddress.Location = new System.Drawing.Point(108, 70);
            this.Txtboxaddress.Name = "Txtboxaddress";
            this.Txtboxaddress.Size = new System.Drawing.Size(171, 26);
            this.Txtboxaddress.TabIndex = 8;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(63, 105);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(39, 20);
            this.LblCity.TabIndex = 9;
            this.LblCity.Text = "City:";
            // 
            // LblProvince
            // 
            this.LblProvince.AutoSize = true;
            this.LblProvince.Location = new System.Drawing.Point(178, 157);
            this.LblProvince.Name = "LblProvince";
            this.LblProvince.Size = new System.Drawing.Size(73, 20);
            this.LblProvince.TabIndex = 10;
            this.LblProvince.Text = "Province:";
            // 
            // lblpostal
            // 
            this.lblpostal.AutoSize = true;
            this.lblpostal.Location = new System.Drawing.Point(3, 157);
            this.lblpostal.Name = "lblpostal";
            this.lblpostal.Size = new System.Drawing.Size(99, 20);
            this.lblpostal.TabIndex = 11;
            this.lblpostal.Text = "Postal Code:";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(108, 102);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(171, 26);
            this.txtcity.TabIndex = 12;
            // 
            // txtprovince
            // 
            this.txtprovince.Location = new System.Drawing.Point(257, 151);
            this.txtprovince.Name = "txtprovince";
            this.txtprovince.Size = new System.Drawing.Size(56, 26);
            this.txtprovince.TabIndex = 13;
            this.txtprovince.TextChanged += new System.EventHandler(this.txtprovince_TextChanged);
            // 
            // txtpostal
            // 
            this.txtpostal.Location = new System.Drawing.Point(108, 154);
            this.txtpostal.Name = "txtpostal";
            this.txtpostal.Size = new System.Drawing.Size(56, 26);
            this.txtpostal.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 201);
            this.Controls.Add(this.txtpostal);
            this.Controls.Add(this.txtprovince);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.lblpostal);
            this.Controls.Add(this.LblProvince);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.Txtboxaddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.BtnPlaceOrder);
            this.Controls.Add(this.txtboxlast);
            this.Controls.Add(this.txtboxfirst);
            this.Controls.Add(this.LblLast);
            this.Controls.Add(this.LblFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Account Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirst;
        private System.Windows.Forms.Label LblLast;
        private System.Windows.Forms.Button BtnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblProvince;
        private System.Windows.Forms.Label lblpostal;
        public System.Windows.Forms.TextBox txtboxfirst;
        public System.Windows.Forms.TextBox txtboxlast;
        public System.Windows.Forms.TextBox Txtboxaddress;
        public System.Windows.Forms.TextBox txtcity;
        public System.Windows.Forms.TextBox txtprovince;
        public System.Windows.Forms.TextBox txtpostal;
    }
}