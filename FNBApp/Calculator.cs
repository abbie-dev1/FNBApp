using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNBApp
{
    public class Calculator
    {
        //Data members
        public int num1 { get; set; }
        public int num2 { get; set; }

        //Construtor
        public Calculator() 
        {
            num1 = 0;
            num2 = 0;
            MessageBox.Show("This program will find the sum of two(2) numbers.");
        }
        //Overload/override???
        public Calculator(int x, int y)
        {
            num1 = x;
            num2 = y;
        }

        //Method to calculate sum
        public int calculateSum()
        {
            return num1 + num2;
        }
    }
}
