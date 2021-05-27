using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * CST-227 5/27/2021 *
 * Chess Board App * *
 * * * * * * * * * * */

namespace ChessBoardModel
{
    public class Cell
    {
        // Row and Col are the cell's location on the grid
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        // T/F is the chess piece on this cell?
        public bool CurrentlyOccupied { get; set; }

        // is this square a legal move for the chess piece on the board?
        public bool LegalNextMove { get; set; }

        // Constructor
        public Cell (int r, int c)
        {
            RowNumber = r;
            ColumnNumber = c;
        }
    }
}
