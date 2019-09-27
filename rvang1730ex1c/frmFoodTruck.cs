using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex1c
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            txtHotdogsTotal.Text = (4.0m * Convert.ToDecimal(txtHotDogs.Text)).ToString("0.00");
            txtHamburgersTotal.Text = (5.0m * Convert.ToDecimal(txtHamburgers.Text)).ToString("0.00");
            txtPreTax.Text = (Convert.ToDecimal(txtHotdogsTotal.Text) + Convert.ToDecimal(txtHamburgersTotal.Text)).ToString("0.00");

            double mnTax = 6.875 / 100;

            double tax = double.Parse(txtPreTax.Text);

            double tax2 = tax* mnTax;
           
            string taxString = Math.Round(tax2, 2).ToString();

            txtTax.Text = taxString;

            double pretax = double.Parse(txtPreTax.Text);
            double Taxadd = double.Parse(txtTax.Text);
            double Total = Taxadd + pretax;
            double newTotal = Math.Round(Total, 2);
            string TotalString = newTotal.ToString();
            txtTotal.Text = TotalString;


            btnClear.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotdogsTotal.Text = "";
            txtHamburgersTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtPreTax.Text = "";

            txtHotDogs.Focus();
        }

        private void TxtHamburgersTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPreTax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}