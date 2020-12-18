using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Debug
{
	public partial class Form1
	{
        private float[] fltScores = new float[6];
        private float fltTotal;
        private float fltAverage;

		internal Form1()
		{
			InitializeComponent();
		}		

		private void btnAverage_Click(object sender, System.EventArgs e)
		{

			LoadArray(fltScores.Length);

			fltTotal = CalcTotal();

			fltAverage = fltTotal / fltScores.Length;
            lblAverage.Text = fltAverage.ToString("n2");

			CalcGrade();
		}

		private void btnMinus_Click(object sender, System.EventArgs e)
		{

			LoadArray(fltScores.Length);
			float fltLowest = 200F;

			foreach (float i in fltScores)
			{
			    fltLowest = Math.Min(fltLowest, i);
			}
         


                fltTotal = CalcTotal();

			fltAverage = (fltTotal - fltLowest) / (fltScores.Length -1);
            lblAverage.Text = fltAverage.ToString("n2");

			CalcGrade();
		}

		private void LoadArray(int i)
		{
			fltScores[0] = Convert.ToSingle(txtScore1.Text);
			fltScores[1] = Convert.ToSingle(txtScore2.Text);
			fltScores[2] = Convert.ToSingle(txtScore3.Text);
			fltScores[3] = Convert.ToSingle(txtScore4.Text);
			fltScores[4] = Convert.ToSingle(txtScore5.Text);
            fltScores[5] = Convert.ToSingle(txtScore5.Text);
		}

		private void CalcGrade()
		{
			if (fltAverage < 60)
			{
				lblGrade.Text = "F";
			}
			else if (fltAverage < 70)
			{
				lblGrade.Text = "D";
			}
            else if (fltAverage < 80)
			{
				lblGrade.Text = "C";
			}
            else if (fltAverage < 90)
			{
				lblGrade.Text = "B";
			}
            else if (fltAverage <= 100)
			{
				lblGrade.Text = "A";
			}
		}

		private float CalcTotal()
		{
			fltTotal = 0F;
			for (int i = 0; i < fltScores.Length; i++)
			{
				fltTotal += fltScores[i];
			}
			return fltTotal;
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
	}

}