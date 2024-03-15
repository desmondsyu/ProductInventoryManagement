using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInventoryManagement
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
            ShowListBox();
            UpdateAveragePrice();
            UpdateCheapestProduct();
        }

        private void ShowListBox()
        {
            listBoxProducts.Items.Clear();
            foreach (Product product in SavedList.productsList)
            {
                listBoxProducts.Items.Add($"ID: {product.ProductID} \t Name: {product.Name} \t Quantity: {product.Quantity} \t Price: {product.Price}");
            }
        }

        private void UpdateAveragePrice()
        {
            double totalPrice = 0;
            double averagePrice;
            foreach (Product product in SavedList.productsList)
            {
                totalPrice += product.Price;
            }

            if (SavedList.productsList.Count > 0)
            {
                averagePrice = totalPrice / SavedList.productsList.Count;
            }
            else
            {
                averagePrice = 0;
            }

            txtAvgPrice.Text = averagePrice.ToString("#.##");

        }

        private void UpdateCheapestProduct()
        {
            double cheapestPrice = double.MaxValue;
            Product cheapestProduct = null;

            foreach (Product product in SavedList.productsList)
            {
                if (product.Price < cheapestPrice)
                {
                    cheapestPrice = product.Price;
                    cheapestProduct = product;
                }
            }

            if (cheapestProduct != null)
            {
                txtCheapest.Text = $"ID: {cheapestProduct.ProductID} Name: {cheapestProduct.Name} Quantity: {cheapestProduct.Quantity} Price: {cheapestProduct.Price}";
            }
            else
            {
                txtCheapest.Text = "No products!";
            }

        }

        private void SearchByName(string name)
        {
            listBoxProducts.Items.Clear();
            foreach (Product product in SavedList.productsList)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    listBoxProducts.Items.Add($"ID: {product.ProductID} \t Name: {product.Name} \t Quantity: {product.Quantity} \t Price: {product.Price}");
                }
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void txtAvgPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // when all the input pass the validation, assign the values to the object
            if (IdValidate() && NameValidate() && QuantityValidate() && PriceValidate())
            {
                Product product = new Product();

                product.ProductID = int.Parse(txtID.Text);
                product.Name = txtName.Text;
                product.Quantity = int.Parse(txtQty.Text);
                product.Price = double.Parse(txtPrice.Text);

                try
                {
                    // save the object to the list
                    SavedList.AddProduct(product);
                    // call the wirteFile method to write the value to file
                    FileIO.WriteFile(product);

                    // prompt user to continue or not, if continue, clear text fields allow user add another, if not then close the form
                    MessageBox.Show("Product saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearTextFields();
                    ShowListBox();
                    UpdateAveragePrice();
                    UpdateCheapestProduct();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Exceed the capacity of 100!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }
        }

        private void ClearTextFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
        }

        // Cancel button action
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // method to validate the input of id
        private bool IdValidate()
        {
            bool result = false;

            try
            {
                // validate the type of id
                int productId = int.Parse(txtID.Text);

                // validate exist of input id
                if (SavedList.IdExist(productId))
                {
                    MessageBox.Show($"ID {productId} already exists, please try another one!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    result = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input an integer for id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        // method to validate the input of name
        private bool NameValidate()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please input product name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        // method to validate the input of quantity
        private bool QuantityValidate()
        {
            bool result = false;

            try
            {
                int productQuantity = int.Parse(txtQty.Text);
                result = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input an integer for quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        // method to validate the input of price
        private bool PriceValidate()
        {
            bool result = false;

            try
            {
                double priceQuantity = double.Parse(txtPrice.Text);
                result = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input an number for price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchByName(txtSearchName.Text);
        }

        private void txtCheapest_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
        }
    }
}
