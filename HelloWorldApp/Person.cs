using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int height, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Height = height;
            this.BirthDate = birthDate;
        }
        public void PrintInfo()
        {
            MessageBox.Show("Person is : " +LastName + " " + FirstName);
        }

        public void PrintInfo(string language)
        {
            if (language == "GE")
            {
                MessageBox.Show("ეს ადამიანი არის : " + LastName + " " + FirstName);
            }
            else
            {
                MessageBox.Show("Person is : " + LastName + " " + FirstName);
            }
        }

        public string GetPrintData(string language)
        {
            if (language == "GE")
            {
                return "ეს ადამიანი არის : " + LastName + " " + FirstName;
            }
            else
            {
                return "Person is : " + LastName + " " + FirstName;
            }
        }
        public int CalculatePersonAge()
        {
            int age = DateTime.Now.Year - this.BirthDate.Year;
            return age;
        }

        public int CalculateCharsInPerson()
        {
            return (FirstName + LastName).Length;
        }

        public bool IsOddCharsInFirstName()
        {
            return FirstName.Length % 2 == 1;
        }

        public void PrintInfo(int countryZipCode)
        {
            if (countryZipCode == 45254)
            {
                MessageBox.Show("ეს ადამიანი არის : " + LastName + " " + FirstName);
            }
            else
            {
                MessageBox.Show("Person is : " + LastName + " " + FirstName);
            }
        }
        public void PrintInfo(string language,int countryZipCode)
        {
            if (countryZipCode == 45254 && language == "GE")
            {
                MessageBox.Show("ეს ადამიანი არის : " + LastName + " " + FirstName);
            }
            else
            {
                MessageBox.Show("Person is : " + LastName + " " + FirstName);
            }
        }

    }
}
