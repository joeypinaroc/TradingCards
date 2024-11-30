using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        // Declare list of PlayerData
        List<PlayerData> playerData = new List<PlayerData>();

        // Dictionary for the color associated with the team
        Dictionary<string, Color> teamColorDictionary = new Dictionary<string, Color>
        {
            { "Lakers", Color.Gold },
            { "Cavaliers", Color.Maroon },
            { "Heat", Color.Red },
            { "Bucks", Color.Green },
            { "Kings", Color.Purple },
            { "Suns", Color.Orange },
            { "76ers", Color.Red },
            { "Pistons", Color.Blue }
        };

        // Dictionary for the image associated with the player
        Dictionary<string, Image> playerImageDictionary = new Dictionary<string, Image>
        {
            { "Kobe Bryant",  Image.FromFile("../../Resources/TradingCardsImg/KobeBryant.png")},
            { "LeBron James", Image.FromFile("../../Resources/TradingCardsImg/LebronJames.png") },
            { "Dwyane Wade", Image.FromFile("../../Resources/TradingCardsImg/DwyaneWade.png") },
            { "Giannis Antetokounmpo", Image.FromFile("../../Resources/TradingCardsImg/Giannis.png") },
            { "Bradley Beal", Image.FromFile("../../Resources/TradingCardsImg/BradleyBeal.png") },
            { "Jimmy Butler", Image.FromFile("../../Resources/TradingCardsImg/JimmyButler.png") },
            { "Harrison Barnes", Image.FromFile("../../Resources/TradingCardsImg/HarrisonBarnes.png") },
            { "Nicolas Batum", Image.FromFile("../../Resources/TradingCardsImg/NicolasBatum.png") },
            { "Patrick Beverley", Image.FromFile("../../Resources/TradingCardsImg/PatrickBeverley.png") },
            { "Alec Burks", Image.FromFile("../../Resources/TradingCardsImg/AlecBurks.png") }
        };

        // Form1()
        public Form1()
        {
            InitializeComponent();
            BuildDBFromFile(); // Read file and create player list
            foreach (var player in playerData)
            {
                playerList.Items.Add(player); // Update listbox display
            }
            // Get unique teams using LINQ and update options in team selector combobox
            var uniqueTeams = playerData.Select(p => p.Team).Distinct().ToList();
            cb_Team.Items.AddRange(uniqueTeams.ToArray());
            // Initialize values of player listbox and team selector combobox
            cb_Team.SelectedIndex = 0;
            playerList.SelectedIndex = 0;
        }

        // Method to generate player instance from csv file
        public void BuildDBFromFile()
        {
            string path = "../../Resources/TradingCards.csv"; // Path for csv file
            // Check if file exist
            if (!File.Exists(path))
            {
                // File does not exist. Show error popup.
                MessageBox.Show("CSV File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Read the csv file
            using (var reader = File.OpenText(path))
            {
                string input = reader.ReadLine();
                while ((input = reader.ReadLine()) != null)
                {
                    // Create instance of player for every row of file and add to list
                    PlayerData player = new PlayerData(input);
                    playerData.Add(player);
                }
            }
        }

        // Method when team selector combobox is changed
        private void cb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                // Get the selected team
                var selectedTeam = cb_Team.SelectedItem.ToString();
                // Filter players belonging to the selected team
                var filteredPlayers = playerData.Where(p => (p.Team == selectedTeam) || (selectedTeam == "All")).ToList();
                // Clear the ListBox and update list of players
                playerList.Items.Clear();
                foreach (var player in filteredPlayers)
                {
                    playerList.Items.Add(player); // Update players list
                }
                playerList.SelectedIndex = 0; // Reset selection to the first item
            }
        }

        // Method when player listbox selection is changed
        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is PlayerData player)
            {
                // Update name, team, and statistics display
                lbl_PlayerName.Text = player.Name;
                lbl_PlayerTeam.Text = player.Team;
                rtb_Card.Text = "   Points (PPG): " + player.PPG + "\n   Rebounds (RPG): " + player.RPG +
                                "\n   Assists (APG): " + player.APG + "\n   Field Goal (FG%): " + player.FGP + "\n   3-Points (3P%): " + player.TPG;
                // Update card color based on player's team
                if (teamColorDictionary.ContainsKey(player.Team))
                {
                    cardFrame.BackColor = teamColorDictionary[player.Team];
                    pb_PlayerImage.BackColor = teamColorDictionary[player.Team];
                    rtb_Card.BackColor = teamColorDictionary[player.Team];
                }
                // Update player image
                if (playerImageDictionary.ContainsKey(player.Name))
                {
                    pb_PlayerImage.Image = playerImageDictionary[player.Name];
                }
            }
        }
    }
    
}
