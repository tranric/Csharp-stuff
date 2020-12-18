using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class frmMouseMove : Form
    {
        public frmMouseMove()
        {
            InitializeComponent();
        }

        private void lblMouseY_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMouseMove_MouseMove(object sender, MouseEventArgs e)
        {
            this.txtMouseX.Text = e.X.ToString();
            this.txtMouseY.Text = e.Y.ToString();
        }
    }
}
