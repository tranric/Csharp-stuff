using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StpDate.Text +=" "+ DateTime.Now.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdDialog = new OpenFileDialog();
            opdDialog.Title = "Choose the picture to open";
            opdDialog.FileName = "";
            opdDialog.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
          //  opdDialog.ShowDialog();
            if (opdDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                piccake.Image = Image.FromFile(opdDialog.FileName);
                Lblcakename.Text = System.IO.Path.GetFileNameWithoutExtension(opdDialog.SafeFileName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSMIBrowse.PerformClick();
        }
    }
}
