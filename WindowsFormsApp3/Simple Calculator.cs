using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public double num1 = 0;
        public double num2 = 0;
        public int operator1 = 0;
        public double ans = 0;
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCalc.Text = "0";
            txtCalc.Enabled = false;
            
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if(txtCalc.Text.Contains(".") == false)
            {
                txtCalc.Text = txtCalc.Text + ".";
            }
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "0";
            
            else
                txtCalc.Text = txtCalc.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtCalc.Text == "0")
                txtCalc.Text = "";

            txtCalc.Text = txtCalc.Text + "9";
        }
                                                                                                                                                                                                private void lblWatermark_MouseHover(object sender, EventArgs e)
                                                                                                                                                                                                {
                                                                                                                                                                                                    //Watermark ko'to
                                                                                                                                                                                                }
        //Here are the operations
        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            num2 = Convert.ToDouble(txtCalc.Text);
            if (operator1 == 2)
            {
                ans = num1 + num2;
                txtPrev.Text = txtPrev.Text + txtCalc.Text + "=" + Convert.ToString(ans);
                txtCalc.Text = Convert.ToString(ans);
            }
            else if (operator1 == 1)
            {
                ans = num1 - num2;
                txtPrev.Text = txtPrev.Text + txtCalc.Text + "=" + Convert.ToString(ans);
                txtCalc.Text = Convert.ToString(ans);
            }
            else if (operator1 == 3)
            {
                ans = Math.Pow(num1, num2);
                txtPrev.Text = txtPrev.Text + txtCalc.Text + "=" + Convert.ToString(ans);
                txtCalc.Text = Convert.ToString(ans);
            }
            else if (operator1 == 4)
            {
                ans = num1 * num2;
                txtPrev.Text = txtPrev.Text + txtCalc.Text + "=" + Convert.ToString(ans);
                txtCalc.Text = Convert.ToString(ans);
            }
            else if (operator1 == 5)
            {
                ans = num1 / num2;
                txtPrev.Text = txtPrev.Text + txtCalc.Text + "=" + Convert.ToString(ans);
                txtCalc.Text = Convert.ToString(ans);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            txtPrev.Text = "";
            txtPrev.Text = txtPrev.Text + txtCalc.Text + "-";
            txtCalc.Text = "0";
            operator1 = 1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            txtPrev.Text = "";
            txtPrev.Text = txtPrev.Text + txtCalc.Text + "+";
            txtCalc.Text = "0";
            operator1 = 2;
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            txtPrev.Text = "";
            txtPrev.Text = txtPrev.Text + txtCalc.Text + "^";
            txtCalc.Text = "0";
            operator1 = 3;
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            txtPrev.Text = "";
            txtPrev.Text = txtPrev.Text + txtCalc.Text + "x";
            txtCalc.Text = "0";
            operator1 = 4;
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            txtPrev.Text = "";
            txtPrev.Text = txtPrev.Text + txtCalc.Text + "÷";
            txtCalc.Text = "0";
            operator1 = 5;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text.Substring(0, txtCalc.TextLength - 1);
            if (txtCalc.Text == "")
                txtCalc.Text = "0";
        }

        private void btnallClear_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "0";
        }
    }
}
