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
    public class Board
    {
        // the board is always square. Usually 8x8
        public int Size { get; set; }

        // 2d array of Cell objects
        public Cell[,] theGrid;

        // Constructor
        public Board(int s)
        {
            Size = s;
            // we must initialize the array to avoid Null Exception errors
            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //clear all LegalMoves from previous turn.
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                }
            }
            //find all legal moves and mark the square.
            switch (chessPiece)
            {
                case "Knight":
                     if (IsSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                         theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                         theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                         theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                         theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                         theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                         theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                         theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                     if (IsSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                         theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                     theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                     break;

                case "King":
                    if (IsSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 0))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 0].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 0))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 0].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber + 0, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber + 0, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafe(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                    break;

                case "Rook":
                    for (int i = 0; i < Size; i++)
                    {
                        if (IsSafe(currentCell.RowNumber - i, currentCell.ColumnNumber - 0))
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - 0].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + i, currentCell.ColumnNumber - 0))
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - 0].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + 0, currentCell.ColumnNumber - i))
                            theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + 0, currentCell.ColumnNumber + i))
                            theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                    break;

                case "Bishop":
                    for (int i = 0; i < Size; i++)
                    {
                        if (IsSafe(currentCell.RowNumber - i, currentCell.ColumnNumber - i))
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber - i, currentCell.ColumnNumber + i))
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + i, currentCell.ColumnNumber + i))
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + i, currentCell.ColumnNumber - i))
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                    break;

                case "Queen":
                    for (int i = 0; i < Size; i++)
                    {
                        if (IsSafe(currentCell.RowNumber - i, currentCell.ColumnNumber - i))
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + i, currentCell.ColumnNumber - i))
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + i, currentCell.ColumnNumber + i))
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber - i, currentCell.ColumnNumber + i))
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber - i, currentCell.ColumnNumber - 0))
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - 0].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + i, currentCell.ColumnNumber - 0))
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - 0].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + 0, currentCell.ColumnNumber - i))
                            theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - i].LegalNextMove = true;
                        if (IsSafe(currentCell.RowNumber + 0, currentCell.ColumnNumber + i))
                            theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
                    break;
            }
        }

        private bool IsSafe(int x, int y)
        {
            if (x < 0 || x >= Size || y < 0 || y >= Size)
            {
                Console.WriteLine("Pos " + x + ", " + y + ", is not safe.");
                return false;
            }
            else
            {
                Console.WriteLine("Pos " + x + ", " + ", is safe.");
                return true;
            }
        }
    }
}
