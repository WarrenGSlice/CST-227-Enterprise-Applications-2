using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        string myName; // used to pass the variable between the form
        public Form1()
        {
            InitializeComponent();
        } // end of method

        private void Form1_Load(object sender, EventArgs e)
        {
            // decided to put this code elsewhere
        } // end of method

        // Cape Color Control Button
        private void capeColorBtn_Click(object sender, EventArgs e)
        {
            if (capeColorDialogBox.ShowDialog() == DialogResult.OK)
            {
                capeColorBtn.BackColor = capeColorDialogBox.Color;
            } // end of if
        } // end of method

        // Speed Scroll Bar Control for stats. completes challenge
        private void speedHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int totalStats = 0;
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                speedValueLabel.Text = e.NewValue.ToString();
                try
                {
                    totalStats = e.NewValue + staminaHScrollBar.Value + strengthHScrollBar.Value;
                    if (totalStats > 100)
                    {
                        e.NewValue = e.NewValue - 1;
                        throw new Exception("Stats can not be more than 100, please lower your stats."); // makes stats add up to less than 100
                    } // end of it
                } // end of try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } // end of catch
            } // end of if
        } // end of method

        // Stamina Scroll Bar Control for stats. completes challenge
        private void staminaHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int totalStats = 0;
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                staminaValueLabel.Text = e.NewValue.ToString();
                try
                {
                    totalStats = e.NewValue + speedHScrollBar.Value + strengthHScrollBar.Value;
                    if (totalStats > 100)
                    {
                        e.NewValue = e.NewValue - 1;
                        throw new Exception("Stats can not be more than 100, please lower your stats.");// makes stats add up to less than 100
                    } // end of if
                } // end of try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } // end of catch
            } // end of if
        } // end of method

        // Strength Scroll Bar Control for stats. completes challenge
        private void strengthHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int totalStats = 0;
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                strengthValueLabel.Text = e.NewValue.ToString();
                try
                {
                    totalStats = e.NewValue + speedHScrollBar.Value + staminaHScrollBar.Value;
                    if (totalStats > 100)
                    {
                        e.NewValue = e.NewValue - 1;
                        throw new Exception("Stats can not be more than 100, please lower your stats.");// makes stats add up to less than 100
                    } // end of if
                } // end of try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } // end of catch
            } // end of if
        } // end of method

        // Vilinous Track Bar to determine how evil someone is
        private void villainPotentialTrackBar_Scroll(object sender, EventArgs e)
        {
            villainPotentialValueLabel.Text = villainPotentialTrackBar.Value.ToString();
        } // end of method

        // Picture Box control to upload photos of hero
        private void portraitPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                portraitPictureBox.Size = new System.Drawing.Size(240, 240);
                portraitPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                portraitPictureBox.Image = new Bitmap(open.FileName);
            } // end of it
        } // end of method

        // Create hero Button
        private void createHeroBtn_Click(object sender, EventArgs e)
        {
            // Variables used to pass info to second form
            string name = herosNameTextBox.Text;
            ArrayList skills = new ArrayList();
            string townOfOrigin = OriginListBox.SelectedItem.ToString();
            string travelBy = "";
            decimal yearsExperience = yearsExperienceNumberSpinner.Value;
            string capeColor = capeColorDialogBox.Color.ToString();
            int villainPotential = villainPotentialTrackBar.Value;
            string portraitFile = portraitPictureBox.Name;

            // Skills added when button is clicked
            if (superStrengthCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Super Strength");
            } // end of if
            if (flightCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Flight");
            }// end of if
            if (xRayVisionCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("X-Ray Vision");
            }// end of if
            if (invisibilityCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Invisibility");
            }// end of if
            if (healingCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Healing");
            }// end of if
            if (telekinesisCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Telekinesis");
            }// end of if
            if (ShapeShifterCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Shape Shifting");
            }// end of if
            if (ElementalCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Elemental Control");
            }// end of if
            if (MindControlCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Mind Control");
            }// end of if
            if (MultiverseCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Multiversal Control");
            }// end of if
            if (underWaterControlCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("UnderWater Control");
            }// end of if
            if (SuperSpeedCheckBox.CheckState == CheckState.Checked)
            {
                skills.Add("Super Speed");
            }// end of if

            //Dates are uploaded when user adds hero
            DateTime[] importantDates = new DateTime[3] { birthdayDatePicker.Value, superPowerDiscoveryDatePicker.Value, fatefulDayDatePicker.Value };

            // Used to upload travel by methods when hero is added
            if (jetpackRadioBtn.Checked)
            {
                travelBy = "Jetpack";
            }// end of if
            if (HelicopterRadioBtn.Checked)
            {
                travelBy = "Helicopter";
            }// end of if
            if (teleportRadioBtn.Checked)
            {
                travelBy = "Teleport";
            }// end of if
            if (carRadioBtn.Checked)
            {
                travelBy = "Car";
            }// end of if

            // Sets the stats to the hero when hero is added
            int[] stats = new int[3] { speedHScrollBar.Value, staminaHScrollBar.Value, strengthHScrollBar.Value };

            // Passes hero information when button is clicked
            myName = herosNameTextBox.Text;
            SuperHero superHero = new SuperHero(name, skills, townOfOrigin, travelBy, importantDates, yearsExperience, capeColor, villainPotential, stats, portraitFile);
            SuperHeroList.listOfHeros.Add(superHero);
            Form2 f2 = new Form2(myName);
            f2.Show();
            this.Hide();
        } // end of method
    } // end of class
} // end of namespace
