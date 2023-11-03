using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(textBox1.Text, @"^\d{9}$");
            string name = "John";
            name = name.ToUpper();
            name.ToLower();
            name.Trim();
            string initial = name.Substring(0,1);
            /*
            List<string> myList = new List<string>();
            myList.Add("John");
            myList.Remove("John");
            int counter = myList.Count;
            bool response = myList.Contains("John");
            */
            /*
            DialogResult result = MessageBox.Show("An error occurred!!", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(result == DialogResult.Yes)
            {

            }
            else
            {

            }*/
            /*
            listBox1.Items.Clear();
            listBox1.Items.Add("Hello");
            int counter = listBox1.Items.Count;
            string response = listBox1.SelectedItem.ToString();
            listBox1.Sorted = true;
            int pos = listBox1.SelectedIndex;
            pos = listBox1.FindString("hello");
            pos = listBox1.FindStringExact("hello");
            */
        }
    }
}
