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
 * This is my own work *
 * CST-227 6/16/2021 * *
 *  Activity 5 * * * * *
 * WACK-A-MOLE * * * * *
 * * * * * * * * * * * */

namespace Activity5
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch(); // Creates new instance of the Stopwatch Object
        public Random random = new Random(); // Creates new instance of the Random Object
        // Variables
        private int hits = 0; // hits variable keeps tracking of score
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Sets time interval to 1 second

            MissButton.SendToBack(); // Allows a button background to cover the entire game surface
            // Default target images
            FalseTargetPictureBox.BackgroundImage = global::Activity5.Properties.Resources.redX;
            TargetPictureBox.BackgroundImage = global::Activity5.Properties.Resources.mole;
        }
        // Start Button
        private void StartButton_Click(object sender, EventArgs e)
        {
            watch.Start();
        }
        // Stop Button
        private void StopButton_Click(object sender, EventArgs e)
        {
            watch.Stop();
        }
        // Reset Button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            watch.Reset();
            ScoreNumberLabel.Text = "0";
        }
        // Timer Tick Counter
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            // 6. Upgrades the time format to be more visually appealing
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label1.Text = elapsedTime;
            // Invokes the Play Game method that includes completed challenges
            PlayGame();
        }

        private void TargetButton_Click(object sender, EventArgs e)
        {
            // Nothing happens here anymore, upgraded to PictureBox Targets
        }

        // Play Game method allows for improved gameplay features that include:
        // 1. Keeps score of the number of hits on targets and missed targets
        // 2. Subtracts points for misses
        // 3. Uses Picture Box controls to modify appearance
        // 4. Determines that game will end after a score of 40 or -1 happens
        // 7. Uses 3 other false targets that detract points
        // 8. Increases difficulty by creating more decoys every 10 points scored
        // 9. Level changes every 10 points and displays a new background image
        private void PlayGame()
        {
            if (watch.IsRunning)
            {
                TargetPictureBox.Left = random.Next(0, this.Width);
                TargetPictureBox.Top = random.Next(0, this.Height);
                FalseTargetPictureBox.Left = random.Next(0, this.Width);
                FalseTargetPictureBox.Top = random.Next(0, this.Height);
                TargetPictureBox.Visible = true;
                FalseTargetPictureBox.Visible = true;
                MissButton.BackgroundImage = global::Activity5.Properties.Resources.purple_background;
            }
            if(watch.IsRunning && hits >= 10)
            {
                FalseTargetPictureBox1.Left = random.Next(0, this.Width);
                FalseTargetPictureBox1.Top = random.Next(0, this.Height);
                FalseTargetPictureBox1.Visible = true;
                MissButton.BackgroundImage = global::Activity5.Properties.Resources.background2;
            }
            if(watch.IsRunning && hits >= 20)
            {
                FalseTargetPictureBox2.Left = random.Next(0, this.Width);
                FalseTargetPictureBox2.Top = random.Next(0, this.Height);
                FalseTargetPictureBox2.Visible = true;
                MissButton.BackgroundImage = global::Activity5.Properties.Resources.background3;
            }
            if(watch.IsRunning && hits >= 30)
            {
                FalseTargetPictureBox3.Left = random.Next(0, this.Width);
                FalseTargetPictureBox3.Top = random.Next(0, this.Height);
                FalseTargetPictureBox3.Visible = true;
                MissButton.BackgroundImage = global::Activity5.Properties.Resources.background4;
            }
            if(hits == 40 || hits == -1)
            {
                watch.Stop();
                timer1.Stop();
                TargetPictureBox.Visible = false;
                FalseTargetPictureBox.Visible = false;
                FalseTargetPictureBox1.Visible = false;
                FalseTargetPictureBox2.Visible = false;
                FalseTargetPictureBox3.Visible = false;

                string score = ("Your Score is : " + hits + " and your time was : " + label1.Text);
                string scoreMessage = ("GAME OVER.\n" + " Your Score was : " + hits + "\nYour Time was : " + label1.Text);
                MessageBox.Show(scoreMessage); // Shows score after game is over
                ScoreList.scoreList.Add(score); // Uploads information to a second form that keeps track
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
        // Main Target 
        private void TargetPictureBox_Click(object sender, EventArgs e)
        {
            TargetPictureBox.Visible = false;
            hits++;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // Decoy target #1
        private void FalseTargetPictureBox_Click(object sender, EventArgs e)
        {
            FalseTargetPictureBox.Visible = false;
            hits--;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // Makes the targets invisible when the game form first opens
        private void Form1_Load(object sender, EventArgs e)
        {
            TargetPictureBox.Visible = false;
            FalseTargetPictureBox.Visible = false;
            FalseTargetPictureBox1.Visible = false;
            FalseTargetPictureBox2.Visible = false;
            FalseTargetPictureBox3.Visible = false;
        }
        // If the user hits the form and totally misses everything
        private void Form1_Click(object sender, EventArgs e)
        {
            hits--;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // Decoy target #2
        private void FalseTargetPictureBox1_Click(object sender, EventArgs e)
        {
            FalseTargetPictureBox1.Visible = false;
            hits--;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // Decoy target #3
        private void FalseTargetPictureBox2_Click(object sender, EventArgs e)
        {
            FalseTargetPictureBox2.Visible = false;
            hits--;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // Decoy target #4
        private void FalseTargetPictureBox3_Click(object sender, EventArgs e)
        {
            FalseTargetPictureBox3.Visible = false;
            hits--;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // The miss button covers the screen and will detract points if the user misses
        private void MissButton_Click(object sender, EventArgs e)
        {
            hits--;
            ScoreNumberLabel.Text = hits.ToString();
        }
        // Play Again Button restarts game and refreshers timer and score
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            watch.Restart();
            watch.Start();
            timer1.Start();
            hits = 0;
            ScoreNumberLabel.Text = hits.ToString();
            PlayGame();
        }
    }
}
