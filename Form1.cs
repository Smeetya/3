using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double a =0,b =0,c =0;
        char znak = '+';

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (textBox1.Text[0] == '-') {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else textBox1.Text = '-' + textBox1.Text;
            }


                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble (textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = Math.Sqrt(f);
            textBox1.Text = Convert.ToString(d);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(textBox1.Text);
            d = Math.Cos(f);
            textBox1.Text = Convert.ToString(d);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            f = Convert.ToDouble(textBox1.Text);
            d = Math.Sin(f);
            textBox1.Text = Convert.ToString(d);
        }
        double f, d;
        private void button22_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '/':
                    c = a / b;
                    if (b==0)
                    {
                        MessageBox.Show("You cannot divide on zirrow!!!");
                        textBox1.Text = "error";
                    }
                    break;
                case 'x':
                    c = a * b;
                    break;

            }
            textBox1.Text = c.ToString();
        }
    }
}
