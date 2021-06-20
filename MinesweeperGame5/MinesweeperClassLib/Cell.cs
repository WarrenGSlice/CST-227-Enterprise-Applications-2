using System;
using System.Drawing;
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
    public class Cell
    {
        // Variables
        public int Row { get; set; } // Variables to hold the Rows
        public int Col { get; set; } // Variable to hold the Columns
        public bool Visited { get; set; } // Variables to keep track of visited cells
        public bool Live { get; set; } // Variable to hold the bombs
        public int LiveNeighbors { get; set; } // Variable to hold the numbered cells

        // Constructor
        public Cell(int row, int col, bool visited, bool live, int liveNeighbors)
        {
            Row = row;
            Col = col;
            Visited = visited;
            Live = live;
            LiveNeighbors = liveNeighbors;
        } // end of Method
        // Constructor
        public Cell()
        {
            Row = -1;
            Col = -1;
            Visited = false;
            Live = false;
            LiveNeighbors = 0;
        } // end of Method
    } // end of Class
}// end of Namespace