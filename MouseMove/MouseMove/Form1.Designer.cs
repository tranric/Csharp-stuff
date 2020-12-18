namespace MouseMove
{
    partial class frmMouseMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMouseMove));
            this.lblMouseX = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.Location = new System.Drawing.Point(16, 26);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(107, 20);
            this.lblMouseX.TabIndex = 0;
            this.lblMouseX.Text = "X Co-ordinate";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.Location = new System.Drawing.Point(16, 58);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(107, 20);
            this.lblMouseY.TabIndex = 1;
            this.lblMouseY.Text = "Y Co-ordinate";
            this.lblMouseY.Click += new System.EventHandler(this.lblMouseY_Click);
            // 
            // txtMouseX
            // 
            this.txtMouseX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMouseX.Location = new System.Drawing.Point(146, 23);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.ReadOnly = true;
            this.txtMouseX.Size = new System.Drawing.Size(40, 26);
            this.txtMouseX.TabIndex = 2;
            this.txtMouseX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMouseY
            // 
            this.txtMouseY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMouseY.Location = new System.Drawing.Point(146, 55);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.ReadOnly = true;
            this.txtMouseY.Size = new System.Drawing.Size(40, 26);
            this.txtMouseY.TabIndex = 3;
            this.txtMouseY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmMouseMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtMouseY);
            this.Controls.Add(this.txtMouseX);
            this.Controls.Add(this.lblMouseY);
            this.Controls.Add(this.lblMouseX);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMouseMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Location";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMouseMove_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.TextBox txtMouseY;
    }
}

