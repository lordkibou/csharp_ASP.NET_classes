using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Invoice_info
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string number = textBoxNumber.Text;
                string name = textBoxName.Text;
                string price = textBoxPrice.Text;
                string quantity = textBoxQuantity.Text;

                Invoice myInvoice = new Invoice(number, name, price, quantity);

                textBoxNumber.Text = myInvoice.Id;
                textBoxName.Text = myInvoice.Name.ToUpper();

                MessageBox.Show("Invoice amount: " + myInvoice.overallPriceCalculator(),"Result");
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry an error has just happened");
            }
        }
    }
}
