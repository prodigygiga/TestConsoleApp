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
        //int sum = 0;
        //int a = 0;
        //int b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();
            //int sum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;


            //}
            //MessageBox.Show(sum.ToString());

            uint x = uint.MaxValue;
            MessageBox.Show(x.ToString());
            uint y = x + 1;
            MessageBox.Show(y.ToString());
            
            Person p1 = new Person();
            p1.FirstName = "dea";
            p1.LastName = "kapanadze";
            p1.BirthDate = new DateTime(1997, 1, 8);
            p1.Height = 170;
            int deaAge = p1.CalculatePersonAge();
            people.Add(p1);
            //MessageBox.Show(deaAge.ToString());
            //p1.PrintInfo();
            //p1.PrintInfo("GE");
            //p1.PrintInfo(2423);
            //MessageBox.Show(p1.IsOddCharsInFirstName().ToString());



            Person p2 = new Person();
            p2.FirstName = "nato";
            p2.LastName = "labadze";
            p2.BirthDate = new DateTime(1997, 10, 14);
            p2.Height = 170;
            people.Add(p2);

            Person p3 = new Person("giorgi", "gogokhia", 186, new DateTime(1997, 10, 20));
            string result = p3.GetPrintData("GE");
            int age = p3.CalculatePersonAge();
            int charCount = p3.CalculateCharsInPerson();
            people.Add(p3);
            //MessageBox.Show(p3.IsOddCharsInFirstName().ToString());


            foreach (var item in people)
            {
                if (!item.IsOddCharsInFirstName())
                {
                    //MessageBox.Show(item.GetPrintData("GR"));
                }
            }


            int k = 0;

            #region MyRegion
            ////int a = 5;


            //// stack  -  value types      - Immutable way string
            //// int , bool, double, float

            ////heap  -  reference types    mutable way  - string
            //// string, class , object


            ////int b = 5;
            ////int c = b;
            ////b = 3;
            ////int d = ++c;
            ////c = 10;
            ////MessageBox.Show("c = " + c.ToString());

            ////Person p1 = new Person();
            ////p1.FirstName = "giorgi";
            ////p1.LastName = "gogokhia";
            ////p1.BirthDate = new DateTime(1997, 7, 9);

            ////Person p2 = new Person();
            ////p2.FirstName = p1.FirstName;
            ////MessageBox.Show("FirstName = " + p2.FirstName);


            ////p1.LastName = "dea";

            //bool k = true;
            //bool t = false;
            //if (t & t)
            //{
            //    MessageBox.Show("ok");
            //}
            //else
            //{
            //    MessageBox.Show("not ok");
            //}



            ////string a = "saba";
            ////string b = a;
            ////a = "tako";
            ////MessageBox.Show(b);

            ////if ( a == 5)
            ////{
            ////    MessageBox.Show("a = 5");
            ////}
            ////else if ( a == 6 )
            ////{
            ////    MessageBox.Show("a = 6");
            ////}
            ////else if (a == 7)
            ////{
            ////    MessageBox.Show("a = 7");
            ////}
            ////else
            ////{
            ////    MessageBox.Show("a = 0");
            ////}

            ////int x = a == 5 ? 1 : 0;

            ////int y = a++;

            ////a = a + 1;
            ////int y = a;

            ////int y = a;
            ////a = a + 1;

            ////a /= 5;
            ////double result = Convert.ToDouble(a) / 5;
            ////switch (a)
            ////{
            ////    case 5:
            ////        MessageBox.Show("a = 5");
            ////        break;
            ////        goto case 7;
            ////    case 6:
            ////    case 9:
            ////        MessageBox.Show("a = 6 or 9");
            ////        break;
            ////    case 7:
            ////        MessageBox.Show("a = 7");
            ////        break;
            ////    default:
            ////        MessageBox.Show("a = 0");
            ////        break;

            ////} 
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sum = Convert.ToInt32(txt_number1.Text) + Convert.ToInt32(txt_number2.Text);
            //lbl_sum.Text = sum.ToString();
        }
    }
}
