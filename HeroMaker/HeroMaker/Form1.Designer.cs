/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/11/2021 CST-227
 * Acitivty 4 * * * *
 * Hero Maker dual form
 * This is my own work
 * * * * * * * * * * */

namespace HeroMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        } // end of method

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.herosNameTextBox = new System.Windows.Forms.TextBox();
            this.specialAbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.telekinesisCheckBox = new System.Windows.Forms.CheckBox();
            this.SuperSpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.underWaterControlCheckBox = new System.Windows.Forms.CheckBox();
            this.MultiverseCheckBox = new System.Windows.Forms.CheckBox();
            this.MindControlCheckBox = new System.Windows.Forms.CheckBox();
            this.ElementalCheckBox = new System.Windows.Forms.CheckBox();
            this.ShapeShifterCheckBox = new System.Windows.Forms.CheckBox();
            this.healingCheckBox = new System.Windows.Forms.CheckBox();
            this.invisibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.xRayVisionCheckBox = new System.Windows.Forms.CheckBox();
            this.flightCheckBox = new System.Windows.Forms.CheckBox();
            this.superStrengthCheckBox = new System.Windows.Forms.CheckBox();
            this.importantDatesGroupBox = new System.Windows.Forms.GroupBox();
            this.fatefulDayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.superPowerDiscoveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.powerMasteryDayLabel = new System.Windows.Forms.Label();
            this.superPowerOriginLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.officeLocationsLabel = new System.Windows.Forms.Label();
            this.OriginListBox = new System.Windows.Forms.ListBox();
            this.TransportationGroupBox = new System.Windows.Forms.GroupBox();
            this.carRadioBtn = new System.Windows.Forms.RadioButton();
            this.teleportRadioBtn = new System.Windows.Forms.RadioButton();
            this.HelicopterRadioBtn = new System.Windows.Forms.RadioButton();
            this.jetpackRadioBtn = new System.Windows.Forms.RadioButton();
            this.yearsExperienceLabel = new System.Windows.Forms.Label();
            this.yearsExperienceNumberSpinner = new System.Windows.Forms.NumericUpDown();
            this.capeColorLabel = new System.Windows.Forms.Label();
            this.capeColorDialogBox = new System.Windows.Forms.ColorDialog();
            this.capeColorBtn = new System.Windows.Forms.Button();
            this.villainPotentialTrackBar = new System.Windows.Forms.TrackBar();
            this.villainPotentialLabel = new System.Windows.Forms.Label();
            this.portraitLabel = new System.Windows.Forms.Label();
            this.portraitPictureBox = new System.Windows.Forms.PictureBox();
            this.createHeroBtn = new System.Windows.Forms.Button();
            this.speedHScrollBar = new System.Windows.Forms.HScrollBar();
            this.staminaHScrollBar = new System.Windows.Forms.HScrollBar();
            this.strengthHScrollBar = new System.Windows.Forms.HScrollBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.heroStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.strengthValueLabel = new System.Windows.Forms.Label();
            this.staminaValueLabel = new System.Windows.Forms.Label();
            this.speedValueLabel = new System.Windows.Forms.Label();
            this.villainPotentialValueLabel = new System.Windows.Forms.Label();
            this.specialAbilitiesGroupBox.SuspendLayout();
            this.importantDatesGroupBox.SuspendLayout();
            this.TransportationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperienceNumberSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villainPotentialTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portraitPictureBox)).BeginInit();
            this.heroStatsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.AutoSize = true;
            this.HeroNameLabel.BackColor = System.Drawing.Color.Red;
            this.HeroNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeroNameLabel.ForeColor = System.Drawing.Color.Black;
            this.HeroNameLabel.Location = new System.Drawing.Point(24, 26);
            this.HeroNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(117, 17);
            this.HeroNameLabel.TabIndex = 0;
            this.HeroNameLabel.Text = "Super Hero Name";
            // 
            // herosNameTextBox
            // 
            this.herosNameTextBox.BackColor = System.Drawing.Color.Black;
            this.herosNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.herosNameTextBox.ForeColor = System.Drawing.Color.White;
            this.herosNameTextBox.Location = new System.Drawing.Point(145, 23);
            this.herosNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.herosNameTextBox.Name = "herosNameTextBox";
            this.herosNameTextBox.PlaceholderText = "Type Hero Name Here";
            this.herosNameTextBox.Size = new System.Drawing.Size(300, 25);
            this.herosNameTextBox.TabIndex = 1;
            // 
            // specialAbilitiesGroupBox
            // 
            this.specialAbilitiesGroupBox.BackColor = System.Drawing.Color.Black;
            this.specialAbilitiesGroupBox.Controls.Add(this.telekinesisCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.SuperSpeedCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.underWaterControlCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.MultiverseCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.MindControlCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.ElementalCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.ShapeShifterCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.healingCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.invisibilityCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.xRayVisionCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.flightCheckBox);
            this.specialAbilitiesGroupBox.Controls.Add(this.superStrengthCheckBox);
            this.specialAbilitiesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialAbilitiesGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.specialAbilitiesGroupBox.ForeColor = System.Drawing.Color.Red;
            this.specialAbilitiesGroupBox.Location = new System.Drawing.Point(25, 57);
            this.specialAbilitiesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.specialAbilitiesGroupBox.Name = "specialAbilitiesGroupBox";
            this.specialAbilitiesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.specialAbilitiesGroupBox.Size = new System.Drawing.Size(315, 176);
            this.specialAbilitiesGroupBox.TabIndex = 2;
            this.specialAbilitiesGroupBox.TabStop = false;
            this.specialAbilitiesGroupBox.Text = "Special Abilities";
            // 
            // telekinesisCheckBox
            // 
            this.telekinesisCheckBox.AutoSize = true;
            this.telekinesisCheckBox.BackColor = System.Drawing.Color.Black;
            this.telekinesisCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telekinesisCheckBox.ForeColor = System.Drawing.Color.White;
            this.telekinesisCheckBox.Location = new System.Drawing.Point(13, 139);
            this.telekinesisCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.telekinesisCheckBox.Name = "telekinesisCheckBox";
            this.telekinesisCheckBox.Size = new System.Drawing.Size(94, 21);
            this.telekinesisCheckBox.TabIndex = 3;
            this.telekinesisCheckBox.Text = "Telekinesis";
            this.telekinesisCheckBox.UseVisualStyleBackColor = false;
            // 
            // SuperSpeedCheckBox
            // 
            this.SuperSpeedCheckBox.AutoSize = true;
            this.SuperSpeedCheckBox.BackColor = System.Drawing.Color.Black;
            this.SuperSpeedCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SuperSpeedCheckBox.ForeColor = System.Drawing.Color.White;
            this.SuperSpeedCheckBox.Location = new System.Drawing.Point(151, 139);
            this.SuperSpeedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SuperSpeedCheckBox.Name = "SuperSpeedCheckBox";
            this.SuperSpeedCheckBox.Size = new System.Drawing.Size(103, 21);
            this.SuperSpeedCheckBox.TabIndex = 10;
            this.SuperSpeedCheckBox.Text = "Super Speed";
            this.SuperSpeedCheckBox.UseVisualStyleBackColor = false;
            // 
            // underWaterControlCheckBox
            // 
            this.underWaterControlCheckBox.AutoSize = true;
            this.underWaterControlCheckBox.BackColor = System.Drawing.Color.Black;
            this.underWaterControlCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.underWaterControlCheckBox.ForeColor = System.Drawing.Color.White;
            this.underWaterControlCheckBox.Location = new System.Drawing.Point(151, 116);
            this.underWaterControlCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.underWaterControlCheckBox.Name = "underWaterControlCheckBox";
            this.underWaterControlCheckBox.Size = new System.Drawing.Size(150, 21);
            this.underWaterControlCheckBox.TabIndex = 9;
            this.underWaterControlCheckBox.Text = "UnderWater Control";
            this.underWaterControlCheckBox.UseVisualStyleBackColor = false;
            // 
            // MultiverseCheckBox
            // 
            this.MultiverseCheckBox.AutoSize = true;
            this.MultiverseCheckBox.BackColor = System.Drawing.Color.Black;
            this.MultiverseCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MultiverseCheckBox.ForeColor = System.Drawing.Color.White;
            this.MultiverseCheckBox.Location = new System.Drawing.Point(151, 94);
            this.MultiverseCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.MultiverseCheckBox.Name = "MultiverseCheckBox";
            this.MultiverseCheckBox.Size = new System.Drawing.Size(146, 21);
            this.MultiverseCheckBox.TabIndex = 8;
            this.MultiverseCheckBox.Text = "Multiversal Control";
            this.MultiverseCheckBox.UseVisualStyleBackColor = false;
            // 
            // MindControlCheckBox
            // 
            this.MindControlCheckBox.AutoSize = true;
            this.MindControlCheckBox.BackColor = System.Drawing.Color.Black;
            this.MindControlCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MindControlCheckBox.ForeColor = System.Drawing.Color.White;
            this.MindControlCheckBox.Location = new System.Drawing.Point(151, 72);
            this.MindControlCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.MindControlCheckBox.Name = "MindControlCheckBox";
            this.MindControlCheckBox.Size = new System.Drawing.Size(109, 21);
            this.MindControlCheckBox.TabIndex = 7;
            this.MindControlCheckBox.Text = "Mind Control";
            this.MindControlCheckBox.UseVisualStyleBackColor = false;
            // 
            // ElementalCheckBox
            // 
            this.ElementalCheckBox.AutoSize = true;
            this.ElementalCheckBox.BackColor = System.Drawing.Color.Black;
            this.ElementalCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ElementalCheckBox.ForeColor = System.Drawing.Color.White;
            this.ElementalCheckBox.Location = new System.Drawing.Point(151, 50);
            this.ElementalCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ElementalCheckBox.Name = "ElementalCheckBox";
            this.ElementalCheckBox.Size = new System.Drawing.Size(138, 21);
            this.ElementalCheckBox.TabIndex = 6;
            this.ElementalCheckBox.Text = "Elemental Control";
            this.ElementalCheckBox.UseVisualStyleBackColor = false;
            // 
            // ShapeShifterCheckBox
            // 
            this.ShapeShifterCheckBox.AutoSize = true;
            this.ShapeShifterCheckBox.BackColor = System.Drawing.Color.Black;
            this.ShapeShifterCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShapeShifterCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShapeShifterCheckBox.Location = new System.Drawing.Point(151, 27);
            this.ShapeShifterCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShapeShifterCheckBox.Name = "ShapeShifterCheckBox";
            this.ShapeShifterCheckBox.Size = new System.Drawing.Size(117, 21);
            this.ShapeShifterCheckBox.TabIndex = 5;
            this.ShapeShifterCheckBox.Text = "Shape Shifting";
            this.ShapeShifterCheckBox.UseVisualStyleBackColor = false;
            // 
            // healingCheckBox
            // 
            this.healingCheckBox.AutoSize = true;
            this.healingCheckBox.BackColor = System.Drawing.Color.Black;
            this.healingCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healingCheckBox.ForeColor = System.Drawing.Color.White;
            this.healingCheckBox.Location = new System.Drawing.Point(13, 116);
            this.healingCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.healingCheckBox.Name = "healingCheckBox";
            this.healingCheckBox.Size = new System.Drawing.Size(75, 21);
            this.healingCheckBox.TabIndex = 4;
            this.healingCheckBox.Text = "Healing";
            this.healingCheckBox.UseVisualStyleBackColor = false;
            // 
            // invisibilityCheckBox
            // 
            this.invisibilityCheckBox.AutoSize = true;
            this.invisibilityCheckBox.BackColor = System.Drawing.Color.Black;
            this.invisibilityCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.invisibilityCheckBox.ForeColor = System.Drawing.Color.White;
            this.invisibilityCheckBox.Location = new System.Drawing.Point(13, 94);
            this.invisibilityCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.invisibilityCheckBox.Name = "invisibilityCheckBox";
            this.invisibilityCheckBox.Size = new System.Drawing.Size(92, 21);
            this.invisibilityCheckBox.TabIndex = 3;
            this.invisibilityCheckBox.Text = "Invisibility";
            this.invisibilityCheckBox.UseVisualStyleBackColor = false;
            // 
            // xRayVisionCheckBox
            // 
            this.xRayVisionCheckBox.AutoSize = true;
            this.xRayVisionCheckBox.BackColor = System.Drawing.Color.Black;
            this.xRayVisionCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xRayVisionCheckBox.ForeColor = System.Drawing.Color.White;
            this.xRayVisionCheckBox.Location = new System.Drawing.Point(13, 72);
            this.xRayVisionCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.xRayVisionCheckBox.Name = "xRayVisionCheckBox";
            this.xRayVisionCheckBox.Size = new System.Drawing.Size(106, 21);
            this.xRayVisionCheckBox.TabIndex = 2;
            this.xRayVisionCheckBox.Text = "X-Ray Vision";
            this.xRayVisionCheckBox.UseVisualStyleBackColor = false;
            // 
            // flightCheckBox
            // 
            this.flightCheckBox.AutoSize = true;
            this.flightCheckBox.BackColor = System.Drawing.Color.Black;
            this.flightCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightCheckBox.ForeColor = System.Drawing.Color.White;
            this.flightCheckBox.Location = new System.Drawing.Point(13, 50);
            this.flightCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.flightCheckBox.Name = "flightCheckBox";
            this.flightCheckBox.Size = new System.Drawing.Size(63, 21);
            this.flightCheckBox.TabIndex = 1;
            this.flightCheckBox.Text = "Flight";
            this.flightCheckBox.UseVisualStyleBackColor = false;
            // 
            // superStrengthCheckBox
            // 
            this.superStrengthCheckBox.AutoSize = true;
            this.superStrengthCheckBox.BackColor = System.Drawing.Color.Black;
            this.superStrengthCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.superStrengthCheckBox.ForeColor = System.Drawing.Color.White;
            this.superStrengthCheckBox.Location = new System.Drawing.Point(13, 27);
            this.superStrengthCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.superStrengthCheckBox.Name = "superStrengthCheckBox";
            this.superStrengthCheckBox.Size = new System.Drawing.Size(119, 21);
            this.superStrengthCheckBox.TabIndex = 0;
            this.superStrengthCheckBox.Text = "Super Strength";
            this.superStrengthCheckBox.UseVisualStyleBackColor = false;
            // 
            // importantDatesGroupBox
            // 
            this.importantDatesGroupBox.BackColor = System.Drawing.Color.Black;
            this.importantDatesGroupBox.Controls.Add(this.fatefulDayDatePicker);
            this.importantDatesGroupBox.Controls.Add(this.superPowerDiscoveryDatePicker);
            this.importantDatesGroupBox.Controls.Add(this.birthdayDatePicker);
            this.importantDatesGroupBox.Controls.Add(this.powerMasteryDayLabel);
            this.importantDatesGroupBox.Controls.Add(this.superPowerOriginLabel);
            this.importantDatesGroupBox.Controls.Add(this.birthdayLabel);
            this.importantDatesGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.importantDatesGroupBox.ForeColor = System.Drawing.Color.Red;
            this.importantDatesGroupBox.Location = new System.Drawing.Point(327, 57);
            this.importantDatesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.importantDatesGroupBox.Name = "importantDatesGroupBox";
            this.importantDatesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.importantDatesGroupBox.Size = new System.Drawing.Size(272, 176);
            this.importantDatesGroupBox.TabIndex = 3;
            this.importantDatesGroupBox.TabStop = false;
            this.importantDatesGroupBox.Text = "Important Dates";
            // 
            // fatefulDayDatePicker
            // 
            this.fatefulDayDatePicker.Location = new System.Drawing.Point(23, 139);
            this.fatefulDayDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fatefulDayDatePicker.Name = "fatefulDayDatePicker";
            this.fatefulDayDatePicker.Size = new System.Drawing.Size(233, 25);
            this.fatefulDayDatePicker.TabIndex = 5;
            // 
            // superPowerDiscoveryDatePicker
            // 
            this.superPowerDiscoveryDatePicker.Location = new System.Drawing.Point(23, 94);
            this.superPowerDiscoveryDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.superPowerDiscoveryDatePicker.Name = "superPowerDiscoveryDatePicker";
            this.superPowerDiscoveryDatePicker.Size = new System.Drawing.Size(233, 25);
            this.superPowerDiscoveryDatePicker.TabIndex = 4;
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.Location = new System.Drawing.Point(23, 46);
            this.birthdayDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(233, 25);
            this.birthdayDatePicker.TabIndex = 3;
            // 
            // powerMasteryDayLabel
            // 
            this.powerMasteryDayLabel.AutoSize = true;
            this.powerMasteryDayLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.powerMasteryDayLabel.Location = new System.Drawing.Point(23, 121);
            this.powerMasteryDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.powerMasteryDayLabel.Name = "powerMasteryDayLabel";
            this.powerMasteryDayLabel.Size = new System.Drawing.Size(133, 17);
            this.powerMasteryDayLabel.TabIndex = 2;
            this.powerMasteryDayLabel.Text = "Power Mastery Date";
            // 
            // superPowerOriginLabel
            // 
            this.superPowerOriginLabel.AutoSize = true;
            this.superPowerOriginLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.superPowerOriginLabel.Location = new System.Drawing.Point(23, 76);
            this.superPowerOriginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.superPowerOriginLabel.Name = "superPowerOriginLabel";
            this.superPowerOriginLabel.Size = new System.Drawing.Size(161, 17);
            this.superPowerOriginLabel.TabIndex = 1;
            this.superPowerOriginLabel.Text = "Super Power Origin Date";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.Location = new System.Drawing.Point(23, 27);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(60, 17);
            this.birthdayLabel.TabIndex = 0;
            this.birthdayLabel.Text = "Birthday";
            // 
            // officeLocationsLabel
            // 
            this.officeLocationsLabel.AutoSize = true;
            this.officeLocationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.officeLocationsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.officeLocationsLabel.ForeColor = System.Drawing.Color.White;
            this.officeLocationsLabel.Location = new System.Drawing.Point(31, 247);
            this.officeLocationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.officeLocationsLabel.Name = "officeLocationsLabel";
            this.officeLocationsLabel.Size = new System.Drawing.Size(101, 17);
            this.officeLocationsLabel.TabIndex = 4;
            this.officeLocationsLabel.Text = "Town of Origin";
            // 
            // OriginListBox
            // 
            this.OriginListBox.BackColor = System.Drawing.Color.Black;
            this.OriginListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OriginListBox.ForeColor = System.Drawing.Color.White;
            this.OriginListBox.FormattingEnabled = true;
            this.OriginListBox.ItemHeight = 17;
            this.OriginListBox.Items.AddRange(new object[] {
            "Gotham City",
            "New York",
            "London",
            "Paris",
            "Tokyo",
            "Star City",
            "Rome",
            "Starling City",
            "Los Angeles",
            "Portland"});
            this.OriginListBox.Location = new System.Drawing.Point(31, 266);
            this.OriginListBox.Margin = new System.Windows.Forms.Padding(2);
            this.OriginListBox.Name = "OriginListBox";
            this.OriginListBox.Size = new System.Drawing.Size(177, 123);
            this.OriginListBox.TabIndex = 5;
            // 
            // TransportationGroupBox
            // 
            this.TransportationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TransportationGroupBox.Controls.Add(this.carRadioBtn);
            this.TransportationGroupBox.Controls.Add(this.teleportRadioBtn);
            this.TransportationGroupBox.Controls.Add(this.HelicopterRadioBtn);
            this.TransportationGroupBox.Controls.Add(this.jetpackRadioBtn);
            this.TransportationGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TransportationGroupBox.ForeColor = System.Drawing.Color.White;
            this.TransportationGroupBox.Location = new System.Drawing.Point(219, 245);
            this.TransportationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.TransportationGroupBox.Name = "TransportationGroupBox";
            this.TransportationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.TransportationGroupBox.Size = new System.Drawing.Size(148, 142);
            this.TransportationGroupBox.TabIndex = 6;
            this.TransportationGroupBox.TabStop = false;
            this.TransportationGroupBox.Text = "Travel By";
            // 
            // carRadioBtn
            // 
            this.carRadioBtn.AutoSize = true;
            this.carRadioBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carRadioBtn.ForeColor = System.Drawing.Color.White;
            this.carRadioBtn.Location = new System.Drawing.Point(5, 100);
            this.carRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carRadioBtn.Name = "carRadioBtn";
            this.carRadioBtn.Size = new System.Drawing.Size(50, 24);
            this.carRadioBtn.TabIndex = 3;
            this.carRadioBtn.TabStop = true;
            this.carRadioBtn.Text = "Car";
            this.carRadioBtn.UseVisualStyleBackColor = true;
            // 
            // teleportRadioBtn
            // 
            this.teleportRadioBtn.AutoSize = true;
            this.teleportRadioBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teleportRadioBtn.ForeColor = System.Drawing.Color.White;
            this.teleportRadioBtn.Location = new System.Drawing.Point(5, 77);
            this.teleportRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.teleportRadioBtn.Name = "teleportRadioBtn";
            this.teleportRadioBtn.Size = new System.Drawing.Size(85, 24);
            this.teleportRadioBtn.TabIndex = 2;
            this.teleportRadioBtn.TabStop = true;
            this.teleportRadioBtn.Text = "Teleport";
            this.teleportRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HelicopterRadioBtn
            // 
            this.HelicopterRadioBtn.AutoSize = true;
            this.HelicopterRadioBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelicopterRadioBtn.ForeColor = System.Drawing.Color.White;
            this.HelicopterRadioBtn.Location = new System.Drawing.Point(5, 55);
            this.HelicopterRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HelicopterRadioBtn.Name = "HelicopterRadioBtn";
            this.HelicopterRadioBtn.Size = new System.Drawing.Size(99, 24);
            this.HelicopterRadioBtn.TabIndex = 1;
            this.HelicopterRadioBtn.TabStop = true;
            this.HelicopterRadioBtn.Text = "Helicopter";
            this.HelicopterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // jetpackRadioBtn
            // 
            this.jetpackRadioBtn.AutoSize = true;
            this.jetpackRadioBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jetpackRadioBtn.ForeColor = System.Drawing.Color.White;
            this.jetpackRadioBtn.Location = new System.Drawing.Point(5, 32);
            this.jetpackRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.jetpackRadioBtn.Name = "jetpackRadioBtn";
            this.jetpackRadioBtn.Size = new System.Drawing.Size(80, 24);
            this.jetpackRadioBtn.TabIndex = 0;
            this.jetpackRadioBtn.TabStop = true;
            this.jetpackRadioBtn.Text = "Jetpack";
            this.jetpackRadioBtn.UseVisualStyleBackColor = true;
            // 
            // yearsExperienceLabel
            // 
            this.yearsExperienceLabel.AutoSize = true;
            this.yearsExperienceLabel.BackColor = System.Drawing.Color.Red;
            this.yearsExperienceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearsExperienceLabel.ForeColor = System.Drawing.Color.Black;
            this.yearsExperienceLabel.Location = new System.Drawing.Point(381, 245);
            this.yearsExperienceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearsExperienceLabel.Name = "yearsExperienceLabel";
            this.yearsExperienceLabel.Size = new System.Drawing.Size(114, 17);
            this.yearsExperienceLabel.TabIndex = 7;
            this.yearsExperienceLabel.Text = "Years Experience:";
            // 
            // yearsExperienceNumberSpinner
            // 
            this.yearsExperienceNumberSpinner.BackColor = System.Drawing.Color.Black;
            this.yearsExperienceNumberSpinner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearsExperienceNumberSpinner.ForeColor = System.Drawing.Color.White;
            this.yearsExperienceNumberSpinner.Location = new System.Drawing.Point(499, 245);
            this.yearsExperienceNumberSpinner.Margin = new System.Windows.Forms.Padding(2);
            this.yearsExperienceNumberSpinner.Name = "yearsExperienceNumberSpinner";
            this.yearsExperienceNumberSpinner.Size = new System.Drawing.Size(93, 23);
            this.yearsExperienceNumberSpinner.TabIndex = 8;
            // 
            // capeColorLabel
            // 
            this.capeColorLabel.AutoSize = true;
            this.capeColorLabel.BackColor = System.Drawing.Color.Red;
            this.capeColorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.capeColorLabel.ForeColor = System.Drawing.Color.Black;
            this.capeColorLabel.Location = new System.Drawing.Point(384, 277);
            this.capeColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.capeColorLabel.Name = "capeColorLabel";
            this.capeColorLabel.Size = new System.Drawing.Size(75, 17);
            this.capeColorLabel.TabIndex = 9;
            this.capeColorLabel.Text = "Cape Color";
            // 
            // capeColorBtn
            // 
            this.capeColorBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.capeColorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.capeColorBtn.FlatAppearance.BorderSize = 2;
            this.capeColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capeColorBtn.Location = new System.Drawing.Point(463, 272);
            this.capeColorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.capeColorBtn.Name = "capeColorBtn";
            this.capeColorBtn.Size = new System.Drawing.Size(128, 56);
            this.capeColorBtn.TabIndex = 10;
            this.capeColorBtn.UseVisualStyleBackColor = false;
            this.capeColorBtn.Click += new System.EventHandler(this.capeColorBtn_Click);
            // 
            // villainPotentialTrackBar
            // 
            this.villainPotentialTrackBar.BackColor = System.Drawing.Color.Black;
            this.villainPotentialTrackBar.Location = new System.Drawing.Point(391, 357);
            this.villainPotentialTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.villainPotentialTrackBar.Name = "villainPotentialTrackBar";
            this.villainPotentialTrackBar.Size = new System.Drawing.Size(200, 45);
            this.villainPotentialTrackBar.TabIndex = 11;
            this.villainPotentialTrackBar.Scroll += new System.EventHandler(this.villainPotentialTrackBar_Scroll);
            // 
            // villainPotentialLabel
            // 
            this.villainPotentialLabel.AutoSize = true;
            this.villainPotentialLabel.BackColor = System.Drawing.Color.Red;
            this.villainPotentialLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.villainPotentialLabel.ForeColor = System.Drawing.Color.Black;
            this.villainPotentialLabel.Location = new System.Drawing.Point(397, 338);
            this.villainPotentialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.villainPotentialLabel.Name = "villainPotentialLabel";
            this.villainPotentialLabel.Size = new System.Drawing.Size(192, 17);
            this.villainPotentialLabel.TabIndex = 12;
            this.villainPotentialLabel.Text = "Hero ------- Normal ------- Evil";
            // 
            // portraitLabel
            // 
            this.portraitLabel.AutoSize = true;
            this.portraitLabel.BackColor = System.Drawing.Color.Red;
            this.portraitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portraitLabel.ForeColor = System.Drawing.Color.Black;
            this.portraitLabel.Location = new System.Drawing.Point(394, 407);
            this.portraitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portraitLabel.Name = "portraitLabel";
            this.portraitLabel.Size = new System.Drawing.Size(93, 17);
            this.portraitLabel.TabIndex = 13;
            this.portraitLabel.Text = "Upload Photo";
            // 
            // portraitPictureBox
            // 
            this.portraitPictureBox.BackColor = System.Drawing.Color.Lime;
            this.portraitPictureBox.BackgroundImage = global::HeroMaker.Properties.Resources.StarLord;
            this.portraitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.portraitPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portraitPictureBox.Location = new System.Drawing.Point(397, 425);
            this.portraitPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.portraitPictureBox.Name = "portraitPictureBox";
            this.portraitPictureBox.Size = new System.Drawing.Size(187, 180);
            this.portraitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.portraitPictureBox.TabIndex = 14;
            this.portraitPictureBox.TabStop = false;
            this.portraitPictureBox.Click += new System.EventHandler(this.portraitPictureBox_Click);
            // 
            // createHeroBtn
            // 
            this.createHeroBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.createHeroBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createHeroBtn.FlatAppearance.BorderSize = 3;
            this.createHeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createHeroBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createHeroBtn.ForeColor = System.Drawing.Color.Black;
            this.createHeroBtn.Location = new System.Drawing.Point(394, 627);
            this.createHeroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createHeroBtn.Name = "createHeroBtn";
            this.createHeroBtn.Size = new System.Drawing.Size(190, 45);
            this.createHeroBtn.TabIndex = 15;
            this.createHeroBtn.Text = "Create Hero";
            this.createHeroBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createHeroBtn.UseVisualStyleBackColor = false;
            this.createHeroBtn.Click += new System.EventHandler(this.createHeroBtn_Click);
            // 
            // speedHScrollBar
            // 
            this.speedHScrollBar.Location = new System.Drawing.Point(19, 61);
            this.speedHScrollBar.Name = "speedHScrollBar";
            this.speedHScrollBar.Size = new System.Drawing.Size(313, 26);
            this.speedHScrollBar.TabIndex = 16;
            this.speedHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedHScrollBar_Scroll);
            // 
            // staminaHScrollBar
            // 
            this.staminaHScrollBar.Location = new System.Drawing.Point(22, 124);
            this.staminaHScrollBar.Name = "staminaHScrollBar";
            this.staminaHScrollBar.Size = new System.Drawing.Size(310, 26);
            this.staminaHScrollBar.TabIndex = 17;
            this.staminaHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.staminaHScrollBar_Scroll);
            // 
            // strengthHScrollBar
            // 
            this.strengthHScrollBar.Location = new System.Drawing.Point(22, 185);
            this.strengthHScrollBar.Name = "strengthHScrollBar";
            this.strengthHScrollBar.Size = new System.Drawing.Size(310, 26);
            this.strengthHScrollBar.TabIndex = 18;
            this.strengthHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.strengthHScrollBar_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speedLabel.Location = new System.Drawing.Point(19, 33);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(49, 17);
            this.speedLabel.TabIndex = 19;
            this.speedLabel.Text = "Speed:";
            // 
            // staminaLabel
            // 
            this.staminaLabel.AutoSize = true;
            this.staminaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staminaLabel.Location = new System.Drawing.Point(19, 96);
            this.staminaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staminaLabel.Name = "staminaLabel";
            this.staminaLabel.Size = new System.Drawing.Size(58, 17);
            this.staminaLabel.TabIndex = 20;
            this.staminaLabel.Text = "Stamina";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.strengthLabel.Location = new System.Drawing.Point(19, 159);
            this.strengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(61, 17);
            this.strengthLabel.TabIndex = 21;
            this.strengthLabel.Text = "Strength";
            // 
            // heroStatsGroupBox
            // 
            this.heroStatsGroupBox.BackColor = System.Drawing.Color.Black;
            this.heroStatsGroupBox.Controls.Add(this.strengthValueLabel);
            this.heroStatsGroupBox.Controls.Add(this.staminaValueLabel);
            this.heroStatsGroupBox.Controls.Add(this.speedValueLabel);
            this.heroStatsGroupBox.Controls.Add(this.strengthHScrollBar);
            this.heroStatsGroupBox.Controls.Add(this.strengthLabel);
            this.heroStatsGroupBox.Controls.Add(this.speedHScrollBar);
            this.heroStatsGroupBox.Controls.Add(this.staminaLabel);
            this.heroStatsGroupBox.Controls.Add(this.staminaHScrollBar);
            this.heroStatsGroupBox.Controls.Add(this.speedLabel);
            this.heroStatsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.heroStatsGroupBox.ForeColor = System.Drawing.Color.Red;
            this.heroStatsGroupBox.Location = new System.Drawing.Point(35, 408);
            this.heroStatsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.heroStatsGroupBox.Name = "heroStatsGroupBox";
            this.heroStatsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.heroStatsGroupBox.Size = new System.Drawing.Size(349, 264);
            this.heroStatsGroupBox.TabIndex = 22;
            this.heroStatsGroupBox.TabStop = false;
            this.heroStatsGroupBox.Text = "Hero Stats";
            // 
            // strengthValueLabel
            // 
            this.strengthValueLabel.AutoSize = true;
            this.strengthValueLabel.Location = new System.Drawing.Point(79, 159);
            this.strengthValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strengthValueLabel.Name = "strengthValueLabel";
            this.strengthValueLabel.Size = new System.Drawing.Size(0, 17);
            this.strengthValueLabel.TabIndex = 24;
            // 
            // staminaValueLabel
            // 
            this.staminaValueLabel.AutoSize = true;
            this.staminaValueLabel.Location = new System.Drawing.Point(76, 96);
            this.staminaValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staminaValueLabel.Name = "staminaValueLabel";
            this.staminaValueLabel.Size = new System.Drawing.Size(0, 17);
            this.staminaValueLabel.TabIndex = 23;
            // 
            // speedValueLabel
            // 
            this.speedValueLabel.AutoSize = true;
            this.speedValueLabel.Location = new System.Drawing.Point(69, 33);
            this.speedValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedValueLabel.Name = "speedValueLabel";
            this.speedValueLabel.Size = new System.Drawing.Size(0, 17);
            this.speedValueLabel.TabIndex = 22;
            // 
            // villainPotentialValueLabel
            // 
            this.villainPotentialValueLabel.AutoSize = true;
            this.villainPotentialValueLabel.Location = new System.Drawing.Point(525, 340);
            this.villainPotentialValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.villainPotentialValueLabel.Name = "villainPotentialValueLabel";
            this.villainPotentialValueLabel.Size = new System.Drawing.Size(0, 15);
            this.villainPotentialValueLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroMaker.Properties.Resources.superHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 695);
            this.Controls.Add(this.villainPotentialValueLabel);
            this.Controls.Add(this.heroStatsGroupBox);
            this.Controls.Add(this.createHeroBtn);
            this.Controls.Add(this.portraitPictureBox);
            this.Controls.Add(this.portraitLabel);
            this.Controls.Add(this.villainPotentialLabel);
            this.Controls.Add(this.villainPotentialTrackBar);
            this.Controls.Add(this.capeColorBtn);
            this.Controls.Add(this.capeColorLabel);
            this.Controls.Add(this.yearsExperienceNumberSpinner);
            this.Controls.Add(this.yearsExperienceLabel);
            this.Controls.Add(this.TransportationGroupBox);
            this.Controls.Add(this.importantDatesGroupBox);
            this.Controls.Add(this.OriginListBox);
            this.Controls.Add(this.officeLocationsLabel);
            this.Controls.Add(this.specialAbilitiesGroupBox);
            this.Controls.Add(this.herosNameTextBox);
            this.Controls.Add(this.HeroNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hero Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.specialAbilitiesGroupBox.ResumeLayout(false);
            this.specialAbilitiesGroupBox.PerformLayout();
            this.importantDatesGroupBox.ResumeLayout(false);
            this.importantDatesGroupBox.PerformLayout();
            this.TransportationGroupBox.ResumeLayout(false);
            this.TransportationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperienceNumberSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villainPotentialTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portraitPictureBox)).EndInit();
            this.heroStatsGroupBox.ResumeLayout(false);
            this.heroStatsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        } // end of method

        #endregion

        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.TextBox herosNameTextBox;
        private System.Windows.Forms.GroupBox specialAbilitiesGroupBox;
        private System.Windows.Forms.CheckBox telekinesisCheckBox;
        private System.Windows.Forms.CheckBox SuperSpeedCheckBox;
        private System.Windows.Forms.CheckBox underWaterControlCheckBox;
        private System.Windows.Forms.CheckBox MultiverseCheckBox;
        private System.Windows.Forms.CheckBox MindControlCheckBox;
        private System.Windows.Forms.CheckBox ElementalCheckBox;
        private System.Windows.Forms.CheckBox ShapeShifterCheckBox;
        private System.Windows.Forms.CheckBox healingCheckBox;
        private System.Windows.Forms.CheckBox invisibilityCheckBox;
        private System.Windows.Forms.CheckBox xRayVisionCheckBox;
        private System.Windows.Forms.CheckBox flightCheckBox;
        private System.Windows.Forms.CheckBox superStrengthCheckBox;
        private System.Windows.Forms.GroupBox importantDatesGroupBox;
        private System.Windows.Forms.DateTimePicker fatefulDayDatePicker;
        private System.Windows.Forms.DateTimePicker superPowerDiscoveryDatePicker;
        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Label powerMasteryDayLabel;
        private System.Windows.Forms.Label superPowerOriginLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label officeLocationsLabel;
        private System.Windows.Forms.ListBox OriginListBox;
        private System.Windows.Forms.GroupBox TransportationGroupBox;
        private System.Windows.Forms.RadioButton carRadioBtn;
        private System.Windows.Forms.RadioButton teleportRadioBtn;
        private System.Windows.Forms.RadioButton HelicopterRadioBtn;
        private System.Windows.Forms.RadioButton jetpackRadioBtn;
        private System.Windows.Forms.Label yearsExperienceLabel;
        private System.Windows.Forms.NumericUpDown yearsExperienceNumberSpinner;
        private System.Windows.Forms.Label capeColorLabel;
        private System.Windows.Forms.ColorDialog capeColorDialogBox;
        private System.Windows.Forms.Button capeColorBtn;
        private System.Windows.Forms.TrackBar villainPotentialTrackBar;
        private System.Windows.Forms.Label villainPotentialLabel;
        private System.Windows.Forms.Label portraitLabel;
        private System.Windows.Forms.PictureBox portraitPictureBox;
        private System.Windows.Forms.Button createHeroBtn;
        private System.Windows.Forms.HScrollBar speedHScrollBar;
        private System.Windows.Forms.HScrollBar staminaHScrollBar;
        private System.Windows.Forms.HScrollBar strengthHScrollBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.GroupBox heroStatsGroupBox;
        private System.Windows.Forms.Label strengthValueLabel;
        private System.Windows.Forms.Label staminaValueLabel;
        private System.Windows.Forms.Label speedValueLabel;
        private System.Windows.Forms.Label villainPotentialValueLabel;
    }
}
