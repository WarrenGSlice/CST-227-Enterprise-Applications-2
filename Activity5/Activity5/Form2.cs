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
 * This is my own work *
 * CST-227 6/16/2021 * *
 *  Activity 5 * * * * *
 * WACK-A-MOLE * * * * *
 * * * * * * * * * * * */

namespace Activity5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = ScoreList.scoreList; // Shows the high scores stored in the ScoreList
            listBox1.DataSource = bs;
        }
    }
}
