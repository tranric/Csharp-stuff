using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalParts
{
    public partial class frmSelect : Form
    {
        public String id = "text value";
        public String name = "text value";
        public double price = 0;
        public frmSelect()
        {
            InitializeComponent();
            BusinessClasses.Class1 carParts = new BusinessClasses.Class1();
            //I'm not sure why it keeps repeating the same values. I ended up sepending too much time trying to figure it out.
            for (int i = 0; i < carParts.listOfParts.Length+1; i++)
            {
                cmbParts.Items.Add(carParts.getParts());
            }
            setDetails();
            cmbParts.SelectedIndex = 0;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate();
            update.ShowDialog();
        }

        private void cmbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDetails();
        }
        public void setDetails(){
            if (cmbParts.SelectedIndex == 0)
            {
                id = "CR-7214";
                name = "CAR REPAIR RAMPS";
                price = 339.99;
            }
            if (cmbParts.SelectedIndex == 1)
            {
                id = "RWL-01";
                name = "RECHARGEABLE WORK LIGHT";
                price = 29.99;
            }
            if (cmbParts.SelectedIndex == 2)
            {
                id = "BW-WD-2";
                name = "WHEEL DOLLIES";
                price = 59.99;
            }
            if (cmbParts.SelectedIndex == 3)
            {
                id = "RLB-54";
                name = "ROOF CROSSBARS";
                price = 29.99;
            }
            if (cmbParts.SelectedIndex == 4)
            {
                id = "RHBM-2";
                name = "2 BALL TRAILER MOUNT";
                price = 24.99;
            }
            lblID.Text = id;
            lblName.Text = name;
            lblPrice.Text = price.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
