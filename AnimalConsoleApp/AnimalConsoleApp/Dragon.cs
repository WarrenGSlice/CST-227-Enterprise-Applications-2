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
    class Dragon : Animal, IFlyable
    {
        public void SuperSpeed()
        {
            Console.WriteLine("The Dragon Went into super Speed after burning down the Castle with it's breathe!");
        }

        public void TakeOff()
        {
            Console.WriteLine("The Dragon lifted off the ground with a fury!");
        }
        public override void Sing()
        {
            Console.WriteLine("Dragon song puts the villages into a sleepy death!");
        }

    }
}
