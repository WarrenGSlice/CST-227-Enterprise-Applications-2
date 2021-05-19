using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CarClassLibrary;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * 5/19/2021 CST-227 *
 * Car Shop Application
 * * * * * * * * * * */

namespace CarShopConsoleApp
{
    public class Store
    {
        public List<Car> CarList { get; set; } // List to hold current cars
        public List<Car> ShoppingList { get; set; } // List to hold wanted cars

        // Default Constructor
        public Store()
        {
            /* We must initilize each list or see the dreaded error: "Null Reference Exception Object
               reference not set to an instance of an object." */
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        // method for the checkout function
        public decimal checkout()
        {
            // Variables
            decimal totalCost = 0; // variable to hold the total cost, type decimal, default value is 0

            // Calculate the total cost of items in the cart.
            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }
            ShoppingList.Clear(); // Clear the shopping cart
            return totalCost; // return the total
        }
    }
}
