using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/23/2021 * * * * *
 * CST-227 * * * * * *
 * File IO with GUI  *
 * This is my own work
 * * * * * * * * * * */

namespace TextFileDataAccessDemoGUIApp
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        BindingSource personListBinding = new BindingSource();
        string fileName = "text.txt";
        // Uses Relative Path so that application works outside of my system
        string baseDirectory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName;

        // Form constructor starts Gui, Sets Bindings
        public Form1()
        {
            InitializeComponent();
            setBindings();
        } // End of Method

        // Set Binding Method links form to the Data Source
        private void setBindings()
        {
            personListBinding.DataSource = people;
            personsListBox.DataSource = personListBinding;
            personsListBox.DisplayMember = "Display";
        } // End of Method

        // Add to List Button
        private void addToListBtn_Click(object sender, EventArgs e)
        {
            // Try Catch Handles case where file cannot read correctly
            try
            {
                if (!firstNameTextBox.Text.Equals("") && !lastNameTextBox.Text.Equals("") && !urlTextBox.Text.Equals(""))
                {
                    Person person = new Person();
                    person.firstName = firstNameTextBox.Text;
                    person.lastName = lastNameTextBox.Text;
                    person.url = urlTextBox.Text;
                    people.Add(person);
                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    urlTextBox.Clear();
                    personListBinding.ResetBindings(false);
                }
                else
                {
                    throw new Exception("Entries can not be blank, please ensure all fields are filled in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // End of Method

        // Save To File Button
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            List<string> outputLines = new List<string>();
            // Uses Relative Path so it works outside of system
            string outPath = Path.Combine(baseDirectory, @"", fileName);
            // For loop gets data to be displayed correctly in GUI
            foreach (Person person in people)
            {
                outputLines.Add(person.firstName + "," + person.lastName + "," + person.url);
            }
            File.WriteAllLines(outPath, outputLines);
        } // End of Method

        // Load From File Button
        private void loadFromFileBtn_Click(object sender, EventArgs e)
        {
            // Try Catch handles case where cannot read file
            try
            {
                string inPath = Path.Combine(baseDirectory, @"", fileName);
                if (inPath == null)
                {
                    throw new Exception();
                }
                List<string> lines = File.ReadAllLines(inPath).ToList();

                // Foreach adds names to Person List from GUI
                foreach (string line in lines)
                {
                    string[] entries = line.Split(',');
                    Person person = new Person();
                    person.firstName = entries[0];
                    person.lastName = entries[1];
                    person.url = entries[2];

                    people.Add(person);

                    personListBinding.ResetBindings(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // End of Method

        // Not used
        private void button2_Click(object sender, EventArgs e)
        {
            // Does Nothing
        } // End of Method
    }
}
