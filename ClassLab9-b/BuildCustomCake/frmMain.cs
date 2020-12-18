using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildCustomCake
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || txtAddress.Text == "" ||
                txtCity.Text == "" || txtProvince.Text == "" || txtPC.Text == "")
            {
                MessageBox.Show("Please fill in the missing data.", "Data Missing");
                txtFName.Focus();
                return;
            }
            else
            {
                frmMain.ActiveForm.Hide();
                new frmCake().Show();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtProvince.Text = "";
            txtPC.Text = "";
            txtFName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblProvince_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        } 
    }
}
