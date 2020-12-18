using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmBranch : Form
    {
        public double totalSaes = 0;
        public frmBranch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 branch = new Form2();
            branch.ShowDialog();
            string cityName = branch.city, cityValue = branch.cost;
            if (cityName != null)
            {
                string cityInfo = cityName + " - $" + cityValue;
                totalSaes += Double.Parse(cityValue);
                lblTotalValue.Text = totalSaes.ToString(); 
                lstBranch.Items.Add(cityInfo);
            }
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
