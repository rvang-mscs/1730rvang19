using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex1E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            double Test1 = double.Parse(txtTest1.Text);
            double Test2 = double.Parse(txtTest2.Text);
            double Test3 = double.Parse(txtTest3.Text);
            double Total = Test1 + Test2 + Test3;
            double Divide = Total / 3;
            double NewTotal = Math.Round(Divide, 2);
            double AverageTotal = NewTotal;
            string TotalString = AverageTotal.ToString();
            txtAverage.Text = TotalString;
            //txtAverage.Text = (Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest2.Text) + Convert.ToDecimal(txtTest3.Text) / 3).ToString("0.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = ("0");
            txtTest2.Text = ("0");
            txtTest3.Text = ("0");
            txtAverage.Text = ("");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
