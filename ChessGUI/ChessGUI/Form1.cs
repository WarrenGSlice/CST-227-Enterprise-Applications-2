using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own work
 * CST-227 5/27/2021 *
 * Chess Board App * *
 * * * * * * * * * * */

namespace ChessGUI
{
    public partial class Form1 : Form
    {
        static public Board board = new Board(8);
        public Button[,] btnGrid = new Button[board.Size, board.Size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }
        public void populateGrid()
        {
            // This function will fill the panel control with buttons
            int buttonSize = ChessBoardPanel.Width / board.Size; // Calculate the width of each button on the Grid
            ChessBoardPanel.Height = ChessBoardPanel.Width; // Set the grid to be square

            // Nested Loop. Create buttons and place them in the Panel
            for (int r = 0; r < board.Size; r++)
            {
                for (int c = 0; c < board.Size; c++)
                {
                    btnGrid[r, c] = new Button();

                    // Make each button square
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].Click += Grid_Button_Click; // Add the same click event to each button.
                    ChessBoardPanel.Controls.Add(btnGrid[r, c]); // Place the button on the Panel
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c); // Position it in x,y

                    // for testing purposes, Remove later.
                    //btnGrid[r, c].Text = r.ToString() + "|" + c.ToString();

                    // The Tag attribute will hold the row and column number in a string
                    btnGrid[r, c].Tag = new Point(r, c);
                }
            }


        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // Get the row and column number of the button just clicked.
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;
            int x = location.X;
            int y = location.Y;

            // Run a help function to label all legal moves for this place.
            Cell currentCell = board.theGrid[x, y];
            board.MarkNextLegalMoves(currentCell, ChessPieceComboBox.Text);

            // Reset the background color of all buttons to the default color.
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {

                    btnGrid[i, j].BackColor = default(Color);
                }
            }
            // Set the background color of the clicked button to something different
            (sender as Button).BackColor = Color.Cornsilk;

            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    btnGrid[i, j].Text = "";
                    if (board.theGrid[i, j].LegalNextMove)
                        btnGrid[i, j].Text = "Legal";
                    if (board.theGrid[i, j].CurrentlyOccupied)
                        btnGrid[i, j].Text = ChessPieceComboBox.Text;
                    board.theGrid[i, j].CurrentlyOccupied = false;
                }
            }
        }

        public void UpdateButtonLabels()
        {
            for (int r = 0; r < board.Size; r++)
            {
                for (int c = 0; c < board.Size; c++)
                {
                    btnGrid[r, c].Text = "";
                    if (board.theGrid[r, c].CurrentlyOccupied) btnGrid[r, c].Text = ChessPieceComboBox.Text;
                    if (board.theGrid[r, c].LegalNextMove) btnGrid[r, c].Text = "Legal";
                }
            }
        }
    }
}