using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simple_Inventory_System
{
    public class Inventory
    {
        private List<Product> products;

        public Inventory() {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully");
        }

        public void RemoveProduct(int productID)
        {
            var searchProduct = FindProductByID(productID);

            if(searchProduct != null)
            {
                products.Remove(searchProduct);
                Console.WriteLine("Product removed successfully");
            }
        }

        public void SearchProduct(int productID)
        {
            var searchProduct = FindProductByID(productID);

            if (searchProduct != null)
            {
                Console.WriteLine("ID\t\tName\t\tQuantity\t\tPrice");
                Console.WriteLine($"{searchProduct.Id}\t\t{searchProduct.Name}\t\t{searchProduct.Quantity}\t\t{searchProduct.Price:F2}");
            }
        }

        public void UpdateQuantity(int productID, int UpdatedQuantity)
        {
            var searchProduct = FindProductByID(productID);

            if (searchProduct != null)
            {
                searchProduct.SetQuantity(UpdatedQuantity);
                Console.WriteLine("Product quantity updated successfully");
            }
        }

        public void UpdatePrice(int productID, int updatedPrice)
        {
            var searchProduct = FindProductByID(productID);

            if ( searchProduct != null )
            {
                searchProduct.SetPrice(updatedPrice);
                Console.WriteLine("Product price updated successfully");
            }
        }

        public void DisplayAllProducts()
        {
            if (products.Count <= 0)
            {
                Console.WriteLine("No products in the inventory");
                return;
            }

            Console.WriteLine("Product Lists");

            Console.WriteLine("ID\t\tName\t\tQuantity\t\tPrice");
            foreach (Product product in products)
            {
                product.DisplayProductInfo();
            }
        }

        public Product FindProductByID(int productID)
        {
            var searchProduct = products.Find(s => s.Id == productID);

            if (searchProduct == null)
            {
                Console.WriteLine($"Product with ID {productID} does not exist in the inventory");
            }

            return searchProduct;
        }
    }
}
