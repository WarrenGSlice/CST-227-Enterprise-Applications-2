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
 * 6/11/2021 CST-227
 * Acitivty 4 * * * *
 * Hero Maker dual form
 * This is my own work
 * * * * * * * * * * */

namespace HeroMaker
{
    public partial class Form2 : Form
    {
        String nameFromForm1; // passes variable between forms

        public Form2(String mn)
        {
            InitializeComponent();
            nameFromForm1 = mn; // for passing variable via constructor
        } // end of method

        // Loads the Hero Objects when Form 2 is loaded
        private void Form2_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource(); 
            bindingSource.DataSource = SuperHeroList.listOfHeros;
            heroListBox.DataSource = bindingSource;
            heroListBox.DisplayMember = "name";
            aboutLabel.Text = (nameFromForm1 + " Was Added Last");
        } // end of method

        // Okay Button
        private void okBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        } // end of method

        // Tells the List box what to show and where to find it
        private void heroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string skills = "";
            foreach (var abilities in SuperHeroList.listOfHeros[heroListBox.SelectedIndex].Skills)
            {
                skills += abilities + ", ";
            }
            aboutTextBox.Text = "Name: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].Name
           + Environment.NewLine + "Special Abilities: " + skills
           + Environment.NewLine + "Birthday: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].ImportantDates[0].ToString()
           + Environment.NewLine + "Super Power Origin Date: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].ImportantDates[1].ToString()
           + Environment.NewLine + "Power Mastery Date: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].ImportantDates[2].ToString()
           + Environment.NewLine + "Town of Origin: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].TownOfOrigin
           + Environment.NewLine + "Travel By: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].TravelBy
           + Environment.NewLine + "Years Experience: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].YearsExperience.ToString()
           + Environment.NewLine + "Cape Color: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].CapeColor
           + Environment.NewLine + "Villain Potential: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].VillainPotential.ToString()
           + Environment.NewLine + "Speed: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].StatsArray[0].ToString()
           + Environment.NewLine + "Stamina: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].StatsArray[1].ToString()
           + Environment.NewLine + "Strength: " + SuperHeroList.listOfHeros[heroListBox.SelectedIndex].StatsArray[2].ToString();
        } // end of method
    } //end of class
} // end of namespace
