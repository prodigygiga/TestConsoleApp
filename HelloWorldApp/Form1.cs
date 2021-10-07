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
            
            string k = "test";
            float f = 10.5f;
            double d = 15.2;
            decimal dc = 16.2313m;
            
            if (f == 10.5f)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = Convert.ToInt32(txt_number1.Text) + Convert.ToInt32(txt_number2.Text);
            lbl_sum.Text = sum.ToString();
        }
    }
}
