using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
            InitializeComponent();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            opdFile.Title = "Open a picture";
            opdFile.FileName = String.Empty;
            opdFile.Filter = "Image files(*.jpg, *.gif, *.bmp, *.png)|*.jpg;*.gif;*.bmp;*.png|All Files (*.*)|*.*|icon files(*.ico)|*.ico";
            if (opdFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picDisplay.Image = Image.FromFile(opdFile.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuOptionsColour_Click(object sender, EventArgs e)
        {
            codColour.AllowFullOpen = false;
            codColour.ShowDialog();
            BackColor = codColour.Color;
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            codColour.AllowFullOpen = false;
            codColour.ShowDialog();
            BackColor = codColour.Color;
        }
    }
}
