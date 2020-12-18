//INSTANT C# NOTE: Formerly VB.NET project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Debug
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.txtScore6 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(141, 308);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinus.Size = new System.Drawing.Size(84, 68);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "Average Minus &Lowest";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.SystemColors.Control;
            this.btnAverage.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAverage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAverage.Location = new System.Drawing.Point(32, 308);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAverage.Size = new System.Drawing.Size(86, 68);
            this.btnAverage.TabIndex = 8;
            this.btnAverage.Text = "&Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.txtScore6);
            this.Frame1.Controls.Add(this.Label8);
            this.Frame1.Controls.Add(this.txtScore5);
            this.Frame1.Controls.Add(this.Label7);
            this.Frame1.Controls.Add(this.txtScore4);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.txtScore3);
            this.Frame1.Controls.Add(this.txtScore2);
            this.Frame1.Controls.Add(this.txtScore1);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.lblGrade);
            this.Frame1.Controls.Add(this.lblAverage);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(32, 19);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(193, 268);
            this.Frame1.TabIndex = 6;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Enter Test Scores";
            // 
            // txtScore6
            // 
            this.txtScore6.AcceptsReturn = true;
            this.txtScore6.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore6.Location = new System.Drawing.Point(88, 158);
            this.txtScore6.MaxLength = 0;
            this.txtScore6.Name = "txtScore6";
            this.txtScore6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore6.Size = new System.Drawing.Size(65, 20);
            this.txtScore6.TabIndex = 15;
            this.txtScore6.Text = "90";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(16, 158);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(57, 17);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Score &6:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtScore5
            // 
            this.txtScore5.AcceptsReturn = true;
            this.txtScore5.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore5.Location = new System.Drawing.Point(88, 132);
            this.txtScore5.MaxLength = 0;
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore5.Size = new System.Drawing.Size(65, 20);
            this.txtScore5.TabIndex = 13;
            this.txtScore5.Text = "90";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.SystemColors.Control;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(16, 132);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(57, 17);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Score &5:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtScore4
            // 
            this.txtScore4.AcceptsReturn = true;
            this.txtScore4.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore4.Location = new System.Drawing.Point(88, 106);
            this.txtScore4.MaxLength = 0;
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore4.Size = new System.Drawing.Size(65, 20);
            this.txtScore4.TabIndex = 11;
            this.txtScore4.Text = "90";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(16, 106);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(57, 17);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Score &4:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtScore3
            // 
            this.txtScore3.AcceptsReturn = true;
            this.txtScore3.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore3.Location = new System.Drawing.Point(88, 80);
            this.txtScore3.MaxLength = 0;
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore3.Size = new System.Drawing.Size(65, 20);
            this.txtScore3.TabIndex = 5;
            this.txtScore3.Text = "90";
            // 
            // txtScore2
            // 
            this.txtScore2.AcceptsReturn = true;
            this.txtScore2.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore2.Location = new System.Drawing.Point(88, 56);
            this.txtScore2.MaxLength = 0;
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore2.Size = new System.Drawing.Size(65, 20);
            this.txtScore2.TabIndex = 3;
            this.txtScore2.Text = "90";
            // 
            // txtScore1
            // 
            this.txtScore1.AcceptsReturn = true;
            this.txtScore1.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore1.Location = new System.Drawing.Point(88, 32);
            this.txtScore1.MaxLength = 0;
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore1.Size = new System.Drawing.Size(65, 20);
            this.txtScore1.TabIndex = 1;
            this.txtScore1.Text = "80";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(24, 218);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(49, 17);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Grade:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.SystemColors.Control;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrade.Location = new System.Drawing.Point(88, 218);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrade.Size = new System.Drawing.Size(65, 17);
            this.lblGrade.TabIndex = 9;
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.SystemColors.Control;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAverage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAverage.Location = new System.Drawing.Point(88, 194);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAverage.Size = new System.Drawing.Size(65, 17);
            this.lblAverage.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(24, 194);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(49, 17);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Average:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(16, 80);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(57, 17);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Score &3:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(16, 56);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(57, 17);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Score &2:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 32);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(57, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Score &1:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(34, 325);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(193, 17);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 397);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Debugging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);

		}
		public System.Windows.Forms.Button btnMinus;
		public System.Windows.Forms.Button btnAverage;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox txtScore6;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.TextBox txtScore5;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.TextBox txtScore4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.TextBox txtScore3;
		public System.Windows.Forms.TextBox txtScore2;
		public System.Windows.Forms.TextBox txtScore1;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label lblGrade;
		public System.Windows.Forms.Label lblAverage;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label lblMessage;

	}

} //end of root namespace