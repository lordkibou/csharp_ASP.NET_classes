using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_demo_practicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstInput = Convert.ToInt16(input1.Text);
            int secondInput = Convert.ToInt16(input2.Text);
            MessageBox.Show(oddOrEven(firstInput) + Environment.NewLine + multiple(firstInput,secondInput)+ Environment.NewLine + Environment.NewLine +
                oddOrEven(secondInput) + Environment.NewLine + multiple(secondInput, firstInput));
        }

        private string oddOrEven(int inputNumber)
        {
            if (inputNumber % 2 != 0)
            {
                return inputNumber + " is odd";
            }
            else
            {
                return inputNumber + " is even";
            }
        }
        private string multiple(int first, int second)
        {
            if (first % second == 0)
            {
                return first + " is a multiple of " + second;
            }
            else
            {
                return first + " is not a multiple of " + second;
            }
        }
    }
}
