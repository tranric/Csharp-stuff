namespace ClassLab2
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.btnRoot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(112, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "&Enter Number:";
            this.lblNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoot.Location = new System.Drawing.Point(12, 70);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(104, 20);
            this.lblRoot.TabIndex = 2;
            this.lblRoot.Text = "Square Root:";
            this.lblRoot.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Location = new System.Drawing.Point(177, 30);
            this.nudNumber.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(95, 20);
            this.nudNumber.TabIndex = 1;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(177, 70);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.ReadOnly = true;
            this.txtRoot.Size = new System.Drawing.Size(95, 20);
            this.txtRoot.TabIndex = 3;
            this.txtRoot.TabStop = false;
            this.txtRoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(71, 115);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(139, 37);
            this.btnRoot.TabIndex = 4;
            this.btnRoot.Text = "&Square Root";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRoot;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.lblNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Square Root";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Button btnRoot;
    }
}

