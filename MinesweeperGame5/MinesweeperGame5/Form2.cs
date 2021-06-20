using MinesweeperClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/19/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperGame5
{
    public partial class Form2 : Form
    {
        // Variables
        public Button[,] buttonGrid = new Button[12, 12]; // Used to hold button grid for GUI
        static public int size = 12; // Used to set the size of the board
        static Board board; // Used to hold the board
        public int turnCount = 0; // Used to hold turn Counter
        private Stopwatch watch = new Stopwatch(); // Creates new instance of the stopwatch
        int liveCount = 0; // Used to hold bomb counts
        int visitedCount = 0; // Used to hold number of times a cell is clicked
        string elapsedTime = ""; // Used to hold the Time Text

        public Form2()
        {
            InitializeComponent();
            this.Hide();

            populateGrid();
        }  // end of Method

        // Dynamically Creates the Minesweeper Board Game and calls the mouseDown method with the gameplay
        // Programming in it
        public void populateGrid()
        {
            int buttonSize = gameBoardPanel.Width / size;
            gameBoardPanel.Height = gameBoardPanel.Width;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    board = new Board(size, Form1.Difficulty);
                    buttonGrid[row, col] = new Button();
                    buttonGrid[row, col].Width = buttonSize;
                    buttonGrid[row, col].Height = buttonSize;
                    buttonGrid[row, col].MouseDown += button_MouseDown;
                    gameBoardPanel.Controls.Add(buttonGrid[row, col]);
                    buttonGrid[row, col].Location = new Point(buttonSize * row, buttonSize * col);
                    buttonGrid[row, col].Tag = row.ToString() + "|" + col.ToString();
                } // end of for
            } // end of for
        } // end of Method

        // This Method controls the game play. If the right mouse button is pushed then a flag will appear
        // If a Left mouse button is pushed then it will play regular mode
        // If you lose reveals all bombs
        // If you win, reveals all flags
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            // Variables
            int currentLiveCount = 0; // Used to keep track of current bomb counts
            int currentVisitedCount = 0; // Used to keep track of curent flag counts

            // If the user is right-clicking, add a flag
            if (e.Button == MouseButtons.Right)
            {
                string[] strArr = (sender as Button).Tag.ToString().Split('|');
                int row = int.Parse(strArr[0]);
                int col = int.Parse(strArr[1]);
                board.Grid[row, col].Visited = false;
                buttonGrid[row, col].BackgroundImage = gameImageList.Images[1];
                buttonGrid[row, col].BackgroundImageLayout = ImageLayout.Center;
            }
            else // Left click, normal game play
            {
                watch.Start(); // start the timer
                gameTimer.Enabled = true;
                string[] strArr = (sender as Button).Tag.ToString().Split('|');
                int row = int.Parse(strArr[0]);
                int col = int.Parse(strArr[1]);
                // If there is a bomb in the clicked cell
                if (board.Grid[row, col].Live)
                {
                    foreach (var cell in board.Grid)
                    {
                        cell.Visited = true;
                        buttonGrid[cell.Row, cell.Col].BackColor = Color.LightBlue; //change color
                        // If the cell has a bomb, show the bomb image
                        if (cell.Live)
                        {
                            buttonGrid[cell.Row, cell.Col].BackgroundImage = gameImageList.Images[0];
                            buttonGrid[cell.Row, cell.Col].BackgroundImageLayout = ImageLayout.Center;
                        } // end of if

                    } // end of if
                    watch.Stop(); // stop the time
                    gameTimer.Enabled = false;
                    // Display you lose
                    DialogResult dialogResult = MessageBox.Show("Game over!", "", MessageBoxButtons.OKCancel); 
                    // If Game over message appears, go to the play again form and close this form
                    if (dialogResult == DialogResult.OK)
                    {
                        Results f3 = new Results();
                        this.Close();
                        f3.Show();
                    } // end of if
                    else // otherwise close the application
                    {
                        Application.Exit();
                        this.Close();
                    } // end of if
                    gameTimer.Enabled = false;
                }
                else // If there is not a bomb in the clicked cell
                {
                    floodFill(row, col); // Use flood fill recursive method
                } // end of if
                foreach (var cell in board.Grid)
                {
                    if (cell.Live)
                    {
                        currentLiveCount += 1;
                    }
                    if (cell.Visited)
                    {
                        currentVisitedCount += 1;
                        buttonGrid[cell.Row, cell.Col].BackColor = Color.LightBlue;
                        if (cell.LiveNeighbors > 0)
                        {
                            buttonGrid[cell.Row, cell.Col].Text = cell.LiveNeighbors.ToString();
                        } // end of if
                        else
                        {
                            buttonGrid[cell.Row, cell.Col].Text = "";
                        } // end of if
                    } // end of if
                } // end of if
                //updates visited count
                if (currentVisitedCount > visitedCount)
                {
                    visitedCount = visitedCount + (currentVisitedCount - visitedCount);
                } // end of if
                // updated live count
                if (currentLiveCount > liveCount)
                {
                    liveCount = liveCount + (currentLiveCount - liveCount);
                } // end of if
                turnCount += 1; //increments count each click
                turnsCountLabel.Text = turnCount.ToString();
                // If The User has reveals all cells 
                if (visitedCount == (144 - liveCount))
                {
                    foreach (var cell in board.Grid)
                    {
                        cell.Visited = true;
                        buttonGrid[cell.Row, cell.Col].BackColor = Color.LightBlue;
                        // Turn all the bomb cells into flag cells
                        if (cell.Live)
                        {
                            buttonGrid[cell.Row, cell.Col].BackgroundImage = gameImageList.Images[1];
                            buttonGrid[cell.Row, cell.Col].BackgroundImageLayout = ImageLayout.Center;
                        } // end of if

                    } // end of if
                    watch.Stop();
                    gameTimer.Enabled = false;
                    // Display Youve won message
                    DialogResult dialogResult = MessageBox.Show("You've Won!!" + "\n" + "Your total game time was: " + elapsedTime, "", MessageBoxButtons.OKCancel);
                    // If youve won message appears, go to play again form
                    if (dialogResult == DialogResult.OK)
                    {
                        Results f3 = new Results();
                        this.Close();
                        f3.Show();
                    } // end of if
                    else //otherwise close the application
                    {
                        Application.Exit();
                        this.Close();
                    } // end of if
                } // end of if
            } // end of if
        } // end of Method

        // Fixes the out of bounds error
        static bool fixError(int row, int col)
        {
            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                return true;
            } // end of if
            else
            {
                return false;
            } // end of if
        } // end of Method

        // Performs flood fill for Form 2 mouseDown method
        static public void floodFill(int row, int col)
        {
            if (!fixError(row, col) || board.Grid[row, col].Visited)
            {
                return;
            } // end of if
            board.Grid[row, col].Visited = true;
            if (board.Grid[row, col].LiveNeighbors == 0)
            {

                floodFill(row + 1, col);
                floodFill(row - 1, col);
                floodFill(row, col + 1);
                floodFill(row, col - 1);
            } // end of if
        } // end of Method

        // Formats the Timer and gets it to display correct messages
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            Results.timespan = ts;
            elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            displayTimerLabel.Text = elapsedTime;
        } // end of Method
        // Exit Button 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Debug.Close();
        } // end of Method
        // Form Closing method, tried to use it to close the debugger after closing the application
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Close();
        } // end of Method
    }
}

