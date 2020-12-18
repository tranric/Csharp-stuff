using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeClassLibrary;

namespace Lab_7
{
    public partial class frmCake : Form
    {
        Order cakeOrder;
        public frmCake()
        {
            InitializeComponent();
            cakeOrder = new Order();
            lstChooseCake.Enabled = false;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            
            /*if (txtFName.Text == "" || txtLName.Text == "")
            {
                MessageBox.Show("Please enter information", "Data Missing");
                txtFName.Focus();
                return;
            }*/
            //make sure first name is entered, if not, error message and return
            cakeOrder.Customer.FirstName = Form1.First;
            cakeOrder.Customer.LastName = Form1.Last;
            cakeOrder.Customer.Address = Form1.Address;
            cakeOrder.Customer.City = Form1.City;
            cakeOrder.Customer.Postal = Form1.Postal;
            cakeOrder.Customer.Province = Form1.Province;

            if (radCustom.Checked)
            {
                string flavour; int size; int layers;

                if (radChocolate.Checked)
                    flavour = "chocolate";
                else if (radVanilla.Checked)
                    flavour = "vanilla";
                else flavour = "banana";

                if (rad5inch.Checked)
                    size = 5;
                else if (rad8inch.Checked)
                    size = 8;
                else size = 12;

                if (rad1layer.Checked)
                    layers = 1;
                else if (rad2layers.Checked)
                    layers = 2;
                else layers = 3;

                //add cake to order using custom cake parameters 
                cakeOrder.AddCake(flavour, size, layers);
            }
            else
            {
                //loop through selected cakes
                    for (int count = 0; count < lstChooseCake.SelectedItems.Count; count++)
                    {
                       
                        //add cake to order using special cake parameter - split[0] = Holiday split[1] = Cake
                        cakeOrder.AddCake(lstChooseCake.SelectedItems[count].ToString());
                    }
                
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rad5inch.Checked = true;
            radChocolate.Checked = true;
            rad1layer.Checked = true;
          //  txtFName.Text = string.Empty;
           // txtLName.Text = string.Empty;
            radCustom.Checked = true;
           // txtFName.Focus();
           // lstChooseCake.SelectedItems.Clear(); or
            lstChooseCake.ClearSelected();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cakeOrder.ToString());
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            //enable and disable controls based on selection
            //of custom or special radio button
            lstChooseCake.Enabled = false;
            grpCustomCake.Enabled = true;
        }

        private void radSpecial_CheckedChanged(object sender, EventArgs e)
        {
            //enable and disable controls based on selection
            //of custom or special radio button
            lstChooseCake.Enabled = true;
            grpCustomCake.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dlgMsg;
            dlgMsg = MessageBox.Show(cakeOrder.ToString(), "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //confirm order
            if (dlgMsg == DialogResult.Yes)
            {
                MessageBox.Show(cakeOrder.Confirmation());
                cakeOrder.ClearCakeList();
            }
            else
            {
                MessageBox.Show("The order has not been placed");
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cakeOrder.ClearCakeList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
