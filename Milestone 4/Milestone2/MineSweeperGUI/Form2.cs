using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milestone2;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/11/2021 * *
 * * * Milestone 4 * * *
 * This is my own work *
 * * Minesweeper GUI * *
 * * * * * * * * * * * */

namespace MineSweeperGUI
{
    public partial class Form2 : Form
    {
        // Variables
        public Button[,] buttonGrid = new Button[12, 12]; // Used to hold button grid for GUI
        static public int size = 12; // Used to set the size of the board
        static Board board; // Used to hold the board
        public Form2()
        {
            InitializeComponent();
            populateGrid(); // Method that populates grid
        }

        // Method to Create Grid Dynamically
        public void populateGrid()
        {
            // Variables
            int buttonSize = gameBoardPanel.Width / size; // Used to hold board dimensions
            gameBoardPanel.Height = gameBoardPanel.Width; // Used to make height and width equal
            // Loop for creating board
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    board = new Board(size, Form1.Difficulty);

                    // Row and Column controls for the new buttons created dynamically
                    buttonGrid[row, col] = new Button();
                    buttonGrid[row, col].Width = buttonSize;
                    buttonGrid[row, col].Height = buttonSize;
                    buttonGrid[row, col].MouseDown += button1_Click; // Call on the button click method to handle each click
                    gameBoardPanel.Controls.Add(buttonGrid[row, col]);
                    buttonGrid[row, col].Location = new Point(buttonSize * row, buttonSize * col);
                    buttonGrid[row, col].Tag = row.ToString() + "|" + col.ToString();
                }


            }
        }

        // Button click Method makes numbers pop up and iterate when buttons are clicked
        private void button1_Click(object sender, EventArgs e)
        {
            var control = (Button)sender;
            int inter = string.IsNullOrEmpty(control.Text) ? 1 : int.Parse(control.Text) + 1;
            control.Text = string.Format("{0}", inter);
        }
    }
}
