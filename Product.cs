using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement
{
    internal class Product
    {
        // private attributes
        private int productID;
        private string name;
        private int quantity;
        private double price;

        // setter and getter for attributes
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // constructors
        public Product()
        {

        }

        public Product(int productID, string name, int quantity, double price)
        {
            ProductID = productID;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
