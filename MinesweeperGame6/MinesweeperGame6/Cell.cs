using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 7/03/2021 * *
 * * * Milestone 6 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperGame6
{
    public class Cell
    {
        // Variables
        public int Row { get; set; } // Variables to hold the Rows
        public int Col { get; set; } // Variable to hold the Columns
        public bool Visited { get; set; } // Variables to keep track of visited cells
        public bool Live { get; set; } // Variable to hold the bombs
        public int LiveNeighbors { get; set; } // Variable to hold the numbered cells
        public bool Flagged { get; set; } // variable to hold flag

        // Constructor
        public Cell()
        {
            Col = -1;
            Row = -1;
            Visited = false;
            Live = false;
            Flagged = false;
            LiveNeighbors = 0;
        }
    } // end of Class
}// end of Namespace