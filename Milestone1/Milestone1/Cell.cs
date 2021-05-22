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
    class Cell
    {
        // Variables
        public int row { get; set; } // Variable to hold the rows
        public int col { get; set; } // Variable to hold the Columns
        public bool visited { get; set; } // Variable to see if a space is visited or not
        public bool hasBomb { get; set; } // Variable to see if a space has a bomb or not
        public int liveNeighbor { get; set; } // Variable to hold value of a neighbor cell

        // Constructor Method to pass the arguments to the board
        public Cell(int row, int col, bool visited, bool hasBomb, int liveNeighbor)
        {
            row = -1;
            col = -1;
            visited = false;
            hasBomb = false;
            liveNeighbor = 0;

        }
    }
}
