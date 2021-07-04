using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Results : Form
    {
        // Variables
        static public TimeSpan timespan; // Used to keep track of time
        //Empty Constructor Method
        public Results()
        {
            InitializeComponent();
            SetBindings();
        } // End of Method

        // Play Again Button
        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            PlayerStats.playerStats.Clear();
            Form1 newGame = new Form1();
            this.Hide();
            newGame.Show();
        }// end of Method

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Close();
            //Application.Exit();
        }// end of Method

        // Form Closing Method
        private void Results_FormClosed(object sender, EventArgs e)
        {
            Dispose(true);
            Close();
            //Application.Exit();
        }// end of Method
    }// end of Class
}// end of Namespace
