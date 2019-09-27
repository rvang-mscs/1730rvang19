using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double subtotal = double.Parse(txtSubtotal.Text);
            double discount = double.Parse(txtDiscountPercent.Text);
            double DiscountAMT = discount * subtotal;
            double divide = DiscountAMT / 100;
            double Newdivide = Math.Round(divide, 2);
            string discountamount = Newdivide.ToString();
            txtDiscountAmount.Text = discountamount;

            double total = double.Parse(txtSubtotal.Text);
            double DiscountAmoun = double.Parse(txtDiscountAmount.Text);
            double subtract = total - DiscountAmoun;
            double Round = Math.Round(subtract, 2);
            string String = Round.ToString();
            txtTotal.Text = String;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
