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
    public partial class Form1 : Form
    {
        // Form1 Constructor
        public Form1()
        {
            InitializeComponent();
        } // end of Method

        // Play Game Button
        // Selects Difficulty Level uses the Board Class to dynamically create grid
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            PlayerStats player = new PlayerStats();
            PlayerStats.FiletoList();
            if (textBox1.Text != "")
            {
                int difficulty = 0;
                RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3 };
                for (int selection = 0; selection < radioButtons.Length; selection++)
                {
                    if (radioButtons[selection].Checked)
                    {
                        difficulty = selection + 1;
                    }// End of if
                }// End of if
                player.Initials = textBox1.Text;
                player.Score = 0;
                PlayerStats.playerStats.Add(player);

                Form2 frm2 = new Form2(difficulty);
                frm2.Show();
                Hide();
            }// End of if
            else
            {
                MessageBox.Show("Please enter initials before starting.");
            }// End of else
        }// End of Method

        // Method Not Used
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Does Nothing
        }
    }
}