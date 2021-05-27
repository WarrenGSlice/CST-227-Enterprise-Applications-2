using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * CST-227 5/27/2021 *
 * Animal Interfaces *
 * * * * * * * * * * */

namespace AnimalConsoleApp
{
    class Gorilla : Animal
    {
        public new void Talk()
        {
            Console.WriteLine("Sir, please pass me the Bananas");
        }
        public new void Greet()
        {
            Console.WriteLine("Nice to meet you, my name is Gorilla");
        }
    }
}
