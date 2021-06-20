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
 * CST-227 6/19/2021 * *
 * * * Milestone 2 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperGame5
{
    public partial class Form1 : Form
    {
        // variable
        public static int Difficulty { get; set; } // Used to set difficulty

        public Form1()
        {
            InitializeComponent();
        } // end of Method

        // Easy CheckBox
        private void easyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (easyCheckBox.CheckState == CheckState.Checked)
            {
                Difficulty = 33;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            } // end of if
        } // end of Method
        // Moderate Checkbox
        private void moderateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (moderateCheckBox.CheckState == CheckState.Checked)
            {
                Difficulty = 66;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            } // end of if
        } // end of Method

        // Hard Checkbox
        private void hardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hardCheckBox.CheckState == CheckState.Checked)
            {
                Difficulty = 99;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            } // end of if
        } // end of Method
        //Play Game Again Button
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            //Nothing Yet
        } // end of Method
    }
}