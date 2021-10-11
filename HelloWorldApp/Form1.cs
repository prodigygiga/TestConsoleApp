using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int a = 0;
        int b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 5;
            
            //if ( a == 5)
            //{
            //    MessageBox.Show("a = 5");
            //}
            //else if ( a == 6 )
            //{
            //    MessageBox.Show("a = 6");
            //}
            //else if (a == 7)
            //{
            //    MessageBox.Show("a = 7");
            //}
            //else
            //{
            //    MessageBox.Show("a = 0");
            //}

            //int x = a == 5 ? 1 : 0;

            //int y = a++;

            //a = a + 1;
            //int y = a;

            //int y = a;
            //a = a + 1;

            //a /= 5;
            //double result = Convert.ToDouble(a) / 5;
            switch (a)
            {
                case 5:
                    MessageBox.Show("a = 5");
                    break;
                    goto case 7;
                case 6:
                case 9:
                    MessageBox.Show("a = 6 or 9");
                    break;
                case 7:
                    MessageBox.Show("a = 7");
                    break;
                default:
                    MessageBox.Show("a = 0");
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = Convert.ToInt32(txt_number1.Text) + Convert.ToInt32(txt_number2.Text);
            lbl_sum.Text = sum.ToString();
        }
    }
}
