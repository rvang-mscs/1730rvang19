using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtMexico.Text = ("0.00");
            txtRateMexico.Text = ("0.0511047");
            txtFrance.Text = ("0.00");
            txtRateFrance.Text = ("1.10449");
            txtRussia.Text = ("0.00");
            txtRateRussia.Text = ("0.0152555");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mexicoTextChanged(object sender, EventArgs e)
        {
            txtUSDMexico.Text = (Convert.ToDecimal(txtMexico.Text) * Convert.ToDecimal(txtRateMexico.Text)).ToString("0.00");
        }

        private void franceTextChanged(object sender, EventArgs e)
        {

            txtUSDFrance.Text = (Convert.ToDecimal(txtFrance.Text) * Convert.ToDecimal(txtRateFrance.Text)).ToString("0.00");
        }

        private void russiaTextChanged(object sender, EventArgs e)
        {

            txtUSDRussia.Text = (Convert.ToDecimal(txtRussia.Text) * Convert.ToDecimal(txtRateRussia.Text)).ToString("0.00");
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (99m).ToString("0.00");
        }

        private void TxtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDMexico.Text) + Convert.ToDecimal(txtUSDFrance.Text) + Convert.ToDecimal(txtUSDRussia.Text)).ToString("0.00");
        }
    }
}
