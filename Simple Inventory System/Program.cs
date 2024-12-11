using System.Diagnostics;

namespace Simple_Inventory_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                int searchProductID;

                DisplayMenu();

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.");
                    Console.WriteLine("\n\nPress Enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Product product = new Product(name);

                        Console.Write("Enter product Quantity: ");
                        if(!int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            Console.WriteLine("Invalid quantity. Please enter a number");
                            break;
                        }
                        product.SetQuantity(quantity);

                        Console.Write("Enter product Price: ");
                        if(!decimal.TryParse(Console.ReadLine(), out decimal price))
                        {
                            Console.WriteLine("Invalid price. Please enter a number/decimal");
                            break;
                        }
                        product.SetPrice(price);

                        inventory.AddProduct(product);
                        break;

                    case 2:
                        Console.Write("Enter the product ID to remove: ");
                        if(!int.TryParse(Console.ReadLine(), out searchProductID))
                        {
                            Console.WriteLine("Invalid product ID. Please enter a number");
                            break;
                        }
                        inventory.RemoveProduct(searchProductID);
                        break;

                    case 3:
                        Console.Write("Enter the product ID to search: ");
                        if(!int.TryParse(Console.ReadLine(), out searchProductID))
                        {
                            Console.WriteLine("Invalid product ID. Please enter a number");
                            break;
                        }
                        inventory.SearchProduct(searchProductID);
                        break;

                    case 4:
                        Console.Write("Enter the product ID to update quantity: ");
                        if(!int.TryParse(Console.ReadLine(), out searchProductID))
                        {
                            Console.WriteLine("Invalid product ID. Please enter a number");
                            break;
                        }
                        inventory.SearchProduct(searchProductID);

                        Console.Write("\nEnter the updated quantity: ");
                        if(!int.TryParse(Console.ReadLine(), out int updatedQuantity))
                        {
                            Console.WriteLine("Invalid quantity. Please enter a number");
                            break;
                        }
                        inventory.UpdateQuantity(searchProductID, updatedQuantity);
                        break;

                    case 5:
                        Console.Write("Enter the product ID to update price: ");
                        if(!int.TryParse(Console.ReadLine(), out searchProductID))
                        {
                            Console.WriteLine("Invalid product ID. Please enter a number");
                            break;
                        }
                        inventory.SearchProduct(searchProductID);

                        Console.Write("\nEnter the updated price: ");
                        if(!int.TryParse(Console.ReadLine(), out int updatedPrice))
                        {
                            Console.WriteLine("Invalid price. Please enter a number");
                            break;
                        }
                        inventory.UpdatePrice(searchProductID, updatedPrice);
                        break;

                    case 6:
                        inventory.DisplayAllProducts();
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.WriteLine("\n\nPress Enter to Continue");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
        
        static private void DisplayMenu()
        {
            Console.WriteLine("Simple Inventory System\n");
            Console.WriteLine("[1] - Add a product");
            Console.WriteLine("[2] - Remove a product");
            Console.WriteLine("[3] - Search a product");
            Console.WriteLine("[4] - Update the quantity of a product");
            Console.WriteLine("[5] - Update the price of a product");
            Console.WriteLine("[6] - Display all products");
            Console.WriteLine("[7] - Exit\n");
        }

        static private void ClearScreen()
        {
            Console.WriteLine("\n\nPress Enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
