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
            decimal tax = 1.13m;
            txtTotal.Text = (nudNumberOfCakes.Value * 20 * tax).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudNumberOfCakes.Value = 1;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            btnOrder.Visible = true;
            grpOrderComplete.Visible = false;
            lblMessage.Visible = false;
            this.imgCake.Image = global::ClassLab3.Properties.Resources.Cake;
            count = 0;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                btnOrder.Visible = false;
                grpOrderComplete.Visible = true;
                lblFinalName.Text = "Thank you " + txtFirstName.Text + " " + txtLastName.Text;
                if (nudNumberOfCakes.Value == 1)
                {
                    lblFinalTotal.Text = "Your order of " + nudNumberOfCakes.Text + " Cake has been received!";
                }
                else
                {
                    lblFinalTotal.Text = "Your order of " + nudNumberOfCakes.Text + " Cakes has been received!";
                }
                lblFinalCost.Text = "The final cost comes to $" + txtTotal.Text +" CAD";
                lblMessage.Visible = false;
            }
            else
            {
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
    }
}
