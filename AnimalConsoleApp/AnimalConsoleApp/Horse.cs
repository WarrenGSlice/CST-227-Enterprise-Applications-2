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
    class Horse : Animal, IRidable
    {
        public void RideMe()
        {
            Console.WriteLine("Get on that Horsey and ride! YEEEE HAWWW!, slur spittooey!");
        }
        public override void Sing()
        {
            Console.WriteLine("Me and my horse sung ye ol' cowboyin' songs!");
        }
    }
}
