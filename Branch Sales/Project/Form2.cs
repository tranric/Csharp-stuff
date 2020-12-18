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
    public partial class Form2 : Form
    {

        public int count = 0;
        public string openCityText = "";
        public string city = null;
        public string cost = null;
        public Form2()
        {
            InitializeComponent();
            cmbCities.SelectedIndex = 0;
            picCity.Image = picCity.Image = global::Project.Properties.Resources.DefaultTown;
            getTown();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCities.SelectedIndex = 0;
            picCity.Image = picCity.Image = global::Project.Properties.Resources.DefaultTown;
            lblAmountWarning.Visible = false;
            getTown();
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            picCity.Image = picCity.Image = null;
            getTown();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdDialog = new OpenFileDialog();
            opdDialog.Title = "Choose the picture to open";
            opdDialog.FileName = "";
            opdDialog.Filter = "Image Files (*.jpg)|*.jpg| All Files (*.*) | *.*";
            // opnFileDialog.FilterIndex = 2;
            // opdDialog.ShowDialog();
            if (opdDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openCityText = opdDialog.SafeFileName;
            //This is find the name of the town. If the name of the town is one of the opetion given, 
            //it will select the correct info
                if (openCityText.Contains("Brampton"))
                {
                    cmbCities.SelectedIndex = 0;
                    getTown();
                }
                if (openCityText.Contains("Hamilton"))
                {
                    cmbCities.SelectedIndex = 1;
                    getTown();
                }
                if (openCityText.Contains("Mississauga"))
                {
                    cmbCities.SelectedIndex = 2;
                    getTown();
                }
                if (openCityText.Contains("Oakville"))
                {
                    cmbCities.SelectedIndex = 3;
                    getTown();
                }
                if (openCityText.Contains("Toronto"))
                {
                    cmbCities.SelectedIndex = 4;
                    getTown();
                }
                picCity.Image = Image.FromFile(opdDialog.FileName);
            }
        }

        private void picCity_Click(object sender, EventArgs e)
        {
            if (cmbCities.SelectedIndex == 5)
            {
                count += 1;
                if (count == 2)
                {
                    count = 0;
                }
                if (count == 0)
                {
                    picCity.Image = global::Project.Properties.Resources.Cake;
                }
                if (count == 1)
                {
                    picCity.Image = global::Project.Properties.Resources.CakeAnimated;
                }
            }
        }
        public void getTown()
        {
            //This method holds the basic city info that can be called upon latter
            if (cmbCities.SelectedIndex == 0)
            {
                lblCityAdd.Text = "Brampton";
                lblStreetAdd.Text = "456 Brampton St";
                lblPostalAdd.Text = "K4F 3R3";
                lblPhoneAdd.Text = "905 455 7888";
                if (picCity.Image == null) { picCity.ImageLocation = "Brampton.jpg"; }
            }
            if (cmbCities.SelectedIndex == 1)
            {
                lblCityAdd.Text = "Hamilton";
                lblStreetAdd.Text = "294 Hamilton St";
                lblPostalAdd.Text = "L8E 0G2";
                lblPhoneAdd.Text = "905 587 9985";
                if (picCity.Image == null) { picCity.ImageLocation = "Hamilton.jpg"; }
            }
            if (cmbCities.SelectedIndex == 2)
            {
                lblCityAdd.Text = "Mississauga";
                lblStreetAdd.Text = "789 Mississauga St";
                lblPostalAdd.Text = "L4R 5T7";
                lblPhoneAdd.Text = "905 222 4897";
                if (picCity.Image == null) { picCity.ImageLocation = "Mississauga.jpg"; }
            }
            if (cmbCities.SelectedIndex == 3)
            {
                lblCityAdd.Text = "Oakville";
                lblStreetAdd.Text = "595 Oakville St";
                lblPostalAdd.Text = "L6H 0A7";
                lblPhoneAdd.Text = "594 999 4456";
                if (picCity.Image == null) { picCity.ImageLocation = "Oakville.jpg"; }
            }
            if (cmbCities.SelectedIndex == 4)
            {
                lblCityAdd.Text = "Toronto";
                lblStreetAdd.Text = "123 Toronto St";
                lblPostalAdd.Text = "M3F 4DR";
                lblPhoneAdd.Text = "416 375 7894";
                if (picCity.Image == null) { picCity.ImageLocation = "Toronto.jpg"; }
            }
            if (cmbCities.SelectedIndex == 5)
            {
                lblCityAdd.Text = "Cakeville";
                lblStreetAdd.Text = "594 Cake St";
                lblPostalAdd.Text = "C4C 7S1";
                lblPhoneAdd.Text = "555 555 5555";
                picCity.Image = global::Project.Properties.Resources.Cake;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This cool feature I found stops any characters other then numbers and decimals from being entered
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 127 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                lblAmountWarning.Visible = true;
            }
            else
            {
                var AcceptMessage = MessageBox.Show("Do you want to add this record?\n" + lblCityAdd.Text + "\n$" + txtAmount.Text,
                    "Add Sales Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (AcceptMessage == DialogResult.Yes)
                {
                    city = lblCityAdd.Text;
                    cost = txtAmount.Text;
                    Close();
                }
                if (AcceptMessage == DialogResult.No)
                {
                    txtAmount.Text = "";
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}