using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_System
{
    public class Product
    {
        static private int IdSeed = 227;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity {  get; private set; }
        public decimal Price { get; private set; }

        public Product(string name)
        {
            Id = IdSeed;
            IdSeed++;

            Name = name;
        }

        public void SetQuantity(int quantity)
        {
            if (quantity <= 0) {
                Console.WriteLine($"Quantity must be greater than 0");
                return;
            }

            Quantity = quantity;
        }

        public void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine($"Price must be greater than 0");
                return;
            }

            Price = price;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"{Id}\t\t{Name}\t\t{Quantity}\t\t{Price:F2}");
        }
    }
}
