using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * 5/19/2021 CST-227 *
 * Car Shop Application
 * * * * * * * * * * */

namespace CarShopConsoleApp
{
    public class Car
    {
        // Variables
        public string Make { get; set; } // variable to hold the brand of car
        public string Model { get; set; } // variable to hold the model of car
        public decimal Price { get; set; } // variable to hold the price of the car
        public int Miles { get; set; } // variable to hold the miles on the car
        public string Color { get; set; } // variable to hold the color of the car
        //public decimal Rating { get; set; } // variable to hold the rating of the car
        //public int Year { get; set; } // varible to hold the year of the car
        //public string SafetyLevel { get; set; } // varible to hold the safety level of the car

        // Car constructor with 5 parameters
        public Car(string make, string model, decimal price, int miles, string color)
        {
            Make = make;
            Model = model;
            Price = price;
            Miles = miles;
            Color = color;
        }

        // Car constructor with 0 parameters, Provide default values
        public Car()
        {
            Make = "nothing yet..";
            Model = " nothing yet..";
            Price = 0;
            Miles = 0;
            Color = " nothing yet..";
        }

        // Method to Display the shopping cart and car inventory in the right format
        public string Display
        {
            get
            {
                return string.Format("{0} {1} ${2} {3} {4}", Make, Model, Price, Miles, Color);
            }
        }
    }
}