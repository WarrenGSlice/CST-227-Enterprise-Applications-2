using System;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 5/22/2021 * *
 * * * Milestone 1 * * *
 * This is my own work *
 * Console Minesweeper *
 * * * * * * * * * * * */

namespace Milestone1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu Options
            Console.Out.WriteLine("Welcome to Minesweeper! Please select a difficulty: ");
            Console.Out.WriteLine("(1) Baby Mode---------Even a Baby could do it");
            Console.Out.WriteLine("(2) Easy--------------Piece of cake!");
            Console.Out.WriteLine("(3) Medium------------You got this!");
            Console.Out.WriteLine("(4) Hard--------------You're one tough Son of a Gun!");
            Console.Out.WriteLine("(5) Instant Death-----Do you have a Death Wish?");
            Console.Out.WriteLine("(6) Quit");
            // Initializes Board
            int result;
            do;
            while (!int.TryParse(Console.ReadLine(), out result));
            Board board = new Board(12, result);
            board.setBombsBasedOnDifficulty();
            board.calculateBombNeighborNumber();
            board.displayGame();
            Console.Read();
        }
    }
}