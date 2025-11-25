using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _70044_Ian_Bethe_T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products p = create_products();
            ProductsOnFile(p);
           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
        private Products create_products()
        {
            double price = Convert.ToDouble(textBox3.Text);
            return new Products(label2.Text, textBox1.Text, textBox2.Text, price);
        }
        private void ProductsOnFile(Products p)
        {
            FileStream ab = new FileStream("products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter bc = new StreamWriter(ab);
            bc.WriteLine($"{p.ID} $ {p.Product_name} $ {p.Product_brand} $ {p.price}");
            bc.Close();
            ab.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string button_read = "products.txt";
            if (File.Exists(button_read))
            {
                using (FileStream fs = new FileStream(button_read, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string a = sr.ReadLine();
                        if (!string.IsNullOrEmpty(a))
                        {
                            string[] b = a.Split('$');
                            if (b.Length == 4)
                            {
                                label2.Text = b[0].Trim();
                                textBox1.Text = b[1].Trim();
                                textBox2.Text = b[2].Trim();
                                textBox3.Text = b[3].Trim();
                            }
                          
                        }
                       
                    }
                }
            }
        }
    }
}