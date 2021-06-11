using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * *
 * Warren Peterson * *
 * 6/11/2021 CST-227
 * Acitivty 4 * * * *
 * Hero Maker dual form
 * This is my own work
 * * * * * * * * * * */

namespace HeroMaker
{
    // Properties of a SuperHero used for application in the SuperHero Class
    public class SuperHero
    {
        // Variables
        public string Name { get; set; } // used to store name
        public ArrayList Skills { get; set; } // used to store abilities
        public string TownOfOrigin { get; set; } // used to store home base town
        public string TravelBy { get; set; } // used to store travel method
        public DateTime[] ImportantDates { get; set; } // used to store important dates
        public decimal YearsExperience { get; set; } // used to store experience
        public string CapeColor { get; set; } // used to store cape color
        public int VillainPotential { get; set; } // used to store evil level
        public int[] StatsArray { get; set; } // used to stats such as stamina, streghth and speed
        public string PortraitFileName { get; set; } // used to store image of hero

        // Constructor method for passing properties of a super hero
        public SuperHero(string name, ArrayList skills, string townOfOrigin, string travelBy, DateTime[] importantDatas, decimal yearsExperience,
                string capeColor, int villainPotential, int[] statsArray, string portraitFileName)
        {
            Name = name;
            Skills = skills;
            TownOfOrigin = townOfOrigin;
            TravelBy = travelBy;
            ImportantDates = importantDatas;
            YearsExperience = yearsExperience;
            CapeColor = capeColor;
            VillainPotential = villainPotential;
            StatsArray = statsArray;
            PortraitFileName = portraitFileName;
        } // end of method

        // No args Constructor of the SuperHero Class
        public SuperHero()
        {
            Name = "";
            Skills = new ArrayList();
            TownOfOrigin = "";
            TravelBy = "";
            ImportantDates = new DateTime[3];
            YearsExperience = 0;
            CapeColor = "";
            VillainPotential = 0;
            StatsArray = new int[3];
            PortraitFileName = "";
        } // end of method
    } // end of class
}// end of namespace
