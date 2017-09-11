using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        //int intNum1 = 5;        // class variable

        public Form1()
        {
            InitializeComponent();

            
            float floatNum1 = 5.7f;
            double doubleNum1 = 5.2;
            decimal decimalNum1 = 5.9M;

            string stringText = "sdfjdsklfsjd";
            bool boolVal = true;
            char charVal = 'c';

            var decimalNum2 = 50.25M;

            int intNum2 = 2147483647;
            intNum2++;
            //MessageBox.Show(intNum2.ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(textBox1.Text);
            double input2 = double.Parse(textBox2.Text);
            double answer = input1 * input2;

            labelOutput.Text = answer.ToString("n2");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        //MessageBox.Show(intNum1.ToString());

    }
}
