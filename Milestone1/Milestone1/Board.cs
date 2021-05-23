using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 5/22/2021 * *
 * * * Milestone 1 * * *
 * This is my own work *
 * Console Minesweeper *
 * * * * * * * * * * * */

namespace Milestone1
{
    class Board
    {
        // Variables
        private static int Size { get; set; } // Variable to hold board size
        private static Cell[,] grid; // Variable to hold the cell grid in a 2-Dimensional Array of the cell object type
        private static int Difficulty { get; set; } // Variable to hold the difficulty level
        int xAxis; // local variable to represent the x-axis of the grid
        int yAxis; // local variable to represent the y-axis of the grid

        // Constructor Method for the board object that passes two arguments
        public Board(int size, int difficulty)
        {
            // Variables
            Size = size; // Variable to hold board size and to pass as an argument
            Difficulty = difficulty; // Variable to hold difficulty level and to pass an an argument
            grid = new Cell[Size, Size]; // Creates a new cell object and sets it to variable grid

            // Loop that creates the board cells based on the size inputted
            for (xAxis = 0; xAxis < Size; xAxis++)
            {
                for (yAxis = 0; yAxis < Size; yAxis++)
                {
                    grid[xAxis, yAxis] = new Cell(xAxis, yAxis, false, false, 0);
                } // end of for loop
            } // end of for loop
        } // end of constructor method

        // Method that sets the bombs and neighbor cell numbers based on difficulty selected
        public void setBombsBasedOnDifficulty()
        {
            // Uses a random number to generate bombs
            Random rand = new Random();

            // Switch statement determines amount of bombs based on difficulty selected
            switch (Difficulty)
            {
                case 1: // Difficulty = Baby Mode
                    int xDimension; // Variable to hold x axis integer
                    int yDimension; // Variable to hold y axis integer
                    // Loop sets 10% or less of board with bombs
                    for (xDimension = 0; xDimension < Size; xDimension++)
                    {
                        for (yDimension = 0; yDimension < Size; yDimension++)
                        {
                            int setBomb = rand.Next(0, 100);
                            if (setBomb <= 10)
                            {
                                grid[xDimension, yDimension].HasBomb = true;
                            }
                        } // end of for loop
                    }// end of for loop
                    break;

                case 2: // Difficulty = Easy
                    // Loop sets 20% or less of board with bombs
                    for (xDimension = 0; xDimension < Size; xDimension++)
                    {
                        for (yDimension = 0; yDimension < Size; yDimension++)
                        {
                            int setBomb = rand.Next(0, 100);
                            if (setBomb <= 20)
                            {
                                grid[xDimension, yDimension].HasBomb = true;
                            }
                        }// end of for loop
                    }// end of for loop
                    break;

                case 3: // Difficulty = Medium
                    // Loop sets 40% or less of board with bombs
                    for (xDimension = 0; xDimension < Size; xDimension++)
                    {
                        for (yDimension = 0; yDimension < Size; yDimension++)
                        {
                            int setBomb = rand.Next(0, 100);
                            if (setBomb <= 40)
                            {
                                grid[xDimension, yDimension].HasBomb = true;
                            }
                        }// end of for loop
                    }// end of for loop
                    break;

                case 4: // Difficulty = Hard
                    // Loop sets 60%or less of board with bombs
                    for (xDimension = 0; xDimension < Size; xDimension++)
                    {
                        for (yDimension = 0; yDimension < Size; yDimension++)
                        {
                            int setBomb = rand.Next(0, 100);
                            if (setBomb <= 60)
                            {
                                grid[xDimension, yDimension].HasBomb = true;
                            }
                        }// end of for loop
                    }// end of for loop
                    break;

                case 5: // Difficulty = Instant Death
                    // Loop sets 80% or less of board with bombs
                    for (xDimension = 0; xDimension < Size; xDimension++)
                    {
                        for (yDimension = 0; yDimension < Size; yDimension++)
                        {
                            int setBomb = rand.Next(0, 100);
                            if (setBomb <= 80)
                            {
                                grid[xDimension, yDimension].HasBomb = true;
                            }
                        }// end of for loop
                    }// end of for loop
                    break;
            }// end of switch
        }// end of method

        // Method that calculates the number on Bomb Neighbor Cells
        public void calculateBombNeighborNumber()
        {
            // Variables
            int xBombs; // Variable to represent how many bombs around a cells x-axis
            int yBombs; // Variable to represent how many bombs around a cells y-axis
            for (xBombs = 0; xBombs < Size; xBombs++)
            {
                for (yBombs = 0; yBombs < Size; yBombs++)
                {
                    // Cell Right 1
                    if (fixError(xBombs + 1, yBombs) && grid[xBombs + 1, yBombs].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Right 1 & Up 1
                    if (fixError(xBombs + 1, yBombs + 1) && grid[xBombs + 1, yBombs + 1].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Right 1 & Down 1
                    if (fixError(xBombs + 1, yBombs - 1) && grid[xBombs + 1, yBombs - 1].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Left 1 & Down 1
                    if (fixError(xBombs - 1, yBombs - 1) && grid[xBombs - 1, yBombs - 1].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Up 1
                    if (fixError(xBombs, yBombs + 1) && grid[xBombs, yBombs + 1].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Left 1
                    if (fixError(xBombs - 1, yBombs) && grid[xBombs - 1, yBombs].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Left 1 & Up 1
                    if (fixError(xBombs - 1, yBombs + 1) && grid[xBombs - 1, yBombs + 1].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                    // Cell Down 1
                    if (fixError(xBombs, yBombs - 1) && grid[xBombs, yBombs - 1].HasBomb)
                    {
                        grid[xBombs, yBombs].LiveNeighbor++;
                    }
                }// end of for loop
            }// end of for loop
        }// end of method

        // Method to Display Game in proper format
        public void displayGame()
        {
            int count = 1; // Variable to hold the count and sets default to 1
            Console.WriteLine("  1    2    3    4    5    6    7    8    9    10   11   12");
            for (int x = 0; x < Size; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < Size; y++)
                {
                    if (grid[x, y].HasBomb)
                    {
                        Console.Write("| *  ");
                    }
                    else
                    {
                        Console.Write("| " + grid[x, y].LiveNeighbor + "  ");
                    }
                } // end of for loop
                Console.WriteLine("|  " + count);
                count++;
                Console.WriteLine("____________________________________________________________");
            } // end of for loop
        } // end of method

        // Method to fix the index out of bounds error
        public Boolean fixError(int x, int y)
        {
            return (x >= 0 && x < Size && y >= 0 && y < Size);
        }
    }
}
