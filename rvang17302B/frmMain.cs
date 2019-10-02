using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang17302B
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountMexico = 10m;
            decimal rateMexico = 0.0511047m;
            decimal usdMeixco = rateMexico * amountMexico;

            decimal amountFrance = 100m;
            decimal rateFrance = 1.10449m;
            decimal usdFrance = amountFrance * rateFrance;

            decimal amountRussia = 100m;
            decimal rateRussia = 0.0152555m;
            decimal usdRussia = amountRussia * rateRussia;


            decimal totalUSD = usdFrance + usdMeixco + usdRussia;
        }

        private void USDChanged(object sender, EventArgs e)
        {

        }
    }
}
