using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/23/2021 * * * * *
 * CST-227 * * * * * *
 * File IO with GUI  *
 * This is my own work
 * * * * * * * * * * */

namespace TextFileDataAccessDemoGUIApp
{
    class Person
    {
        // Variables
        public string firstName { get; set; } // Variable for holding first Name
        public string lastName { get; set; } // Variable for holding last name
        public string url { get; set; } // Variable for hold website name

        // Empty Person Constructor
        public Person() { } // End of Method

        // Display method helps return names in correct format
        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2}", firstName, lastName, url);
            }
        } // End of Method
    }


}
