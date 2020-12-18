using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //process order and display details
			lblOrder.Text = "Your order: ";
			if (radCap.Checked == true)
			{
				lblOrder.Text += "Cappucino";
			}
			if (radLatte.Checked == true)
			{
				lblOrder.Text += "Latte";
			}
			if (radEspresso.Checked == true)
			{
				lblOrder.Text += "Espresso";
			}
			if (radMocha.Checked == true)
			{
				lblOrder.Text += "Mocha";
			}
			if (chkDecaf.Checked == true)
			{
				lblOrder.Text += " decaffeinated";
			}
			if (chkMilk.Checked == true)
			{
				lblOrder.Text += " with milk";
			}
			if (chkSugar.Checked == true)
			{
				lblOrder.Text += " with sugar";
			}
			if (chkToGo.Checked == true)
			{
				lblOrder.Text += " to go";
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			radCap.Checked = true;
		}

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
