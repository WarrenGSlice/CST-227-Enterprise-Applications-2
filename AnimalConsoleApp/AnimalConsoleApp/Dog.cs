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
    class Dog : Animal, IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor. Good Puppy");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark, Bark, Bark!");
        }
        public override void Sing()
        {
            Console.WriteLine("Hooowwwl!");
        }
        public void Fetch(String thing)
        {
            Console.WriteLine("oh boy. here is your " + thing +". Lets do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's suppertime. The very best time of day!!!");
        }
    };
}
