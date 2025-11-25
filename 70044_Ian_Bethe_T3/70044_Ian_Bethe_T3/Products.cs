using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70044_Ian_Bethe_T3
{
    class Products
    {
        public string ID;
        public string Product_name;
        public string Product_brand;
        public double price;

        public Products(string ID, string Product_name, string Product_brand, double price)
        {
            this.ID = create_id();
            this.Product_name = Product_name;
            this.Product_brand = Product_brand;
            this.price = price;
        }
        public string get_id()
        {
            return ID;
        }
        public string create_id()
        {
            string result = "";
            Random random = new Random();
            char letter_1 = (char)random.Next('A', 'Z' + 1);
            char letter_2 = (char)random.Next('A', 'Z' + 1);
            int number_1 = random.Next(1000, 10000);
            result = $"{letter_1} {letter_2}-{number_1}";
            return result;
        }
    }
}

