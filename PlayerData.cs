using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCards
{
    internal class PlayerData
    {
        // Declare properties for player
        public string Name;
        public string Team;
        public double PPG;
        public double RPG;
        public double APG;
        public double FGP;
        public double TPG;

        // Constructor for PlayerData class
        public PlayerData(string csv)
        {
            int index = 0; // Reset index
            // Initialize player properties
            Name = NextValue(csv, ref index); ;
            Team = NextValue(csv, ref index); ;
            double.TryParse(NextValue(csv, ref index), out PPG);
            double.TryParse(NextValue(csv, ref index), out RPG);
            double.TryParse(NextValue(csv, ref index), out APG);
            double.TryParse(NextValue(csv, ref index), out FGP);
            double.TryParse(NextValue(csv, ref index), out TPG);
        }
        
        // Method to parse the csv file
        private string NextValue(string csv, ref int index)
        {
            string result = "";
            if(index < csv.Length)
            {
                if (csv[index] == ',') //skip index if char is comma
                {
                    index++;
                }
                else
                {
                    int endIndex = csv.IndexOf(",", index);
                    if (endIndex == -1) result = csv.Substring(index); //prevent out-of-range
                    else result = csv.Substring(index, endIndex - index);
                    index = endIndex + 1; // move index to next entry
                }
            }
            return result;
        }
        
        // Override ToString Method to display player name
        public override string ToString()
        {
            return Name;
        }
    }
}
