using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class mainPage : Form
    {
        bool txtBoxOpW = false;
        bool txtBox1W = true;
        bool txtBox2W = false;
        public mainPage()
        {
            InitializeComponent();
        }
        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '-' && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void checkBoxPower_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPower.Checked == true)
            {
                txtBoxOp.Text = "Power to";
                txtBoxOp.Enabled = false;
            }
            else
            {
                txtBoxOp.Text = null;
                txtBoxOp.Enabled = true;
                txtBoxOp.Text = "Operator";
            }
                
        }

        private void mainPage_MouseClick(object sender, MouseEventArgs e)
        {
            txtBox1W = false;
            txtBox2W = false;
            txtBoxOpW = false;
        }

        private void txtBoxOp_MouseClick(object sender, MouseEventArgs e)
        {
            txtBoxOpW = true;
            txtBox1W = false;
            txtBox2W = false;
        }

        private void txtBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtBox1W = true;
            txtBox2W = false;
            txtBoxOpW = false;
        }

        private void txtBox2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBox2W = true;
            txtBox1W = false;
            txtBoxOpW = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "1";
            else if (txtBox2W == true)
                txtBox2.Text += "1";      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "2";
            else if (txtBox2W == true)
                txtBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "3";
            else if (txtBox2W == true)
                txtBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "4";
            else if (txtBox2W == true)
                txtBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "5";
            else if (txtBox2W == true)
                txtBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "6";
            else if (txtBox2W == true)
                txtBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "7";
            else if (txtBox2W == true)
                txtBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "8";
            else if (txtBox2W == true)
                txtBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "9";
            else if (txtBox2W == true)
                txtBox2.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += "0";
            else if (txtBox2W == true)
                txtBox2.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (txtBox1W == true)
                txtBox1.Text += ".";
            else if (txtBox2W == true)
                txtBox2.Text += ".";
        }

        private void buttonModulus_Click(object sender, EventArgs e)
        {
            txtBoxOp.Text = "%";
            txtBox2W = true;
            txtBox1W = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            txtBoxOp.Text = "+";
            txtBox2W = true;
            txtBox1W = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (txtBoxOpW == true)
            {
                txtBoxOp.Text = "-";
                txtBox2W = true;
                txtBox1W = false;
            }
            else if (txtBox1W == true)
                txtBox1.Text += "-";
            else if (txtBox2W == true)
                txtBox2.Text += "-";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            txtBoxOp.Text = "*";
            txtBox2W = true;
            txtBox1W = false;
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            txtBoxOp.Text = "/";
            txtBox2W = true;
            txtBox1W = false;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtBoxOp.Text = null;
            txtBox2.Text = null;
            txtBox1.Text = null;
            txtBox1W = true;
        }

        private void buttonEqualTo_Click(object sender, EventArgs e)
        {
            ClassCalculator Clacu = new ClassCalculator();
            if (checkBoxPower.Checked == true)
            {
                lblResault.Text = Convert.ToString(Clacu.powerNums(txtBox1.Text, txtBox2.Text));
            }
            else if (txtBoxOp.Text == "%")
            {
                lblResault.Text = Convert.ToString(Clacu.ModulusNums(txtBox1.Text, txtBox2.Text));
            }
            else if (txtBoxOp.Text == "+")
            {
                lblResault.Text = Convert.ToString(Clacu.plusNums(txtBox1.Text, txtBox2.Text));
            }
            else if (txtBoxOp.Text == "-")
            {
                lblResault.Text = Convert.ToString(Clacu.minusNums(txtBox1.Text, txtBox2.Text));
            }
            else if (txtBoxOp.Text == "*")
            {
                lblResault.Text = Convert.ToString(Clacu.multiplyNums(txtBox1.Text, txtBox2.Text));
            }
            else if (txtBoxOp.Text == "/")
            {
                lblResault.Text = Convert.ToString(Clacu.devideNumes(txtBox1.Text, txtBox2.Text));
            }


        }

       


    }
}
