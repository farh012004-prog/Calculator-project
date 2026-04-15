using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_اله_حاسبه_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string C;
        double x;
        private void button9_Click(object sender, EventArgs e)
        {
            Button bu = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + bu.Text;
            if (textBox1.Text == "." &&  bu.Text == ".")
                textBox1.Text = "0.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button bu = (Button)sender;
            C = bu.Text;
            x =   Convert.ToDouble   ( textBox1.Text);
            label1.Text = textBox1.Text + " " + C;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        { 
            switch (C)
            {

                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x + y).ToString();
                        label1.Text = "";
                    }
                    break;

                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x - y).ToString();
                        label1.Text = "";
                    }
                    break;

                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x * y).ToString();
                        label1.Text = "";
                    }
                    break;

                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (x / y).ToString();
                        label1.Text = "";
                    }
                    break;



            }
            
            
                
            
            

                    
            
                

            
  
            

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                Button bu = (Button)sender;
                if (textBox1.Text == "0")
                    textBox1.Clear();
                textBox1.Text = textBox1.Text + bu.Text;
                if (textBox1.Text == "." && bu.Text == ".")
                    textBox1.Text = "0.";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          //التحكم من الكيبورد
            switch (e.KeyChar)
            {
                
                case '+':
                    {
                        e.Handled = true;
                        button15.PerformClick();

                    }break;
                case '-':
                    {
                        e.Handled = true;
                        button15.PerformClick();

                    }
                    break;
                case '*':
                    {
                        e.Handled = true;
                        button15.PerformClick();

                    }
                    break;
                case '/':
                    {
                        e.Handled = true;
                        button15.PerformClick();

                    }
                    break;
                case (char)Keys.Enter:
                    {
                        e.Handled = true;
                        button16.PerformClick();
                    }break;
                case (char)Keys.Back:

                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':

                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("enter the number only");
                    break;





            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
