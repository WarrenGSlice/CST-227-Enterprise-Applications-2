using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * * * * * * * * * * *
 * Warren Peterson * * *
 * CST-227 6/25/2021 * *
 * * * Milestone 6 * * *
 * This is my own work *
 * Minesweeper Combo GUI
 * * * * * * * * * * * */

namespace MinesweeperGame6
{
    // Player Stats Class Implements IComparable
    class PlayerStats : IComparable<PlayerStats>
    {
        // Variables
        public string Initials { get; set; } // Variable to hold name
        public double Score { get; set; } // Variable to hold Score
        public double Time { get; set; } // Variable to hold Time
        public System.TimeSpan Timer { get; set; } // Variable to hold timer timespan
        public static List<PlayerStats> playerStats = new List<PlayerStats>(); // List to hold scores
        
        // Empty Constructor Method
        public PlayerStats()
        {
        }// End of Method

        // Constructor Method
        public PlayerStats(string _initials, double _score, double _time)
        {
            Initials = _initials;
            Score = _score;
            Time = _time;
        }// End of Method

        //Display Bound Data to show Score List on High Score Form
        public string Display
        {
            get
            {
                return string.Format("Player: {0} Score: {1} Time: {2}", Initials, Score, Time).ToUpper();
            }
        }// End of Method

        //Method that Reads the High Scores from a File
        // Uses a Relative Path so it can be accessed easily
        // Uses try catach for error checking
        public static List<PlayerStats> FiletoList()
        {
            //Check to see if we have a list started
            string fileName = "Resources\\PlayerStats.txt";
            string baseDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName).FullName;
            string filePath = Path.Combine(baseDirectory, @"", fileName);
            List<string> lines = File.ReadAllLines(filePath).ToList();
            try
            {
                foreach (string line in lines)
                {
                    string[] entry = line.Split(',');
                    PlayerStats plyr = new PlayerStats
                    {
                        Initials = entry[0],
                        Score = double.Parse(entry[1]),
                        Time = double.Parse(entry[2])
                    };
                    playerStats.Add(plyr);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Please check input file for proper formatting.");
                MessageBox.Show(e.Message);
            }
            if (playerStats.Count >= 7)
            {
                playerStats.RemoveAt(6);
            }
            playerStats = RunQuery().Distinct().ToList();
            return playerStats;
        }// End oF Method

        //Method that writes the new high score data to the file and displays on the screen
        // Uses Relative Path
        public static void ScoreOutput()
        {
            string baseDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName).FullName;
            string outPath = Path.Combine(baseDirectory, @"", "Resources//PlayerStats.txt");
            List<string> outputLines = new List<string>();
            playerStats = RunQuery().Distinct().ToList();
            try
            {
                if (playerStats.Count >= 5)
                {
                    playerStats.RemoveAt(5);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            for (int playercount = 0; playercount < playerStats.Count; playercount++)
            {
                outputLines.Add($"{playerStats[playercount].Initials}, {playerStats[playercount].Score}, {playerStats[playercount].Time}");
                outputLines.Distinct().ToList();
            }
            try
            {
                File.WriteAllLines(outPath, outputLines);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }// End of Method

        //Use LINQ to re-order the list by score in decending order
        static IEnumerable<PlayerStats> RunQuery()
        {
            var scoreQuery = from PlayerStats players in playerStats
                             orderby players.Score descending
                             select players;
            return scoreQuery;
        }// End of Method

        public int CompareTo(PlayerStats other)
        {
            return Time.CompareTo(Time);
        }// End of Method
    }
}