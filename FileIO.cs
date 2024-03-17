using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement
{
    internal class FileIO
    {
        // define the file path
        // private static string FilePath = @"AppData/product.txt";

        private static string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppData");
        private static string FilePath = Path.Combine(dataFolderPath, "product.txt");
        public static void WriteFile(Product product)
        {
            StreamWriter sw = new StreamWriter(FilePath, true);
            sw.WriteLine($"{product.ProductID} {product.Name} {product.Quantity} {product.Price}");
            sw.Close();
        }

        // static method to read the file, and return a list of products
        public static List<Product> ReadFile() 
        {
            List<Product> productsSaved = new List<Product>();

            try
            {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length == 4)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        int quantity = int.Parse(parts[2]);
                        double price = double.Parse(parts[3]);

                        productsSaved.Add(new Product(id, name, quantity, price));
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line: {line}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect data format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return productsSaved;
        }
    }
}
