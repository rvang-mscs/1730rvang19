using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMerkia_Click(object sender, EventArgs e)
        {
            btnMerkia.BackgroundImage = picMerkia.Image;
            btnBrazil.BackgroundImage = picBrazilDark.Image;
            btnMexico.BackgroundImage = picMexicoDark.Image;
            btnFrance.BackgroundImage = picFranceDark.Image;
            lblCurrency.Text = btnMerkia.Text;
            txtRate.Text = "1.00000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMerkia.BackgroundImage = picMerkiaDark.Image;
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnMexico.BackgroundImage = picMexicoDark.Image;
            btnFrance.BackgroundImage = picFranceDark.Image;
            txtRate.Text = "0.245251";
            lblCurrency.Text = btnBrazil.Text + ": ";
        }

        private void BtnBrazil_Click(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnMerkia.BackgroundImage = picMerkiaDark.Image;
            btnMexico.BackgroundImage = picMexicoDark.Image;
            btnFrance.BackgroundImage = picFranceDark.Image;
            lblCurrency.Text = btnBrazil.Text;
            txtRate.Text = "0.245251";
        }

        private void BtnFrance_Click(object sender, EventArgs e)
        {
            btnFrance.BackgroundImage = picFrance.Image;
            btnMerkia.BackgroundImage = picMerkiaDark.Image;
            btnBrazil.BackgroundImage = picBrazilDark.Image;
            btnMexico.BackgroundImage = picMexicoDark.Image;
            lblCurrency.Text = btnFrance.Text;
            txtRate.Text = "1.10654";
        }

        private void BtnMexico_Click(object sender, EventArgs e)
        {
            btnMexico.BackgroundImage = picMexico.Image;
            btnMerkia.BackgroundImage = picMerkiaDark.Image;
            btnBrazil.BackgroundImage = picBrazilDark.Image;
            btnFrance.BackgroundImage = picFranceDark.Image;
            lblCurrency.Text = btnMexico.Text;
            txtRate.Text = "0.0516170";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
          txtUSD.Text = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtDollar.Text)).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDollar_Enter(object sender, EventArgs e)
        {
            txtDollar.SelectAll();
        }

        private void TxtDollar_Click(object sender, EventArgs e)
        {
            txtDollar.SelectAll();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double USD = double.Parse(txtUSD.Text);
            double Total = double.Parse(txtTotal.Text);
            double add = Total + USD;
            double round = Math.Round(add, 2);
            string Total2 = round.ToString();
            txtTotal.Text = Total2;

            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;


        }

        private void TxtUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void LblEquation_Click(object sender, EventArgs e)
        {
            ;
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
          
            lblEquation.Text = String.Empty;
            txtDollar.Text = "0.00";
            txtUSD.Text = "0.00";
            txtRate.Text = "0.245251";
            txtTotal.Text = "0.00";
            btnBrazil.BackgroundImage = picBrazil.Image;
            lblCurrency.Text = btnBrazil.Text + ": ";
            btnMerkia.BackgroundImage = picMerkiaDark.Image;
            btnMexico.BackgroundImage = picMexicoDark.Image;
            btnFrance.BackgroundImage = picFranceDark.Image;
        }
    }
}
