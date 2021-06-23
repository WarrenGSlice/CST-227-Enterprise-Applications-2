using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/23/2021 * * * * *
 * CST-227 * * * * * *
 * File IO in C# * * *
 * This is my own work
 * * * * * * * * * * */

namespace TextFileDataAccessDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Uses Relative paths so that application works outside of my computer
            string fileName = "text.txt";
            string baseDirectory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName;
            string filePath = Path.Combine(baseDirectory, @"", fileName);

            
            string outputPath = Path.Combine(baseDirectory, @"", "outputPeople.txt");

            List<Person> people = new List<Person>();
            string[] lines = { }; // Empty string array allows for names to be added in for loop

            // Handle case where file cannot read correctly
            try
            {
                lines = File.ReadAllLines(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be read successfully. Illegal file path: {0}", filePath);
                Console.WriteLine(e.Message);
            }
            // For loop reads through file one line at a time and adds to the array throught the person class
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] entries = line.Split(',');
                if (entries.Length != 3)
                {
                    // Print message and continue to next line
                    Console.WriteLine("File row {0} does not contain 3 columns: {1}", i, line);
                    continue;
                }
                people.Add(new Person(entries[0], entries[1], entries[2]));
            }

            List<String> outputLines = new List<string>();
            Console.WriteLine("Here is the list of people I have: ");
            // Foreach grabs each line from the array and adds prefix information to the console
            foreach (Person p in people)
            {
                Console.WriteLine("First Name: " + p.firstName + " Last Name: " + p.lastName + " URL: " + p.Url);

                outputLines.Add("First Name: " + p.firstName + " Last Name: " + p.lastName + " URL: " + p.Url + "\n");
            }

            // Write names to output file
            File.WriteAllLines(outputPath, outputLines);

            Console.ReadLine();
        }
    }
}