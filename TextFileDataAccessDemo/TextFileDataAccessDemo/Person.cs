using System;
/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/23/2021 * * * * *
 * CST-227 * * * * * *
 * File IO in C# * * *
 * This is my own work
 * * * * * * * * * * */
namespace TextFileDataAccessDemo
{
    public class Person
    {
        // Variables
        public string firstName { get; set; } // Holds first Name 
        public string lastName { get; set; } // Holds Last Name
        public string Url { get; set; } // Holds website name

        // Empty Constructor
        public Person()
        {
        }

        // Person Constructor
        public Person(string first, string last, string url)
        {
            firstName = first;
            lastName = last;
            Url = url;
        }
    }
}
