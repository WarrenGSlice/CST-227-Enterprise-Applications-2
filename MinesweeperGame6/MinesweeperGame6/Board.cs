using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 7/03/2021 * *
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
        private int Difficulty { get; set; } // Variable to hold the difficulty level
        private int Mine { get; set; } // Variable to hold Mine
        public Cell[,] Grid = null; // Variable to hold the cell grid in a 2-Dimensional Array of the cell object type

        // Empty Constructor
        public Board() : this(10, 1)
        {
            //Set Default Size to 10x10
        }// End of Method

        public Board(int difficulty)
        {
            Size = 16;
            // Difficulty adds a bit of an extra kick, for Moderate and Difficult settings
            // 10% of board is bombs for Easy
            //  With an added 4% or 20% percent added on top of that, depending
            Difficulty = 10 + (40 * (difficulty / 10));

            Grid = new Cell[Size, Size];
            SetupLiveNeighbors();
        }// End of Method

        //Constructor using Difficulty to set board params
        public Board(int size = 10, int difficulty = 1)
        {
            Size = size;
            Difficulty = difficulty;
            SetupLiveNeighbors();
        }// End of Method

        // Method of the 2D array type that creates the grid dynamically
        public Cell[,] InitializeGrid()
        {
            this.Grid = new Cell[this.Size, this.Size];
            for (int rows = 0; rows < this.Size; rows++)
            {
                for (int columns = 0; columns < this.Size; columns++)
                {
                    this.Grid[rows, columns] = new Cell();
                }
            }
            return this.Grid;
        }// End of method

        // That creates a random grid of bombs and sets their locations
        public Cell[,] SetupLiveNeighbors()
        {
            Random rand = new Random();
            int totalsize;
            Grid = InitializeGrid(); //*This is Necessary* otherwise will recieve Null Object Exception
            totalsize = this.Size * this.Size;
            Mine = totalsize / (8 - this.Difficulty);
            for (int random = Mine; random > 0; random--)
            {
                int width = rand.Next(this.Size + 1);
                int length = rand.Next(this.Size + 1);
                //Validate random #'s
                if ((width >= 0) && (width < Size) && (length >= 0) && (length < Size) && !Grid[length, width].Live)
                {
                    Grid[length, width].Live = true;
                }
            }
            CalculateLiveNeighbors();
            return this.Grid;
        }// End of Method

        // Method to Calculate the number of neighbors with bombs and places a number in
        // each cell depending on how many neighbors have bombs and sets their values
        public Array CalculateLiveNeighbors()
        {
            for (int Row = 0; Row < Size; Row++)
            {
                for (int Column = 0; Column < Size; Column++)
                {
                    try
                    {
                        this.Grid[Row, Column].LiveNeighbors =
                            LiveNeighbor(Row - 1, Column - 1) + //Upper Left Cell
                            LiveNeighbor(Row - 1, Column) +   //Left Cell
                            LiveNeighbor(Row - 1, Column + 1) + //Lower Left
                            LiveNeighbor(Row, Column - 1) +   //LowerCell
                            LiveNeighbor(Row + 1, Column + 1) + //Lower Right Cell
                            LiveNeighbor(Row + 1, Column) +   //Right Cell
                            LiveNeighbor(Row + 1, Column - 1) + //Upper Right Cell
                            LiveNeighbor(Row, Column + 1);   //Upper Cell
                    }
                    catch
                    {
                        //Display Error
                        Console.Out.WriteLine("Invalid Space, Start over ");
                        MessageBox.Show("An Error Occured While Calculating neighbors ");
                    }
                }
            }
            return Grid;
        }// End of Method

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
        }// End of Method

        //recursive algorithm to iterate through open cells next to each other 
        // Explain in Video
        public void CheckSurround(int rw, int cl)
        {
            try
            {
                if (Grid[rw, cl].LiveNeighbors == 0)
                {
                    if (ErrorCheck(rw - 1, cl - 1)) // SW
                    {
                        if (Grid[rw - 1, cl - 1].Live == false && Grid[rw - 1, cl - 1].Visited == false)
                        {
                            Grid[rw - 1, cl - 1].Visited = true;
                            CheckSurround(rw - 1, cl - 1);
                        }
                    }
                    if (ErrorCheck(rw - 1, cl)) // W
                    {
                        if (Grid[rw - 1, cl].Live == false && Grid[rw - 1, cl].Visited == false)
                        {
                            Grid[rw - 1, cl].Visited = true;
                            CheckSurround(rw - 1, cl);
                        }
                    }
                    if (ErrorCheck(rw - 1, cl + 1)) // NW
                    {
                        if (Grid[rw - 1, cl + 1].Live == false && Grid[rw - 1, cl + 1].Visited == false)
                        {
                            Grid[rw - 1, cl + 1].Visited = true;
                            CheckSurround(rw - 1, cl + 1);
                        }
                    }
                    if (ErrorCheck(rw, cl + 1)) // N
                    {
                        if (Grid[rw, cl + 1].Live == false && Grid[rw, cl + 1].Visited == false)
                        {
                            Grid[rw, cl + 1].Visited = true;
                            CheckSurround(rw, cl + 1);
                        }
                    }
                    if (ErrorCheck(rw + 1, cl + 1)) //NE
                    {
                        if (Grid[rw + 1, cl + 1].Live == false && Grid[rw + 1, cl + 1].Visited == false)
                        {
                            Grid[rw + 1, cl + 1].Visited = true;
                            CheckSurround(rw + 1, cl + 1);
                        }
                    }
                    if (ErrorCheck(rw + 1, cl)) // E
                    {
                        if (Grid[rw + 1, cl].Live == false && Grid[rw + 1, cl].Visited == false)
                        {
                            Grid[rw + 1, cl].Visited = true;
                            CheckSurround(rw + 1, cl);
                        }
                    }
                    if (ErrorCheck(rw + 1, cl - 1)) // SE
                    {
                        if (Grid[rw + 1, cl - 1].Live == false && Grid[rw + 1, cl - 1].Visited == false)
                        {
                            Grid[rw + 1, cl - 1].Visited = true;
                            CheckSurround(rw + 1, cl - 1);
                        }
                    }
                    if (ErrorCheck(rw, cl - 1)) // S
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
                Console.WriteLine("Memory Error Exception");
            }
        }

        //Check if Cell is within the Grid, Out of Bounds
        public bool ErrorCheck(int x, int y)
        {
            if (x > -1 && x < Size && y > -1 && y < Size)
                return true;
            return false;
        }

       // Method to check is all Safe Tiles have been visited
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
    }
}
