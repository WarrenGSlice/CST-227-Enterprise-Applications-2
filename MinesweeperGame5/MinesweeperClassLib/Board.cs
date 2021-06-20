using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/19/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperClassLib
{
    public class Board
    {
        // Variables
        public int Size { get; set; } // Variable to hold board size
        public Cell[,] Grid { get; set; }// Variable to hold the cell grid in a 2-Dimensional Array of the cell object type
        private int Difficulty { get; set; } // Variable to hold the difficulty level

        public Cell[,] board; // Variable to hold the cell grid in a 2-Dimensional Array of the cell object type

        // Empty Constructor
        public Board()
        {
            board = new Cell[12, 12];
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
            SetupLiveNeighbors(Difficulty);
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
                } // End of for loop
            } // End of for loop

            SetupLiveNeighbors(difficulty);

            foreach (var cell in Grid)
            {
                CalculateLiveNeighbors(cell.Row, cell.Col);
            } // end of foreach loop
        } // end of Method
        // That creates a random grid of bombs
        public void SetupLiveNeighbors(int difficulty)
        {
            Random rand = new Random();
            for (int i = 0; i <= difficulty; i++)
            {
                int randomRow = rand.Next(0, 1);
                int randomColumn = rand.Next(0, 1);
                Grid[randomRow, randomColumn].Live = true;
            } // end of for loop
        } // end of Method
        // Method to Calculate the number of neighbors with bombs and places a number in
        // each cell depending on how many neighbors have bombs
        public void CalculateLiveNeighbors(int row, int column)
        {
            if (Grid[row, column].Live)
            {
                Grid[row, column].LiveNeighbors += 1;
            } // end of if
            Grid[row, column].LiveNeighbors += checkTopLeft(row, column);
            Grid[row, column].LiveNeighbors += checkTopCenter(row, column);
            Grid[row, column].LiveNeighbors += checkTopRight(row, column);
            Grid[row, column].LiveNeighbors += checkCenterLeft(row, column);
            Grid[row, column].LiveNeighbors += checkCenterRight(row, column);
            Grid[row, column].LiveNeighbors += checkBottomLeft(row, column);
            Grid[row, column].LiveNeighbors += checkBottomCenter(row, column);
            Grid[row, column].LiveNeighbors += checkBottomRight(row, column);
        } // end of Method
        // Method to fix the out of bounds error
        public bool fixError(int row, int col)
        {
            if (row >= 0 && row < Size && col >= 0 && col < Size)
            {
                return true;
            } // end of if
            else
            {
                return false;
            } // end of else
        } // end of Method
        // Recursive method that reveals blocks of cells with no live neighbors
        public void floodFill(int row, int col)
        {
            if (!Grid[row, col].Visited && fixError(row, col))
            {
                // Marks grid element as visited
                Grid[row, col].Visited = true;
                // Recursively checks cells in all directions
                if (fixError(row - 1, col))
                {
                    if (Grid[row - 1, col].LiveNeighbors == 0) floodFill(row - 1, col); // WEST
                    else Grid[row - 1, col].Visited = true; // reach to next and flip it to visited
                } // end of if
                if (fixError(row, col + 1))
                {
                    if (Grid[row, col + 1].LiveNeighbors == 0) floodFill(row, col + 1); // NORTH
                    else Grid[row, col + 1].Visited = true;
                } // end of if
                if (fixError(row + 1, col))
                {
                    if (Grid[row + 1, col].LiveNeighbors == 0) floodFill(row + 1, col); // EAST
                    else Grid[row + 1, col].Visited = true;
                } // end of if
                if (fixError(row, col - 1))
                {
                    if (Grid[row, col - 1].LiveNeighbors == 0) floodFill(row, col - 1); // SOUTH
                    else Grid[row, col - 1].Visited = true;
                } // end of if
                if (fixError(row + 1, col + 1))
                {
                    if (Grid[row + 1, col + 1].LiveNeighbors == 0) floodFill(row + 1, col + 1); // NE
                    else Grid[row + 1, col + 1].Visited = true;
                } // end of if
                if (fixError(row - 1, col + 1))
                {
                    if (Grid[row - 1, col + 1].LiveNeighbors == 0) floodFill(row - 1, col + 1); // NW
                    else Grid[row - 1, col + 1].Visited = true;
                } // end of if
                if (fixError(row + 1, col - 1))
                {
                    if (Grid[row + 1, col - 1].LiveNeighbors == 0) floodFill(row + 1, col - 1); // SE
                    else Grid[row + 1, col - 1].Visited = true;
                } // end of if
                if (fixError(row - 1, col - 1))
                {
                    if (Grid[row - 1, col - 1].LiveNeighbors == 0) floodFill(row - 1, col - 1); // SW
                    else Grid[row - 1, col - 1].Visited = true;
                } // end of if
            } // end of if
            return;
        }  // end of Method
        // Method to check top left cell
        public int checkTopLeft(int row, int col)
        {
            int calcRow = row - 1;
            int calcCol = col - 1;
            int calcLive = 0;
            if (calcRow < 0 || calcCol < 0)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[calcRow, calcCol].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        // Method to check top center cell
        public int checkTopCenter(int row, int col)
        {
            int calcRow = row - 1;
            int calcLive = 0;
            if (calcRow < 0)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row - 1, col].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        // Method to check top right cell
        public int checkTopRight(int row, int col)
        {
            int calcRow = row - 1;
            int calcCol = col + 1;
            int calcLive = 0;
            if (calcRow < 0 || calcCol > 11)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row - 1, col + 1].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        // Method to check left center cell
        public int checkCenterLeft(int row, int col)
        {

            int calcCol = col - 1;
            int calcLive = 0;
            if (calcCol < 0)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row, col - 1].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        // Method to check right cell center
        public int checkCenterRight(int row, int col)
        {
            int calcCol = col + 1;
            int calcLive = 0;
            if (calcCol > 11)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row, col + 1].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        //Method to check bottom left cell
        public int checkBottomLeft(int row, int col)
        {
            int calcRow = row + 1;
            int calcCol = col - 1;
            int calcLive = 0;
            if (calcRow > 11 || calcCol < 0)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row + 1, col - 1].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        //method to check bottom center cell
        public int checkBottomCenter(int row, int col)
        {
            int calcRow = row + 1;
            int calcLive = 0;
            if (calcRow > 11)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row + 1, col].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
        //method to check bottom right cell
        public int checkBottomRight(int row, int col)
        {
            int calcRow = row + 1;
            int calcCol = col + 1;
            int calcLive = 0;
            if (calcRow > 11 || calcCol > 11)
            {
                calcLive = 0;
            } // end of if
            else if (Grid[row + 1, col + 1].Live)
            {
                calcLive = 1;
            } // end of else if
            return calcLive;
        } // end of Method
    }
}
