using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_roll_dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int[] Sum = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] Frequency = new int[11];
            int[] Percentage = new int[11];
            Random rnd = new Random();
            while (counter < 5000)
            {
                Frequency[rnd.Next(2, 13) - 2]++;
                counter++;
            }
            for (int i = 0; i <= 10; i++)
            {
                Percentage[i] = Convert.ToInt16(Frequency[i] / 50);
            }
            textBox1.Text = "Sum \tFrequency \tPercentage";
            for (int i = 0; i <= 10; i++)
            {
                textBox1.Text += Environment.NewLine + Sum[i] + "\t       " + Frequency[i] + "     \t           " + Percentage[i];
            }
        }
    }
}
