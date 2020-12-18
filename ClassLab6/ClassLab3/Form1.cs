using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLab3
{
    public partial class frmCake : Form
    {
        public int count = 0;
        public frmCake()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void nudNumberOfCakes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnOrder.Visible = true;
            grpOrderComplete.Visible = false;
            this.imgCake.Image = global::ClassLab3.Properties.Resources.Cake;
            count = 0;
            lblMessage.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblThankyouMessage.Text = "You have ordered:\n";
            double cost=0;
            string typeOfCake = string.Empty;
            int counter1 = 0;
            for (int count = 0; count < lstCake.SelectedItems.Count; count++)
            {
                if (lstCake.SelectedItems[count].ToString().Equals("Holiday Cake"))
                {
                    cost = cost + 18;
                    typeOfCake = lstCake.SelectedItems[count].ToString() + Environment.NewLine;
                }

                if (lstCake.SelectedItems[count].ToString().Equals("Birthday Cake"))
                {
                    cost = cost + 25;
                    typeOfCake += lstCake.SelectedItems[count].ToString();
                }

                if (lstCake.SelectedItems[count].ToString().Equals("Wedding Cake"))
                {
                    cost = cost + 40;
                }

                if (lstCake.SelectedItems[count].ToString().Equals("Super Hero Cake"))
                {
                    cost = cost + 30;
                }

                grpOrderComplete.Visible = true;
                lblThankyouMessage.Text += "\n" + typeOfCake;
                //lblThankyouMessage.Text += "\n" + lstCake.SelectedItems[count].ToString();
               // counter1++;
               // btnOrder.Visible = false;
                //count = 0;
            }
            lblThankyouMessage.Text += "\n\nTotal Cost: $" + cost + typeOfCake;
            this.imgCake.Image = global::ClassLab3.Properties.Resources.CakeAnimated;
            if (lstCake.SelectedItems.Count == 0)
            {
                grpOrderComplete.Visible = false;
                lblMessage.Visible = true;
            }
        }

        private void lblFinalName_Click(object sender, EventArgs e)
        {

        }

        private void frmCake_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            count += 1;
            if (count == 2)
            {
                count = 0;
            }
            if (count==0)
            {
                this.imgCake.Image = global::ClassLab3.Properties.Resources.Cake;
            }
            if (count==1)
            {
                this.imgCake.Image = global::ClassLab3.Properties.Resources.CakeAnimated;
            }
        }

        private void grpOrderComplete_Enter(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lstCake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
