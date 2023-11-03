using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2_demo_practicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputFirst= Convert.ToInt16(input1.Text);
            int inputSecond = Convert.ToInt16(input2.Text);
            int inputThird = Convert.ToInt16(input3.Text);
            int inputFour = Convert.ToInt16(input4.Text);

            int[] arrayInputs = {inputFirst,inputSecond,inputThird,inputFour};

            int [] output = countPositiveOrNegativeOrZero(arrayInputs);
            MessageBox.Show(output[0] + " zeros" + Environment.NewLine + output[1] + " positive numbers" +
                Environment.NewLine + output[2] + " negative numbers");
        }
        private int[] countPositiveOrNegativeOrZero(int[] input)
        {
            int[] output = { 0, 0, 0 };
            for (int i=0; i < input.Length;i++)
            {
                if (input[i] == 0)
                {
                    output[0]++;
                }
                else if (input[i] > 0)
                {
                    output[1]++;
                }
                else
                {
                    output[2]++;
                }
            }
            return output;
        }
    }
}
