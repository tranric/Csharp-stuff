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
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radCustom_CheckedChanged(object sender, EventArgs e)
        {
            lstCakes.Enabled = false;
            grpCustomCake.Enabled = true;
        }

        private void radSpecial_CheckedChanged(object sender, EventArgs e)
        {
            lstCakes.Enabled = true;
            grpCustomCake.Enabled = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rad5inch.Checked = true;
            radChocolate.Checked = true;
            rad1layer.Checked = true;
            radCustom.Checked = true;
            lstCakes.ClearSelected();
            btnCheck.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radCustom.Checked)
            {
                string flavour;
                int size;
                int layers;

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

            }

            btnReset.Focus();
        }

        private void radBanana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad5inch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCake_Load(object sender, EventArgs e)
        {

        }
    }
}
