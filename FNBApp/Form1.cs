using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtNum1.Text = string.Empty;
            //txtNum2.Text = string.Empty;
            //lblResult.Text = string.Empty;

            txtNum1.Text = " ";
            txtNum2.Clear();
            lblResult.Text = " ";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare variables
            int num1, num2, sum = 0;

            //Assign values
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            
            //perform calculations
            //Create an object
            Calculator obj = new Calculator(); 

            //Display a welcome message
            Calculator objNew = new Calculator(num1, num2);
            sum = objNew.calculateSum();

            //Display
            lblResult.Text = sum.ToString();
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum3Num_Click(object sender, EventArgs e)
        {

        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {

        }
    }
}
