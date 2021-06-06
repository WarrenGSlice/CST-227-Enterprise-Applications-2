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
    class Cell
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
        private bool hasBomb; // Variable to see if a space has a bomb or not
        public bool HasBomb
        {
            get
            { 
                return hasBomb;
            }
            set
            {
                hasBomb = value;
            }
        }
        private int liveNeighbor; // Variable to hold value of a neighbor cell
        public int LiveNeighbor
        { 
            get 
            { 
                return liveNeighbor; 
            } 
            set 
            { 
                liveNeighbor = value; 
            } 
        }

        public Color Color { get; internal set; }

        // Constructor Method to pass the arguments to the board
        public Cell()
        {
            row = -1;
            col = -1;
            visited = false;
            hasBomb = false;
            liveNeighbor = 0;

        }// end of method
        // Constructor method 
        public Cell(int col, int row, bool visited, bool hasBomb, int liveNeighbor)
        {
            Col = col;
            Row = row;
            Visited = visited;
            HasBomb = hasBomb;
            LiveNeighbor = liveNeighbor;
        }// end of method
    }
}
