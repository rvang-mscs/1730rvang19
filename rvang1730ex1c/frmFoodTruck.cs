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

            //Minnesota Tax
            double mnTax = 6.875 / 100;

            //create double variable to convert value inside Pretax into double
            double tax = double.Parse(txtPreTax.Text);

            //create double to temporary store the product of tax and mnTax
            double tax2 = tax* mnTax;
           
            //convert temporary into string
            string taxString = Math.Round(tax2, 2).ToString();
            
            //txtTax = (Convert.ToDecimal(txtPreTax.Text) * ;
            
            //put back inside the box by converting string into whatever the box type is 
            txtTax.Text = taxString;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //add pretax total and tax then convert that name to double then use math.round to cut off 
            //zeros then convert it back to string and put it inside textbox.
            //round to 2 decimal place

            //convert pretax total to double and convert tax to double then add then use math.round to get to 2 place deciaml
            //then convert back to string and put string inside textbox but using txtTotal.Text.

            //Math.Round( variable name to total of both, 2);

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
    }
}