using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement
{
    internal class SavedList
    {
        // create the static list, the list is to store products information every time run the program
        public static List<Product> productsList = new List<Product>();

        // read and write the file to the list when open the program
        static SavedList()
        {
            productsList.AddRange(FileIO.ReadFile());
        }

        // add object to the list, and validate the capacity and duplicate id
        public static void AddProduct(Product product)
        {
            if (productsList.Count >= 100)
            {
                throw new IndexOutOfRangeException("Exceed the capacity of 100");
            }

            if (productsList.Any(p => p.ProductID == product.ProductID))
            {
                throw new InvalidOperationException($"Product with ID {product.ProductID} already exists!");
            }

            productsList.Add(product);            
        }

        // method to return all id in the list
        public static bool IdExist(int id)
        {
            foreach(Product product in productsList)
            {
                if(product.ProductID == id)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
