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
 * CST-227 7/03/2021 * *
 * * * Milestone 6 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperGame6
{
    public partial class Form2 : Form
    {
        // Variables
        private PlayerStats playerStat = new PlayerStats(); // Creates new instance of PlayerStats Objects
        private Stopwatch watch = new Stopwatch(); // Creates new instance of the stopwatch
        static Board board; // Used to hold the board
        public static int Difficulty = 1; // Used to hold difficulty
        public Button[,] btnGrid = new Button[Difficulty * 10, Difficulty * 10]; // Used to create dynamic board that changes based on difficulty
        string elapsedTime = ""; // Used to hold the Time Text

        //Form Constructor recieves argument for difficulty adjustment. Starts grid, stopwatch and timer
        public Form2(int difficulty)
        {
            InitializeComponent();
            Difficulty = difficulty;
            PopulateGrid();
            watch.Start();
            playerStat.Timer = watch.Elapsed;
        }// End of Method

        // Dynamically Creates the Minesweeper Board Game and calls the mouseUp method with the gameplay
        public void PopulateGrid()
        {
            int buttonSize = 32;
            gameBoardPanel.Width = buttonSize * (Difficulty * 10);
            gameBoardPanel.Height = gameBoardPanel.Width;
            Button[,] buttonGrid = new Button[Difficulty * 10, Difficulty * 10];
            btnGrid = buttonGrid;
            board = new Board(Difficulty * 10, Difficulty);
            board.InitializeGrid();
            board.SetupLiveNeighbors();
            for (int row = 0; row < Difficulty * 10; row++)
            {
                for (int col = 0; col < Difficulty * 10; col++)
                {
                    btnGrid[row, col] = new Button
                    {
                        //makes them square
                        Width = buttonSize,
                        Height = buttonSize
                    };
                    btnGrid[row, col].MouseUp += Mouse_Up_Click; //Same click event for each button
                    gameBoardPanel.Controls.Add(btnGrid[row, col]);
                    btnGrid[row, col].Location = new Point(buttonSize * row, buttonSize * col);
                }// End of For
            }// End of for
        }// End of Method

        //Show numbers if neighbor cells have bombs, and Check to see if the Game has been Won.
        public void UpdateNeighbors()
        {
            // Variables
            int count = 0; // Variable to hold move count
            int mines = 0; // Variable to hold bomb count
            bool hasWon = false; // Variable to hold game condition
            // Loop is like method in Board class but has ability to add colors and images and calculate player score
            for (int cols = 0; cols < Difficulty * 10; cols++)
            {
                for (int rows = 0; rows < Difficulty * 10; rows++)
                {
                    if (board.Grid[rows, cols].Visited == true)// if this cell is Visited
                    {
                        count++;
                        // if this cell has a live neighbor and this cell is not a bomb image and this cell is not a bomb
                        if (board.Grid[rows, cols].LiveNeighbors != 0 && btnGrid[rows, cols].BackgroundImage != gameImageList.Images[1] && !board.Grid[rows, cols].Live)
                        {
                            btnGrid[rows, cols].Text = board.Grid[rows, cols].LiveNeighbors.ToString(); // change cell text
                        }
                        btnGrid[rows, cols].BackColor = Color.Aquamarine; // change the color
                        //btnGrid[row, cols].Font.Bold = true;
                        btnGrid[rows, cols].Enabled = false;
                        playerStat.Score += 10 * Difficulty; // change player score
                    }
                    if (board.Grid[rows, cols].Live) // if this cell is a bomb
                    {
                        mines++;
                    }
                }
            }
            // checks for win condition if all cells have been checked besides the bombs
            if (count == (((Difficulty * 10) * (Difficulty * 10))/* - mines*/))
            {
                for (int column = 0; column < Difficulty * 10; column++)
                {
                    for (int rows = 0; rows < Difficulty * 10; rows++)
                    {
                        if (board.Grid[rows, column].Live)
                        {
                            board.Grid[rows, column].Visited = true;
                            btnGrid[rows, column].BackgroundImage = gameImageList.Images[1];
                            btnGrid[rows, column].BackgroundImageLayout = ImageLayout.Center;
                            hasWon = true;
                        }
                    }
                }
            }
            if (hasWon)
            {
                CalculateEndGame();
            }
        }

        // This Method controls the game play. If the right mouse button is pushed then a flag will appear
        // If a Left mouse button is pushed then it will play regular mode
        // If you lose reveals all bombs
        // If you win, reveals all flags
        public void Mouse_Up_Click(object sender, MouseEventArgs e)
        {
            bool hasWon = false;
            for (int row = 0; row < Difficulty * 10; row++)
            {
                for (int col = 0; col < Difficulty * 10; col++)
                {
                    if ((sender as Button).Equals(btnGrid[row, col]))
                    {
                        if (e.Button == MouseButtons.Right)// If the user is right-clicking, then just add/remove flag
                        {
                            if (btnGrid[row, col].BackgroundImage == null)
                            {
                                btnGrid[row, col].BackgroundImage = gameImageList.Images[1];
                                btnGrid[row, col].BackgroundImageLayout = ImageLayout.Center;
                                btnGrid[row, col].Enabled = true;
                                board.Grid[row, col].Visited = true;
                                playerStat.Score += 100 * Difficulty; //Add score if cell is bomb
                                if (!board.Grid[row, col].Live)
                                {
                                    playerStat.Score -= 150 * Difficulty; //Penalty for flagging non-bomb cell
                                    btnGrid[row, col].BackgroundImage = gameImageList.Images[0];
                                    btnGrid[row, col].BackgroundImageLayout = ImageLayout.Center;
                                }
                            }
                            else
                            {
                                btnGrid[row, col].Enabled = true;
                                btnGrid[row, col].BackgroundImage.Dispose();
                                board.Grid[row, col].Visited = false;
                                playerStat.Score -= 100 * Difficulty;
                            }
                        }
                        else
                        {
                            if (board.Grid[row, col].Live) // Check if user hit a bomb
                            {
                                // Set clicked bomb's background to red
                                btnGrid[row, col].BackColor = Color.FromArgb(235, 51, 35);
                                btnGrid[row, col].BackgroundImage = gameImageList.Images[0];
                                btnGrid[row, col].BackgroundImageLayout = ImageLayout.Center;
                                hasWon = true;
                            }
                            else
                            {
                                if (board.Grid[row, col].LiveNeighbors == 0 && !board.Grid[row, col].Live)
                                {
                                    board.CheckSurround(row, col);
                                }
                                board.Grid[row, col].Visited = true;
                            }
                        }
                    }
                }
            }
            if (hasWon)
            {
                CalculateEndGame();
            }
            UpdateNeighbors();

            //Set Background of clicked button to a different color
            (sender as Button).BackColor = Color.Aquamarine;

        }

        // Reveals all bombs, flags, cells when game ends
        private void EndGameReveal()
        {
            for (int col = 0; col < Difficulty * 10; col++)
            {
                for (int row = 0; row < Difficulty * 10; row++)
                {
                    if (board.Grid[row, col].Live && btnGrid[row, col].BackgroundImage != gameImageList.Images[1])
                    {
                        btnGrid[row, col].BackgroundImage = gameImageList.Images[0];
                        btnGrid[row, col].BackgroundImageLayout = ImageLayout.Center;
                    }// End of if

                    if (board.Grid[row, col].LiveNeighbors > 0 && !board.Grid[row, col].Live)
                    {
                        btnGrid[row, col].Text = board.Grid[row, col].LiveNeighbors.ToString();
                    }// End of if

                }// End of for
            }// End of for
        }// End of Method

        //When Game is finished show appropriate message and display high score list page.
        private void CalculateEndGame()
        {
            watch.Stop();
            playerStat.Timer = watch.Elapsed;
            int count = PlayerStats.playerStats.Count - 1;
            playerStat.Initials = PlayerStats.playerStats.ElementAt(count).Initials;
            PlayerStats.playerStats.ElementAt(count).Score = playerStat.Score;
            PlayerStats.playerStats.ElementAt(count).Time = Math.Round(playerStat.Timer.TotalSeconds, 2);
            PlayerStats.ScoreOutput();
            EndGameReveal();
            if (board.AllSafeTilesVisited()) // If all safe Tiles have been Visited
            {
                if (playerStat.Timer.TotalSeconds <= 60) // If the player won fast
                {
                    playerStat.Score += 750 * Difficulty;
                }// end of if

                // If the player won in a decent time
                else if (playerStat.Timer.TotalSeconds >= 60 && playerStat.Timer.TotalSeconds <= 250)
                {
                    playerStat.Score += 500 * Difficulty;
                }// end of else if

                else // If the player took forever
                {
                    playerStat.Score += 250 * Difficulty;
                }// end of else

                MessageBox.Show(string.Format("{0} WON! Length of play was: {1}. Your score was: {2}!", playerStat.Initials, playerStat.Timer.TotalSeconds, playerStat.Score.ToString()));
            }// End of if

            else // If The player hit a Bomb
            {
                ;
                MessageBox.Show(string.Format("{0} hit a Mine! Length of play was: {1}. Your score was: {2}!", playerStat.Initials, playerStat.Timer.TotalSeconds, playerStat.Score.ToString()));
            } // end of else

            Results form = new Results();
            form.Show();
            Hide();
        }// End of Method

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
            Dispose(true);
            Close();
            Application.Exit();
        } // end of Method

        // Form Closing method, tried to use it to close the debugger after closing the application
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
            Close();
            Application.Exit();
        } // end of Method
    }
}

