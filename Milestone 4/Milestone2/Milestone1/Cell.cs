using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class Cell
    {
        // Variables
        private int row; // Variable to hold the rows
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = Row;
            }
        }
        private int col; // Variable to hold the Columns
        public int Col
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }
        private bool visited; // Variable to see if a space is visited or not
        public bool Visited
        {
            get
            {
                return visited;
            }
            set
            {
                visited = value;
            }
        }
        public bool Live { get; set; }
        public int LiveNeighbors { get; set; }

        // Constructor Method to pass the arguments to the board
        public Cell()
        {
            row = -1;
            col = -1;
            visited = false;
            Live = false;
            LiveNeighbors = 0;

        }// end of method
        // Constructor method 
        public Cell(int col, int row, bool visited, bool live, int liveNeighbors)
        {
            Col = col;
            Row = row;
            Visited = visited;
            Live = live;
            LiveNeighbors = liveNeighbors;
        }// end of method
    }
}
