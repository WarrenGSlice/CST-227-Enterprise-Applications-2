using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/25/2021 * *
 * * * Milestone 6 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperGame6
{
    public class Board
    {
        // Variables
        public int Size { get; set; } // Variable to hold board size
        //public Cell[,] Grid { get; set; }// Variable to hold the cell grid in a 2-Dimensional Array of the cell object type
        private int Difficulty { get; set; } // Variable to hold the difficulty level
        private int Mine { get; set; }
        private bool InPlay { get; set; }
        public int[] rwRound = { -1, -1, -1, 0, 1, 1, 1, 0 };
        public int[] clRound = { -1, 0, 1, -1, 1, 0, -1, 1 };
        public Cell[,] Grid = null;

        //public Cell[,] board; // Variable to hold the cell grid in a 2-Dimensional Array of the cell object type

        // Empty Constructor
        //Empty Constructor
        public Board() : this(10, 1)
        { //Set Default Size to 10x10

        }

        //public Board()
        //{
        //    //board = new Cell[12, 12];
        //    Size = 16;
        //    Difficulty = 20; // 15% of board is bombs to start
        //    Grid = new Cell[Size, Size];
        //}// end of method

        public Board(int difficulty)
        {
            Size = 16;
            // Difficulty adds a bit of an extra kick, for Moderate and Difficult settings
            // 10% of board is bombs for Easy
            //  With an added 4% or 20% percent added on top of that, depending
            Difficulty = 10 + (40 * (difficulty / 10));

            Grid = new Cell[Size, Size];
            SetupLiveNeighbors();
        }

        //Constructor using Difficulty to set board params
        public Board(int size = 10, int difficulty = 1)
        {
            Size = size;
            Difficulty = difficulty;
            SetupLiveNeighbors();
        }

        public Cell[,] InitializeGrid()
        {
            this.Grid = new Cell[this.Size, this.Size];
            for (int iOuter = 0; iOuter < this.Size; iOuter++)
            {
                for (int jInner = 0; jInner < this.Size; jInner++)
                {
                    this.Grid[iOuter, jInner] = new Cell();
                }
            }
            return this.Grid;
        }

        //// Constructor that passes one argument
        //public Board(int size)
        //{
        //    Size = size;
        //    Difficulty = 15; // 15% of board is bombs to start
        //    Grid = new Cell[Size, Size];
        //    SetupLiveNeighbors(Difficulty);
        //}// end of method

        //public Board(int size, int difficulty)
        //{
        //    Size = size;
        //    //for each location on the grid, create a new cell and set the row/column to current index location.  Set live and visited to false.  Neighbors can be set to the number of neighboring cells that are not live.
        //    // if [0,0] has three neighbors and all are not live, neighbors would be set to 3.
        //    Grid = new Cell[size, size];

        //    for (int i = 0; i < Grid.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < Grid.GetLength(1); j++)
        //        {
        //            Cell cell = new Cell();
        //            cell.Row = i;
        //            cell.Col = j;
        //            cell.Live = false;
        //            cell.Visited = false;
        //            cell.LiveNeighbors = 0;
        //            Grid[i, j] = cell;
        //        } // End of for loop
        //    } // End of for loop

        //    SetupLiveNeighbors(difficulty);

        //    foreach (var cell in Grid)
        //    {
        //        CalculateLiveNeighbors(cell.Row, cell.Col);
        //    } // end of foreach loop
        //} // end of Method

        // That creates a random grid of bombs
        //Set bomb cells
        public Cell[,] SetupLiveNeighbors()
        {
            Random rand = new Random();
            int totalsize;
            Grid = InitializeGrid(); //*This is Necessary* otherwise will recieve Null Object Exception
            totalsize = this.Size * this.Size;
            Mine = totalsize / (8 - this.Difficulty);
            for (int iRand = Mine; iRand > 0; iRand--)
            {
                int randwth = rand.Next(this.Size + 1);
                int randlth = rand.Next(this.Size + 1);
                //Validate random #'s
                if ((randwth >= 0) && (randwth < Size) && (randlth >= 0) && (randlth < Size) && !Grid[randlth, randwth].Live)
                {
                    Grid[randlth, randwth].Live = true;
                }
                //else {
                //    //print only for debugging
                //    //this.grid[randwth, randlth].live=false;
                //}
            }
            CalculateLiveNeighbors();
            return this.Grid;
        }

        //public void SetupLiveNeighbors()
        //{
        //    int squareSpace = (int)Math.Pow(Size, 2);
        //    int totalAllowedBombs = (int)Math.Ceiling((decimal)squareSpace * ((decimal)Difficulty / 100));

        //    // Create 2D array to calculate which cells are live/dead
        //    Random rand = new Random();
        //    bool[] liveCells = new bool[squareSpace];

        //    // Setup and populate sorting set, used to randomize the liveCells array
        //    Double[] sortOrder = new Double[squareSpace];
        //    for (int idx = 0; idx < sortOrder.Length; idx++)
        //        sortOrder[idx] = rand.NextDouble();
        //    for (int idx = 0; idx < squareSpace; idx++)
        //    {
        //        // guarantee that all allowed bombs are set
        //        // in accord with the difficulty setting
        //        liveCells[idx] = idx < totalAllowedBombs;
        //    }

        //    // Randomize the liveCells placement through sortOrder
        //    Array.Sort(sortOrder, liveCells);

        //    // Now iter through 2D array and initialize all cells
        //    int liveCellSeedIdx = 0;
        //    for (int row = 0; row < Grid.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < Grid.GetLength(1); col++)
        //        {
        //            Grid[row, col] = new Cell(col, row, false, liveCells[liveCellSeedIdx], 0);
        //            liveCellSeedIdx++;
        //        }
        //    }

        //    // Make a second pass over the Grid and calculate all live neighbors for each cell
        //    CalculateLiveNeighbors();
        //}

        //public void SetupLiveNeighbors(int difficulty)
        //{
        //    Random rand = new Random();
        //    for (int i = 0; i <= difficulty; i++)
        //    {
        //        int randomRow = rand.Next(0, 9);
        //        int randomColumn = rand.Next(0, 9);
        //        Grid[randomRow, randomColumn].Live = true;
        //    } // end of for loop
        //} // end of Method

        // Method to Calculate the number of neighbors with bombs and places a number in
        // each cell depending on how many neighbors have bombs
        //set neighboring bomb cells to value
        public Array CalculateLiveNeighbors()
        {
            for (int iOuter = 0; iOuter < Size; iOuter++)
            {
                for (int jInner = 0; jInner < Size; jInner++)
                {
                    try
                    {
                        this.Grid[iOuter, jInner].LiveNeighbors =
                            LiveNeighbor(iOuter - 1, jInner - 1) + //Upper Left Cell
                            LiveNeighbor(iOuter - 1, jInner) +   //Left Cell
                            LiveNeighbor(iOuter - 1, jInner + 1) + //Lower Left
                            LiveNeighbor(iOuter, jInner - 1) +   //LowerCell
                            LiveNeighbor(iOuter + 1, jInner + 1) + //Lower Right Cell
                            LiveNeighbor(iOuter + 1, jInner) +   //Right Cell
                            LiveNeighbor(iOuter + 1, jInner - 1) + //Upper Right Cell
                            LiveNeighbor(iOuter, jInner + 1);   //Upper Cell
                    }
                    catch
                    {
                        //Display Error
                        Console.Out.WriteLine("Unexpected Result during Neighbor Sets. ");
                        MessageBox.Show("Unexpected Result during Neighbor Sets. ");
                    }
                }
            }

            return Grid;
        }
        //Count Neighboring Cells for nearby bombs
        private int LiveNeighbor(int iRow, int iCol)
        {
            int count = 0;
            // Validate data
            if ((iRow < 0) || (iRow > this.Size) || (iCol < 0) && (iCol > this.Size))
            {
                count = 0;
            }

            try
            {
                if (this.Grid[iRow, iCol].Live == true)
                    count++; // Incriment count
            }
            catch
            {
                // Display error or such
                //Console.Out.WriteLine("Error on \"NON Live\" Cell. ");
            }

            return count;
        }
        //recursive algorithm to iterate through open cells next to each other 
        public void CheckSurround(int rw, int cl)
        {
            //int count = 1;
            try
            {
                if (Grid[rw, cl].LiveNeighbors == 0)
                {
                    if (IsSquareSafe(rw - 1, cl - 1))
                    {
                        if (Grid[rw - 1, cl - 1].Live == false && Grid[rw - 1, cl - 1].Visited == false)
                        {
                            Grid[rw - 1, cl - 1].Visited = true;
                            CheckSurround(rw - 1, cl - 1);
                        }
                    }
                    if (IsSquareSafe(rw - 1, cl))
                    {
                        if (Grid[rw - 1, cl].Live == false && Grid[rw - 1, cl].Visited == false)
                        {
                            Grid[rw - 1, cl].Visited = true;
                            CheckSurround(rw - 1, cl);
                        }
                    }
                    if (IsSquareSafe(rw - 1, cl + 1))
                    {
                        if (Grid[rw - 1, cl + 1].Live == false && Grid[rw - 1, cl + 1].Visited == false)
                        {
                            Grid[rw - 1, cl + 1].Visited = true;
                            CheckSurround(rw - 1, cl + 1);
                        }
                    }
                    if (IsSquareSafe(rw, cl + 1))
                    {
                        if (Grid[rw, cl + 1].Live == false && Grid[rw, cl + 1].Visited == false)
                        {
                            Grid[rw, cl + 1].Visited = true;
                            CheckSurround(rw, cl + 1);
                        }
                    }
                    if (IsSquareSafe(rw + 1, cl + 1))
                    {
                        if (Grid[rw + 1, cl + 1].Live == false && Grid[rw + 1, cl + 1].Visited == false)
                        {
                            Grid[rw + 1, cl + 1].Visited = true;
                            CheckSurround(rw + 1, cl + 1);
                        }
                    }
                    if (IsSquareSafe(rw + 1, cl))
                    {
                        if (Grid[rw + 1, cl].Live == false && Grid[rw + 1, cl].Visited == false)
                        {
                            Grid[rw + 1, cl].Visited = true;
                            CheckSurround(rw + 1, cl);
                        }
                    }
                    if (IsSquareSafe(rw + 1, cl - 1))
                    {
                        if (Grid[rw + 1, cl - 1].Live == false && Grid[rw + 1, cl - 1].Visited == false)
                        {
                            Grid[rw + 1, cl - 1].Visited = true;
                            CheckSurround(rw + 1, cl - 1);
                        }
                    }
                    if (IsSquareSafe(rw, cl - 1))
                    {
                        if (Grid[rw, cl - 1].Live == false && Grid[rw, cl - 1].Visited == false)
                        {
                            Grid[rw, cl - 1].Visited = true;
                            CheckSurround(rw, cl - 1);
                        }
                    }
                }
            }
            catch (InsufficientExecutionStackException)
            {
                Console.WriteLine("Ran out of stack Memory 3.");
            }
        }

        //Check if Cell is within the Grid
        public bool IsSquareSafe(int x, int y)
        {
            if (x > -1 && x < Size && y > -1 && y < Size)
                return true;
            return false;
        }

        //public void CalculateLiveNeighbors()
        //{
        //    for (int row = 0; row < Grid.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < Grid.GetLength(1); col++)
        //        {
        //            CalculateLiveCellNeighbors(Grid[row, col]);
        //        }
        //    }
        //}

        //private void CalculateLiveCellNeighbors(Cell c)
        //{
        //    // Set to 0 automatically, per rules, if cell itself is live
        //    if (c.Live)
        //    {
        //        c.LiveNeighbors = 9;
        //        return;
        //    }

        //    // test if any array index is going to cause out-of-bounds errs
        //    // If it would, just add a default (!Live && LiveNeighbors == 0)
        //    Cell def = new Cell(0, 0, false, false, 0);
        //    Cell left = (c.Col - 1 >= 0) ? Grid[c.Row, c.Col - 1] : def;
        //    Cell right = (c.Col + 1 < Size) ? Grid[c.Row, c.Col + 1] : def;
        //    Cell top = (c.Row - 1 >= 0) ? Grid[c.Row - 1, c.Col] : def;
        //    Cell bottom = (c.Row + 1 < Size) ? Grid[c.Row + 1, c.Col] : def;
        //    Cell topRight = (c.Row - 1 >= 0 && c.Col + 1 < Size) ? Grid[c.Row - 1, c.Col + 1] : def;
        //    Cell topLeft = (c.Row - 1 >= 0 && c.Col - 1 >= 0) ? Grid[c.Row - 1, c.Col - 1] : def;
        //    Cell bottomRight = (c.Row + 1 < Size && c.Col + 1 < Size) ? Grid[c.Row + 1, c.Col + 1] : def;
        //    Cell bottomLeft = (c.Row + 1 < Size && c.Col - 1 >= 0) ? Grid[c.Row + 1, c.Col - 1] : def;

        //    int liveNeighbors = 0;
        //    foreach (Cell neighbor in new Cell[] { left, right, top, bottom, topRight, topLeft, bottomRight, bottomLeft })
        //    {
        //        liveNeighbors += neighbor.Live ? 1 : 0;
        //    }
        //    c.LiveNeighbors = liveNeighbors;
        //}

        //public void CalculateLiveNeighbors(int row, int column)
        //{
        //    if (Grid[row, column].Live)
        //    {
        //        Grid[row, column].LiveNeighbors += 1;
        //    } // end of if
        //    Grid[row, column].LiveNeighbors += checkTopLeft(row, column);
        //    Grid[row, column].LiveNeighbors += checkTopCenter(row, column);
        //    Grid[row, column].LiveNeighbors += checkTopRight(row, column);
        //    Grid[row, column].LiveNeighbors += checkCenterLeft(row, column);
        //    Grid[row, column].LiveNeighbors += checkCenterRight(row, column);
        //    Grid[row, column].LiveNeighbors += checkBottomLeft(row, column);
        //    Grid[row, column].LiveNeighbors += checkBottomCenter(row, column);
        //    Grid[row, column].LiveNeighbors += checkBottomRight(row, column);
        //} // end of Method

        // Method to fix the out of bounds error
        //private bool isSafeCell(int r, int c)
        //{
        //    return (r >= 0 && r < Size) && (c >= 0 && c < Size) && !Grid[r, c].Live && !Grid[r, c].Visited;
        //}

        //public bool fixError(int row, int col)
        //{
        //    if (row >= 0 && row < Size && col >= 0 && col < Size)
        //    {
        //        return true;
        //    } // end of if
        //    else
        //    {
        //        return false;
        //    } // end of else
        //} // end of Method
        // Recursive method that reveals blocks of cells with no live neighbors
        //public void floodFill(int row, int col)
        //{
        //    if (!Grid[row, col].Visited && isSafeCell(row, col))
        //    {
        //        // Marks grid element as visited
        //        Grid[row, col].Visited = true;
        //        // Recursively checks cells in all directions
        //        if (isSafeCell(row - 1, col))
        //        {
        //            if (Grid[row - 1, col].LiveNeighbors == 0) floodFill(row - 1, col); // WEST
        //            else Grid[row - 1, col].Visited = true; // reach to next and flip it to visited
        //        } // end of if
        //        if (isSafeCell(row, col + 1))
        //        {
        //            if (Grid[row, col + 1].LiveNeighbors == 0) floodFill(row, col + 1); // NORTH
        //            else Grid[row, col + 1].Visited = true;
        //        } // end of if
        //        if (isSafeCell(row + 1, col))
        //        {
        //            if (Grid[row + 1, col].LiveNeighbors == 0) floodFill(row + 1, col); // EAST
        //            else Grid[row + 1, col].Visited = true;
        //        } // end of if
        //        if (isSafeCell(row, col - 1))
        //        {
        //            if (Grid[row, col - 1].LiveNeighbors == 0) floodFill(row, col - 1); // SOUTH
        //            else Grid[row, col - 1].Visited = true;
        //        } // end of if
        //        if (isSafeCell(row + 1, col + 1))
        //        {
        //            if (Grid[row + 1, col + 1].LiveNeighbors == 0) floodFill(row + 1, col + 1); // NE
        //            else Grid[row + 1, col + 1].Visited = true;
        //        } // end of if
        //        if (isSafeCell(row - 1, col + 1))
        //        {
        //            if (Grid[row - 1, col + 1].LiveNeighbors == 0) floodFill(row - 1, col + 1); // NW
        //            else Grid[row - 1, col + 1].Visited = true;
        //        } // end of if
        //        if (isSafeCell(row + 1, col - 1))
        //        {
        //            if (Grid[row + 1, col - 1].LiveNeighbors == 0) floodFill(row + 1, col - 1); // SE
        //            else Grid[row + 1, col - 1].Visited = true;
        //        } // end of if
        //        if (isSafeCell(row - 1, col - 1))
        //        {
        //            if (Grid[row - 1, col - 1].LiveNeighbors == 0) floodFill(row - 1, col - 1); // SW
        //            else Grid[row - 1, col - 1].Visited = true;
        //        } // end of if
        //    } // end of if
        //    return;
        //}  // end of Method

        public bool AllSafeTilesVisited()
        {
            int rows = Grid.GetLength(0);
            int cols = Grid.GetLength(1);
            bool someUnvisited = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (!Grid[row, col].Visited && !Grid[row, col].Live) someUnvisited = true;
                }
            }
            return !someUnvisited;
        }

        //// Method to check top left cell
        //public int checkTopLeft(int row, int col)
        //{
        //    int calcRow = row - 1;
        //    int calcCol = col - 1;
        //    int calcLive = 0;
        //    if (calcRow < 0 || calcCol < 0)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[calcRow, calcCol].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        //// Method to check top center cell
        //public int checkTopCenter(int row, int col)
        //{
        //    int calcRow = row - 1;
        //    int calcLive = 0;
        //    if (calcRow < 0)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row - 1, col].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        //// Method to check top right cell
        //public int checkTopRight(int row, int col)
        //{
        //    int calcRow = row - 1;
        //    int calcCol = col + 1;
        //    int calcLive = 0;
        //    if (calcRow < 0 || calcCol > 11)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row - 1, col + 1].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        //// Method to check left center cell
        //public int checkCenterLeft(int row, int col)
        //{

        //    int calcCol = col - 1;
        //    int calcLive = 0;
        //    if (calcCol < 0)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row, col - 1].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        //// Method to check right cell center
        //public int checkCenterRight(int row, int col)
        //{
        //    int calcCol = col + 1;
        //    int calcLive = 0;
        //    if (calcCol > 11)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row, col + 1].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        ////Method to check bottom left cell
        //public int checkBottomLeft(int row, int col)
        //{
        //    int calcRow = row + 1;
        //    int calcCol = col - 1;
        //    int calcLive = 0;
        //    if (calcRow > 11 || calcCol < 0)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row + 1, col - 1].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        ////method to check bottom center cell
        //public int checkBottomCenter(int row, int col)
        //{
        //    int calcRow = row + 1;
        //    int calcLive = 0;
        //    if (calcRow > 11)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row + 1, col].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
        ////method to check bottom right cell
        //public int checkBottomRight(int row, int col)
        //{
        //    int calcRow = row + 1;
        //    int calcCol = col + 1;
        //    int calcLive = 0;
        //    if (calcRow > 11 || calcCol > 11)
        //    {
        //        calcLive = 0;
        //    } // end of if
        //    else if (Grid[row + 1, col + 1].Live)
        //    {
        //        calcLive = 1;
        //    } // end of else if
        //    return calcLive;
        //} // end of Method
    }
}
