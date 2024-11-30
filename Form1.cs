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
        List<PlayerData> playerData = new List<PlayerData>();
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
        Dictionary<string, Image> playerImageDictionary = new Dictionary<string, Image>
        {
            { "Kobe Bryant",  Image.FromFile("../../res/TradingCardsImg/KobeBryant.png")},
            { "LeBron James", Image.FromFile("../../res/TradingCardsImg/LebronJames.png") },
            { "Dwyane Wade", Image.FromFile("../../res/TradingCardsImg/DwyaneWade.png") },
            { "Giannis Antetokounmpo", Image.FromFile("../../res/TradingCardsImg/Giannis.png") },
            { "Bradley Beal", Image.FromFile("../../res/TradingCardsImg/BradleyBeal.png") },
            { "Jimmy Butler", Image.FromFile("../../res/TradingCardsImg/JimmyButler.png") },
            { "Harrison Barnes", Image.FromFile("../../res/TradingCardsImg/HarrisonBarnes.png") },
            { "Nicolas Batum", Image.FromFile("../../res/TradingCardsImg/NicolasBatum.png") },
            { "Patrick Beverley", Image.FromFile("../../res/TradingCardsImg/PatrickBeverley.png") },
            { "Alec Burks", Image.FromFile("../../res/TradingCardsImg/AlecBurks.png") }
        };


        public void BuildDBFromFile()
        {
            string path = "../../res/TradingCards.csv";
            if (!File.Exists(path))
            {
                MessageBox.Show("CSV File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var reader = File.OpenText(path))
            {
                string input = reader.ReadLine();
                while ((input = reader.ReadLine()) != null)
                {
                    PlayerData player = new PlayerData(input);
                    playerData.Add(player);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();


            BuildDBFromFile();
            foreach (var player in playerData)
            {
                playerList.Items.Add(player);
            }

            // Get unique teams using LINQ and bind them to the ComboBox
            var uniqueTeams = playerData.Select(p => p.Team).Distinct().ToList();
            cb_Team.Items.AddRange(uniqueTeams.ToArray());
            cb_Team.SelectedIndex = 0;
            playerList.SelectedIndex = 0;
        }

        private void cb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected team from ComboBox
            var selectedTeam = cb_Team.SelectedItem.ToString();

            // Filter players by the selected team using LINQ
            var filteredPlayers = playerData.Where(p => (p.Team == selectedTeam) || (selectedTeam == "All")).ToList();

            // Clear the ListBox and add filtered players
            playerList.Items.Clear();
            foreach (var player in filteredPlayers)
            {
                playerList.Items.Add(player);
            }

            // Optionally, set the first player as the selected player after filtering
            if (playerList.Items.Count > 0)
            {
                playerList.SelectedIndex = 0;
            }
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is PlayerData player)
            {
                lbl_PlayerName.Text = player.Name;
                lbl_PlayerTeam.Text = player.Team;
                rtb_Card.Text = "   Points (PPG): " + player.PPG + "\n   Rebounds (RPG): " + player.RPG +
                                "\n   Assists (APG): " + player.APG + "\n   Field Goal (FG%): " + player.FGP + "\n   3-Points (3P%): " + player.TPG;
                if (teamColorDictionary.ContainsKey(player.Team))
                {
                    cardFrame.BackColor = teamColorDictionary[player.Team];
                    pb_PlayerImage.BackColor = teamColorDictionary[player.Team];
                    rtb_Card.BackColor = teamColorDictionary[player.Team];
                }
                if (playerImageDictionary.ContainsKey(player.Name))
                {
                    pb_PlayerImage.Image = playerImageDictionary[player.Name];
                }
            }
        }
    }
    
}
