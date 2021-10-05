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
            string k = "test";
            float f = 10.5f;
            double d = 15.2;
            decimal dc = 16.2313m;
            
            if (f == 10.5f)
            {

            }

        }

        private void txt_number1_TextChanged(object sender, EventArgs e)
        {
            if (txt_number1.Text == "")
            {
                sum -= a;
                lbl_sum.Text = sum.ToString();
                //MessageBox.Show("შემოიტანეთ რიცხვი 1!");
            }
            else
            {
                a = Convert.ToInt32(txt_number1.Text);
                sum += a;
                lbl_sum.Text = sum.ToString();
            }

        }

        private void txt_number2_TextChanged(object sender, EventArgs e)
        {
            if (txt_number2.Text == "")
            {
                sum -= b;
                lbl_sum.Text = sum.ToString();
                //MessageBox.Show("შემოიტანეთ რიცხვი 2!");
            }
            else
            {
                b = Convert.ToInt32(txt_number2.Text);
                sum += b;
                lbl_sum.Text = sum.ToString();
            }
            
        }
    }
}
