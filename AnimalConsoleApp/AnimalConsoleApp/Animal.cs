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
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talking");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
}
