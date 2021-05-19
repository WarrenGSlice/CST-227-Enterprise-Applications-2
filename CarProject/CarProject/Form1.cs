using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * 5/19/2021 CST-227 *
 * Car Shop Application
 * * * * * * * * * * */

namespace CarProject
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource ShoppingListBinding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            SetBindings();
        } // end of method

        // Method to set Bindings
        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;
            CarInventoryListBox.DataSource = carListBinding;
            CarInventoryListBox.DisplayMember = "Display";
            CarInventoryListBox.ValueMember = "Display";

            ShoppingListBinding.DataSource = store.ShoppingList;
            ShoppingCartListBox.DataSource = ShoppingListBinding;
            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";
        }// end of method

        // Create Car Button
        private void CreateACarButton_Click(object sender, EventArgs e)
        {
            try // catches any input errors
            {
                Car newCar = new Car();
                newCar.Make = MakeTextBox.Text;
                newCar.Model = ModelTextBox.Text;
                newCar.Price = decimal.Parse(PriceTextBox.Text);
                newCar.Miles = int.Parse(MilesTextBox.Text);
                newCar.Color = ColorTextBox.Text;

                store.CarList.Add(newCar);

                carListBinding.ResetBindings(false);
            } // end of try
            catch
            {
                MessageBox.Show("Please enter a valid input into the text fields", "Input Error");
            } // end of catch
        }// end of method

        // Add to Cart Button
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)CarInventoryListBox.SelectedItem);

            ShoppingListBinding.ResetBindings(false);
        }// end of method

        // Checkout Button
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            TotalCostLabel.Text = total.ToString();
        }// end of method

        // Clear fields button
        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            MakeTextBox.Text = "";
            ModelTextBox.Text = "";
            PriceTextBox.Text = "";
            MilesTextBox.Text = "";
            ColorTextBox.Text = "";
        }// end of method

        // Unused
        private void Form1_Load(object sender, EventArgs e)
        {

        }// end of method
    }
}
