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
        public double totalCost = 0;
        public double flavourValue = 0;
        public double sizeValue = 0;
        public double layerValues = 0;
        public double specialValue = 18;
        public frmCake()
        {
            InitializeComponent();
            drpbxSpecialCake.Text = "Holiday Cake";
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
            lblMessage.Visible = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            drpbxSpecialCake.Text = "Holiday Cake";
            totalCost = 0;
            flavourValue = 0;
            sizeValue = 0;
            layerValues = 0;
            specialValue = 18;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || drpbxSpecialCake.Text == "")
            {
                lblMessage.Visible = true;
            }
            else
            {
                totalCost += specialValue;
                DialogResult result = MessageBox.Show("Thank you " + txtFirstName.Text + " " + txtLastName.Text + "\nYou have ordered 1 " 
+ drpbxSpecialCake.Text + " cake(s) for the total price of " + totalCost*1.13, "Confirm Order", MessageBoxButtons.YesNo);
                lblMessage.Visible = false;
                if (result == DialogResult.No){
                    lblMessage.Visible = false;
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    drpbxSpecialCake.Text = "Holiday Cake";
                    totalCost = 0;
                    flavourValue = 0;
                    sizeValue = 0;
                    layerValues = 0;
                    specialValue = 18;
                }
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

        private void grpOrder_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void drpbxSpecialCake_SelectedIndexChanged(object sender, EventArgs e)
        {
            drpbxSpecialCake.SelectedIndex = 0;
            this.drpbxSpecialCake.Text = this.drpbxSpecialCake.Items[0].ToString();
        }

        private void radbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (grpCake.Enabled == false)
            {
                grpCake.Enabled = true;
            }
            else
            {
                grpCake.Enabled = false;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void drpbxSpecialCake_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (drpbxSpecialCake.SelectedValue == "Holiday Cake") { specialValue = 18; }
            if (drpbxSpecialCake.SelectedValue == "Birthday Cake") { specialValue = 25; }
            if (drpbxSpecialCake.SelectedValue == "Super Hero Cake") { specialValue = 30; }
            if (drpbxSpecialCake.SelectedValue == "Wedding Cake ") { specialValue = 40; }
        }
    }
}
