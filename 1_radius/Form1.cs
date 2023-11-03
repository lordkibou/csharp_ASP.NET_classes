using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_practicas
{
    public partial class DEMO : Form
    {
        public DEMO()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt16(txtInput.Text);
            string radiusResult = radius(input).ToString();
            string diameterResult = diameter(input).ToString();
            string areaResult = area(input).ToString();
            string circumferenceResult = circumference(input).ToString();
            MessageBox.Show("Radius is "+ radiusResult + Environment.NewLine+
                "Diameter is " + diameterResult+ Environment.NewLine+ "Area is " + areaResult+ 
                Environment.NewLine+"Circumference is " + circumferenceResult );
        }
        private int radius(int input)
        {
            return input;
        }
        private int diameter(int input)
        {
            return input * 2;
        }
        private double area(int input)
        {
            return Math.PI* Math.Pow(input,2);
        }
        private double circumference(int input)
        {
            return Math.PI * 2 * input;
        }
    }
}
