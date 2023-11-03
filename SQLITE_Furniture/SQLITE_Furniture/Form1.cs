using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Data;
using System.IO;
using static System.Resources.ResXFileRef;
using System.Runtime.ConstrainedExecution;


namespace SQLITE_Furniture
{
    public partial class Form1 : Form
    {

        private string selectedItem;
        private bool isItemListed;
        private int items;
        public string DBpath = Application.StartupPath + @"\data\furniture.db";
        public int Items
        {
            get { return items; }
            set { items = value; }
        }
        public Form1()
        {
            InitializeComponent();
            buttonADD.Click += buttonADD_Click;
            loadAllFurniture();
            //labelNumberOfItems.Text = g;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void furnitureTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            string furniture = furnitureTextBox.Text;
            string price = priceTextBox.Text;

            // Check if the item is already in the listBox
            if (listBoxSelectToRemove.Items.Contains($"{furniture} - {price}"))
            {
                // If item is listed, set variables accordingly
                isItemListed = true;
            }
            else
            {
                try
                {
                    int priceValue = int.Parse(price);
                    addFurniture(furniture, priceValue);
                }
                catch (FormatException)
                {
                    Console.WriteLine("El precio no tiene un formato válido para un número entero.");
                    // Aquí puedes manejar el caso en el que el precio no pueda ser convertido a un entero
                }



            }

                // Optionally, you can clear the textboxes after checking the item
                furnitureTextBox.Text = "";
                priceTextBox.Text = "";
            }
            private void addFurniture(string furnitureName, int price)
            {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                string query = "INSERT INTO furniture (furniture, price) VALUES (@furnitureName, @price)";
                SQLiteCommand comm = new SQLiteCommand(query, conn);
                comm.Parameters.AddWithValue("@furnitureName", furnitureName);
                comm.Parameters.AddWithValue("@price", price); // Store price as an integer
                comm.ExecuteNonQuery();
                listBoxSelectToRemove.Items.Clear();
                loadAllFurniture();
            }
        }
        private void removeFurniture(string furnitureName)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                string query = "DELETE FROM furniture WHERE furniture = @furnitureName";
                SQLiteCommand comm = new SQLiteCommand(query, conn);
                comm.Parameters.AddWithValue("@furnitureName", furnitureName);
                comm.ExecuteNonQuery();
            }
        }
        private void selectOneFurniture(string furnitureName)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                string query = "SELECT * FROM furniture WHERE furniture = @furnitureName";
                SQLiteCommand comm = new SQLiteCommand(query, conn);
                comm.Parameters.AddWithValue("@furnitureName", furnitureName);

                SQLiteDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    // set this dt.Rows[0];
                }
            }
        }
        private void loadAllFurniture()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();

                string query = "SELECT * FROM furniture";
                SQLiteCommand comm = new SQLiteCommand(query, conn);

                SQLiteDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                int count = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    count += 1;
                    Items = count;
                    string furnitureName = dr["furniture"].ToString();
                    listBoxSelectToRemove.Items.Add(furnitureName); // Suponiendo que el ListBox se llama listBox1
                }
                labelNumberOfItems.Text = count.ToString() + " items";
            }
        }

        private void buttonREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el elemento seleccionado del ListBox y conviértelo a string
                if (listBoxSelectToRemove.SelectedItem != null)
                {
                    string itemSeleccionado = listBoxSelectToRemove.SelectedItem.ToString();
                    removeFurniture(itemSeleccionado);
                    listBoxSelectToRemove.Items.Clear();
                    loadAllFurniture();
                }
                else
                {
                    throw new InvalidOperationException("Por favor, selecciona un elemento antes de eliminarlo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
