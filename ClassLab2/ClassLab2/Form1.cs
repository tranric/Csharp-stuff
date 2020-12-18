using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            this.txtRoot.Text = (Math.Sqrt((double)nudNumber.Value)).ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
