using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string result;
        private string perivous;
        private bool afterCal;
        public Form1()
        {
            InitializeComponent();
            afterCal = false;
        }
        private void form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on " + sender.ToString() + "??! Calm down!");
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            perivous = "";
        }

        private void digit0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            previousUpdater("0", afterCal);
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            previousUpdater("1", afterCal);
        }

        private void digit2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            previousUpdater("2", afterCal);
        }

        private void digit3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            previousUpdater("3", afterCal);
        }

        private void digit4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            previousUpdater("4", afterCal);
        }

        private void digit5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            previousUpdater("5", afterCal);
        }

        private void digit6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            previousUpdater("6", afterCal);
        }

        private void digit7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            previousUpdater("7", afterCal);
        }

        private void digit8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            previousUpdater("8", afterCal);
        }

        private void digit9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            previousUpdater("9", afterCal);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            perivous += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            perivous += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            perivous += "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            perivous += "/";
        }

        private void openP_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
            perivous += "(";
        }

        private void closeP_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
            perivous += ")";
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            perivous += ".";
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            var res = cal(textBox1.Text);
            result = res.ToString();

            textBox2.Text = perivous;
            textBox1.Text =  result;
            afterCal = true;
        }
        private object cal(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();

            //text.TrimStart(' ');
            //text.TrimStart('=');
            //textBox1.Text = text;

            try
            {
                v = dt.Compute(text, "");
            }
            catch (Exception e)
            {
                v = "Wrong Expression!";
            }

            return v;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            perivous = "";
            textBox2.Text = perivous;
            afterCal = true;
        }

        private void previousUpdater(string x, bool y)
        {
            if (y == false)
            {
                perivous += x;
            }
            else
            {

                perivous = textBox1.Text;
            }
        }
    }
}
