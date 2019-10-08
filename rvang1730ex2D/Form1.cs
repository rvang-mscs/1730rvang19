using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rvang1730ex2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPassValues_Click(object sender, EventArgs e)
        {
            txtBoxFrank.Text = "Frank";
            txtBoxEmpty.Text = "";
            txtBox23.Text = "2.3";
            txtBoxFalse.Text = "False";
            txtBoxA.Text = "2";
            txtBoxB.Text = "2";
            txtBoxNotJones.Text = "Alex";
            txtBoxNot0.Text = "1";
            txtBoxA2.Text = "1";
            txtBoxB2.Text = "2";
            txtBoxMore500.Text = "500";
            txtBoxA3.Text = "3";
            txtBoxB3.Text = "3";
        }

        private void BtnFailValues_Click(object sender, EventArgs e)
        {
            txtBoxFrank.Text = "Duck";
            txtBoxEmpty.Text = "5";
            txtBox23.Text = "2";
            txtBoxFalse.Text = "True";
            txtBoxA.Text = "6";
            txtBoxB.Text = "4";
            txtBoxNotJones.Text = "Jones";
            txtBoxNot0.Text = "0";
            txtBoxA2.Text = "6";
            txtBoxB2.Text = "1";
            txtBoxMore500.Text = "499";
            txtBoxA3.Text = "4";
            txtBoxB3.Text = "23";
        }

        private void BtnCaculate_Click(object sender, EventArgs e)
        {

            txtBox1A.Text = "Fail";
            txtBox2A.Text = "Fail";
            txtBox3A.Text = "Fail";
            txtBox4A.Text = "Fail";
            txtBox5A.Text = "Fail";
            txtBox6A.Text = "Fail";
            txtBox7A.Text = "Fail";
            txtBox8A.Text = "Fail";
            txtBox9A.Text = "Fail";
            txtBox10A.Text = "Fail";

            txtBox1B.Text = "Success";
            txtBox2B.Text = "Success";
            txtBox3B.Text = "Success";
            txtBox4B.Text = "Success";
            txtBox5B.Text = "Success";
            txtBox6B.Text = "Success";
            txtBox7B.Text = "Success";
            txtBox8B.Text = "Success";
            txtBox9B.Text = "Success";
            txtBox10B.Text = "Success";

            if (txtBoxFrank.Text == "Frank")
                txtBox1A.Text = "Success";
            if (txtBoxFrank.Text == "Frank")
                txtBox1B.Text = "Fail";

            if (txtBoxEmpty.Text == "")
                txtBox2A.Text = "Success";
            if (txtBoxEmpty.Text == "")
                txtBox2B.Text = "Fail";

            decimal var1 = Convert.ToDecimal(txtBox23.Text);
            if (var1 == 2.3m)
                txtBox3A.Text = "Success";
            if (var1 == 2.3m)
                txtBox3B.Text = "Fail";

            bool var2 = Convert.ToBoolean(txtBoxFalse.Text);
            if (var2 == false)
                txtBox4A.Text = "Success";
            if (var2 == false)
                txtBox4B.Text = "Fail";

            decimal var3 = Convert.ToDecimal(txtBoxA.Text);
            decimal var4 = Convert.ToDecimal(txtBoxB.Text);
            if (var3 == var4)
                txtBox5A.Text = "Succes";
            if (var3 == var4)
                txtBox5B.Text = "Fail";

            if (txtBoxNotJones.Text == "Alex")
                txtBox6A.Text = "Success";
            if (txtBoxNotJones.Text == "Alex")
                txtBox6B.Text = "Fail";

            decimal var5 = Convert.ToDecimal(txtBoxNot0.Text);
            if (var5 == 1m)
                txtBox7A.Text = "Success";
            if (var5 == 1m)
                txtBox7B.Text = "Fail";

            decimal var6 = Convert.ToDecimal(txtBoxB2.Text);
            if (var6 == 2m)
                txtBox8A.Text = "Success";
            if (var6 == 2m)
                txtBox8B.Text = "Fail";

            decimal var7 = Convert.ToDecimal(txtBoxMore500.Text);
            if (var7 == 500)
                txtBox9A.Text = "Success";
            if (var7 == 500)
                txtBox9B.Text = "Fail";

            decimal var8 = Convert.ToDecimal(txtBoxA3.Text);
            decimal var9 = Convert.ToDecimal(txtBoxB3.Text);
            if (var8 == var9)
                txtBox10A.Text = "Success";
            if (var8 == var9)
                txtBox10B.Text = "Fail";
        }
    }
}
