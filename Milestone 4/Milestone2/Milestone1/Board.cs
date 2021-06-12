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
    public class Board
    {
        // Variables
        public int Size { get; set; } // Variable to hold board size
        public Cell[,] Grid { get; set; }// Variable to hold the cell grid in a 2-Dimensional Array of the cell object type
        private int Difficulty { get; set; } // Variable to hold the difficulty level
        

        // Empty Constructor
        public Board()
        {
            Size = 1;
            Difficulty = 15; // 15% of board is bombs to start
            Grid = new Cell[Size, Size];
        }// end of method

        // Constructor that passes one argument
        public Board(int size)
        {
            Size = size;
            Difficulty = 15; // 15% of board is bombs to start
            Grid = new Cell[Size, Size];
            SetupLiveNeighbors();
        }// end of method

        public Board(int size, int difficulty)
        {
            Size = size;
            //for each location on the grid, create a new cell and set the row/column to current index location.  Set live and visited to false.  Neighbors can be set to the number of neighboring cells that are not live.
            // if [0,0] has three neighbors and all are not live, neighbors would be set to 3.
            Grid = new Cell[size, size];

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Cell cell = new Cell();
                    cell.Row = i;
                    cell.Col = j;
                    cell.Live = false;
                    cell.Visited = false;
                    cell.LiveNeighbors = 0;
                    Grid[i, j] = cell;
                }
            }

            SetupLiveNeighbors();

            foreach (var cell in Grid)
            {
                CalculateLiveNeighbors();
            }
        }

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
            for (int index = 0; index < sortArray.Length; index++)
            {
                sortArray[index] = rand.NextDouble();
            } // end of for loop

            // Filled the mineArray with bombs based on difficulty
            for (int mineIndex = 0; mineIndex < squares; mineIndex++)
            {
                mineArray[mineIndex] = mineIndex < totalBombs;
            } // end of for loop

            // Sorts the placement of mines
            Array.Sort(sortArray, mineArray);

            // Iterates through the array and creates the Cell objects
            int bombIndex = 0;
            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                for (int col = 0; col < Grid.GetLength(1); col++)
                {
                    Grid[row, col] = new Cell(col, row, false, mineArray[bombIndex], 0);
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
                    if (fixError(xBombs + 1, yBombs) && Grid[xBombs + 1, yBombs].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Right 1 & Up 1
                    if (fixError(xBombs + 1, yBombs + 1) && Grid[xBombs + 1, yBombs + 1].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Right 1 & Down 1
                    if (fixError(xBombs + 1, yBombs - 1) && Grid[xBombs + 1, yBombs - 1].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Left 1 & Down 1
                    if (fixError(xBombs - 1, yBombs - 1) && Grid[xBombs - 1, yBombs - 1].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Up 1
                    if (fixError(xBombs, yBombs + 1) && Grid[xBombs, yBombs + 1].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Left 1
                    if (fixError(xBombs - 1, yBombs) && Grid[xBombs - 1, yBombs].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Left 1 & Up 1
                    if (fixError(xBombs - 1, yBombs + 1) && Grid[xBombs - 1, yBombs + 1].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                    // Cell Down 1
                    if (fixError(xBombs, yBombs - 1) && Grid[xBombs, yBombs - 1].Live)
                    {
                        Grid[xBombs, yBombs].LiveNeighbors++;
                    }
                }// end of for loop
            }// end of for loop
        }// end of method

        // Method to fix the index out of bounds error
        public Boolean fixError(int row, int col)
        {
            return (row >= 0 && row < Size && col >= 0 && col < Size);
        }// end of method

        // Was trying to figure out a method for changing number colors
        /*public Type SetColor(int row, int col)
        {
            Type color = typeof(ConsoleColor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var name in Enum.GetNames(color))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(color, name);
                
            }
            return color;
        }*/

        // Recursive method that reveals blocks of cells with no live neighbors
        public void floodFill(int row, int col)
        {
            // Sets Color
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            if (!Grid[row, col].Visited && fixError(row, col))
            {
                // Marks grid element as visited
                Grid[row, col].Visited = true;
                // Recursively checks cells in all directions
                if (fixError(row - 1, col))
                {
                    if (Grid[row - 1, col].LiveNeighbors == 0) floodFill(row - 1, col); // WEST
                    else Grid[row - 1, col].Visited = true; // reach to next and flip it to visited
                }
                if (fixError(row, col + 1))
                {
                    if (Grid[row, col + 1].LiveNeighbors == 0) floodFill(row, col + 1); // NORTH
                    else Grid[row, col + 1].Visited = true;
                }
                if (fixError(row + 1, col))
                {
                    if (Grid[row + 1, col].LiveNeighbors == 0) floodFill(row + 1, col); // EAST
                    else Grid[row + 1, col].Visited = true;
                }
                if (fixError(row, col - 1))
                {
                    if (Grid[row, col - 1].LiveNeighbors == 0) floodFill(row, col - 1); // SOUTH
                    else Grid[row, col - 1].Visited = true;
                }
                if (fixError(row + 1, col + 1))
                {
                    if (Grid[row + 1, col + 1].LiveNeighbors == 0) floodFill(row + 1, col + 1); // NE
                    else Grid[row + 1, col + 1].Visited = true;
                }
                if (fixError(row - 1, col + 1))
                {
                    if (Grid[row - 1, col + 1].LiveNeighbors == 0) floodFill(row - 1, col + 1); // NW
                    else Grid[row - 1, col + 1].Visited = true;
                }
                if (fixError(row + 1, col - 1))
                {
                    if (Grid[row + 1, col - 1].LiveNeighbors == 0) floodFill(row + 1, col - 1); // SE
                    else Grid[row + 1, col - 1].Visited = true;
                }
                if (fixError(row - 1, col - 1))
                {
                    if (Grid[row - 1, col - 1].LiveNeighbors == 0) floodFill(row - 1, col - 1); // SW
                    else Grid[row - 1, col - 1].Visited = true;
                }
            }
            return;
        }
    }
}
