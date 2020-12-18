using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeClasses;

namespace BuildCustomCake
{
    public partial class frmCake : Form
    {
        Order cakeOrder;
        public frmCake()
        {
            InitializeComponent();
            lstSC.SelectedIndex = 0;
            cakeOrder = new Order();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
           
            //make sure first name is entered, if not, error message and return
            if (txtFName.Text == "")
            {
                MessageBox.Show("Please enter first name", "Data Missing");
                txtFName.Focus();
                return;
            }

            //make sure last name is entered, if not, error message and return
            if (txtLName.Text == "")
            {
                MessageBox.Show("Please enter Last name", "Data Missing");
                txtLName.Focus();
                return;
            }

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

                cakeOrder.Customer = new Customer(txtFName.Text, txtFName.Text);
                cakeOrder.AddCake(flavour, size, layers);
                
            }
            else
            {
                if (lstSC.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Choose a type of special cake!");
                    return;
                }

                cakeOrder.Customer = new Customer(txtFName.Text, txtLName.Text);

                    cakeOrder.AddCake(lstSC.SelectedItem.ToString());
                    
     
            }
            


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstSC.ClearSelected();
            rad5inch.Checked = true;
            radChocolate.Checked = true;
            rad1layer.Checked = true;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            radCustom.Checked = true;
            txtFName.Focus();
            lstSC.Enabled = false;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            //enable and disable controls based on selection
            //of custom or special radio button
            lstSC.Enabled = false;
            grpCustomCake.Enabled = true;
            lstSC.ClearSelected();

        }

        private void radSpecial_CheckedChanged(object sender, EventArgs e)
        {
            //enable and disable controls based on selection
            //of custom or special radio button
            lstSC.Enabled = true;
            grpCustomCake.Enabled = false;
            rad5inch.Checked = true;
            radChocolate.Checked = true;
            rad1layer.Checked = true;
        }

        private void frmCake_Load(object sender, EventArgs e)
        {
            lstSC.ClearSelected();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult dlgMsg;
            if (cakeOrder == null)
            {
                MessageBox.Show("Empty Cart.");
                return;
            }
            if (cakeOrder.CalculateTotal() == 0)
            {
                MessageBox.Show("Empty Cart.");
                return;
            }
            dlgMsg = MessageBox.Show(cakeOrder.ToString(), "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //confirm order
            if (dlgMsg == DialogResult.Yes)
            {
                MessageBox.Show(cakeOrder.Confirmation());
                cakeOrder.clearcart();
            }
            btnReset.Focus();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cakeOrder.clearcart();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            string carttotal = "";
          //  string[] cakes;

           /* string result = "";
            result += "The number of items are: " + refrigerators.Count + Environment.NewLine + "The details are : " + Environment.NewLine;
            for (int i = 0; i < refrigerators.Count; i++)
            {
                result += refrigerators[i].ToString() + Environment.NewLine;
            }
            MessageBox.Show(result);*/

            if (cakeOrder == null)
            {
                MessageBox.Show("Empty Cart.");
                return;
            }
            if (cakeOrder.CalculateTotal() == 0)
            {
                MessageBox.Show("Empty Cart.");
                return;
            }
           //cakes[0] = cakeOrder.ToString();
     
            MessageBox.Show(cakeOrder.ToString());

        }

        private void lstSC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
