using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 5/29/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Console Minesweeper *
 * * * * * * * * * * * */

namespace Milestone2
{
    class Board
    {
        // Variables
        public int Size { get; private set; } // Variable to hold board size
        public Cell[,] grid {get; private set;}// Variable to hold the cell grid in a 2-Dimensional Array of the cell object type
        private static int Difficulty { get; set; } // Variable to hold the difficulty level
        
        // Empty Constructor
        public Board()
        {
            Size = 1;
            Difficulty = 15; // 15% of board is bombs to start
            grid = new Cell[Size, Size];
        }// end of method

        // Constructor that passes one argument
        public Board(int size)
        {
            Size = size;
            Difficulty = 15; // 15% of board is bombs to start
            grid = new Cell[Size, Size];
            SetupLiveNeighbors();
        }// end of method

        // Method to set up neighbor cells
        public void SetupLiveNeighbors()
        {
            // Variables
            int squares = (int)Math.Pow(Size, 2); // Variable to hold the cell number
            int totalBombs = (int)Math.Ceiling((decimal)squares * ((decimal)Difficulty / 100)); // Variable to hold total amount of bombs based on difficulty

            // Create an array to determine which cells have bombs
            Random rand = new Random();
            bool[] mineArray = new bool[squares];

            // Create an Array to hold a new array of the sorted bomb array
            Double[] sortArray = new Double[squares];
            for (int i = 0; i < sortArray.Length; i++)
            {
                sortArray[i] = rand.NextDouble();
            } // end of for loop
                
            // Filled the mineArray with bombs based on difficulty
            for (int j = 0; j < squares; j++)
            {
                mineArray[j] = j < totalBombs;
            } // end of for loop

            // Sorts the placement of mines
            Array.Sort(sortArray, mineArray);

            // Iterates through the array and creates the Cell objects
            int bombIndex = 0;
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    grid[row, col] = new Cell(col, row, false, mineArray[bombIndex], 0);
                    bombIndex++;
                } // end of for loop
            } // end of for loop
            // Make a second pass over the Grid and calculate all live neighbors for each cell
            CalculateLiveNeighbors();
        }// end of method

        // Method that calculates the number on Bomb Neighbor Cells
        public void CalculateLiveNeighbors()
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

        // Method to fix the index out of bounds error
        public Boolean fixError(int x, int y)
        {
            return (x >= 0 && x < Size && y >= 0 && y < Size);
        }// end of method
    }
}
