using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    public partial class frmRefrigerator : Form
    {
        public frmRefrigerator()
        {
            InitializeComponent();
        }

        private void radFull_CheckedChanged(object sender, EventArgs e)
        {
            grpFull.Enabled = true;
            grpCompact.Enabled = false;
        }

        private void radCompact_CheckedChanged(object sender, EventArgs e)
        {
            grpFull.Enabled = false;
            grpCompact.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            String sizeString = "";
            String starRatedString = "";
            if (chkEnergy.Checked == true)
            {
                starRatedString = "\nEnergy Star Rated";
            }
            if (radCompact.Checked == true)
            {
                sizeString = "\nCompact with " + nudShelves.Value + " shelves";
            }
            else if (radFull.Checked == true)
            {
                sizeString = "\nFull Size";
                if (lstFeatures.SelectedItems.ToString()!=(""))
                {
                    sizeString += "\nFeatures: " + AddFeature();
                    
                }
            }

            if (txtMakeModel.Text!="")
            {
                MessageBox.Show("Refrigerator: " + txtMakeModel.Text + "\nCapacity: " + nudCapacity.Value + starRatedString + sizeString, "");
            }
            else
            {
                MessageBox.Show("Please enter a make and model", "Data Error");
            }
        }
        private String AddFeature()
        {
            int counter1 = 0;
            String featureString = "";
            for (int count = lstFeatures.SelectedItems.Count; count > 0; count--)
            {
                if (lstFeatures.SelectedItems[counter1].ToString().Equals("Ice maker"))
                {
                    featureString += "\n\tIce maker";
                }

                else if (lstFeatures.SelectedItems[counter1].ToString().Equals("Touch controls"))
                {
                    featureString += "\n\tTouch controlsr";
                }

                else if (lstFeatures.SelectedItems[counter1].ToString().Equals("Spill safe shelves"))
                {
                    featureString += "\n\tSpill safe shelves";
                }

                else if (lstFeatures.SelectedItems[counter1].ToString().Equals("Deli Drawer"))
                {
                    featureString += "\n\tDeli Drawer";
                }
                counter1++;
                count = 0;
            }
                return featureString;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMakeModel.Text = "";
            radCompact.Checked = true;
            radFull.Checked = false;
            chkEnergy.Checked = false;
            grpCompact.Enabled=true;
            grpFull.Enabled = false;
            nudShelves.Value = 2;
            nudCapacity.Value = 25;
        }
    }
}
