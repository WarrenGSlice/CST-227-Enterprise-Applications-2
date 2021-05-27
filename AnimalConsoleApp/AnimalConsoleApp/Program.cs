using System;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * CST-227 5/27/2021 *
 * Animal Interfaces *
 * * * * * * * * * * */

namespace AnimalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Animal beast = new Animal();

            beast.Talk();
            beast.Greet();
            beast.Sing();
            */

            Dog bowser = new Dog();

            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("Stick");
            bowser.FeedMe();
            bowser.TouchMe();

            Robin red = new Robin();

            red.Talk();
            red.Greet();
            red.Sing();
            //red.Fetch("worm");
            //red.FeedMe();
            //red.TouchMe();

            Dragon flamer = new Dragon();

            flamer.TakeOff();
            flamer.SuperSpeed();
            flamer.Sing();

            Horse oldBlue = new Horse();

            oldBlue.RideMe();
            oldBlue.Sing();

            Gorilla bananaBoy = new Gorilla();

            bananaBoy.Greet();
            bananaBoy.Sing();

            Console.ReadLine();
        }
    }
}
