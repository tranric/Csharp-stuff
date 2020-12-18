using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public static String First, Last, Address, City, Province, Postal;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtboxfirst.Text == "" || txtboxlast.Text == "" || Txtboxaddress.Text == "" ||
    txtcity.Text == "" || txtprovince.Text == "" || txtpostal.Text == "")
            {
                MessageBox.Show("Please fill in the missing data.", "Data Missing");
                txtboxfirst.Focus();
                return;
            }
            else
            {
                Form1.ActiveForm.Hide();
                new frmCake().Show();
                First = txtboxfirst.Text;
                Last = txtboxlast.Text;
                Address = Txtboxaddress.Text;
                City = txtcity.Text;
                Province = txtprovince.Text;
                Postal = txtpostal.Text;
            }
        }

        private void txtprovince_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxfirst.Text = "";
            txtboxlast.Text = "";
            Txtboxaddress.Text = "";
            txtcity.Text = "";
            txtprovince.Text = "";
            txtpostal.Text = "";
            txtboxfirst.Focus();

        }
    }
}
