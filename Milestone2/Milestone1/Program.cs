using System;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 5/29/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Console Minesweeper *
 * * * * * * * * * * * */

namespace Milestone2
{
    class Program
    {
        public static Board board;
        static void Main(string[] args)
        {
            // Variables
            int size = -1; // sets the variable size to default value of -1
            bool endGame = false; // varible to see if game is over or not -- #2
            
            Console.Out.WriteLine("Welcome to Minesweeper! ");

            // Sets the grid and size
            while (size == -1)
            {
                Console.Out.WriteLine("Please enter the desired size of the grid: ");
                size = GetInput();
                // check for invalid input
                if (size == -1) 
                {
                    continue; 
                } 
                board = new Board(size);

                // Play game
                Console.Clear();
            } // end of while loop

            // Game Loop that:
            // 1. Ask the user for a row and column number
            // 2. If the grid contains a bomb at the chosen cell, then set end game condition to true
            // 3. If all non-bomb cells are revealed, then set end game to true
            // 4. Print the grid
            while (!endGame)
            {
                // 1. Ask the user for a row and column number
                Console.Out.WriteLine("Enter a Row Number");
                int row = GetInput();
                Console.Out.WriteLine("Enter a Column Number");
                int col = GetInput();
                // Check for invalid input entries
                if (row < 0 || col < 0 || row >= size || col >= size)
                {
                    Console.Out.WriteLine("A Row or Column number goes beyond the scope of the board. Please try again.");
                    continue;
                }

                // 2. If the grid contains a bomb at the chosen cell, then set end game condition to true
                if (board.grid[row, col].HasBomb)
                {
                    Console.Out.WriteLine("You hit a Bomb! KABOOM! Game Over!");
                    endGame = true;
                    continue;
                }
                else
                {
                    // 3. If all non-bomb cells are revealed, then set end game to true
                    if (WonGame())
                    {
                        Console.Out.WriteLine("Congrats! You Won Minesweeper and have been promoted to Nuclear Waste Sweeper!");
                        endGame = true;
                        continue;
                    }
                }
                // If no end game conditions are found, set square to visited and continue
                board.grid[row, col].Visited = true;

                // 4. Print the grid
                PrintBoardDuringGame();
            } // end of while loop
        }// end of method

        // Helper method to seek user input
        public static int GetInput()
        {
            // Varibles
            int input; // declares variable to type integer for holding user input
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Out.WriteLine("Please enter a valid number");
                return -1;
            }
            return input;
        }// end of method

        // Method to create game board in correct format
        public static void PrintBoardDuringGame()
        {
            // Variables
            int rows = board.grid.GetLength(0); // variable to hold row length, set to 0
            int cols = board.grid.GetLength(1); // variable to hold column length, set to 1
            int i; // variable to hold index value of column header
            int row; // variable to hold new row lines
            int col; // variable to hold new column lines
            // Prints the Column Headers
            for ( i = 0; i < cols; i++)
            {
                if (i == 0) Console.Out.Write("|");
                Console.Out.Write(string.Format(" {0} |", i));
            } // end of for loop
            // Prints new line to the game grid
            SeparateLines(cols);
            for (row = 0; row < rows; row++)
            {
                for (col = 0; col < cols; col++)
                {
                    Console.Out.Write("| ");
                    if (board.grid[row, col].Visited)
                    {
                        if (board.grid[row, col].LiveNeighbor > 0)
                        {
                            Console.Out.Write(board.grid[row, col].LiveNeighbor);
                        }
                        else
                        {
                            Console.Out.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Out.Write("?");
                    }
                    Console.Out.Write(" ");
                    // Prints end of row numbers
                    if (col == cols - 1) Console.Out.Write(string.Format("| {0} ", row));
                } // end of for loop
                SeparateLines(cols); // next line
            } // end of for loop
        }// end of method

        // Helper method to separate lines in a nice looking format
        private static void SeparateLines(int number)
        {
            Console.Out.Write("\n|");
            for (int i = 0; i < number; i++)
            {
                Console.Out.Write("---|");
            }
            Console.Out.Write("\n");
        }// end of method

        // Method to determine if game has been won
        public static bool WonGame()
        {
            int rows = board.grid.GetLength(0);// variable to hold row length, set to 0
            int cols = board.grid.GetLength(1);// variable to hold column length, set to 1
            bool isVisited = false; // Variable to hold if any squares are left unvisited
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!board.grid[i, j].Visited && !board.grid[i, j].HasBomb) isVisited = true;
                } // end of for loop
            } // end of for loop
            return !isVisited;
        }// end of method
    } // end of class
} // end of namespace