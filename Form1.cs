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
        private int yAxis;
        List<PlayerData> playerData = new List<PlayerData>();
        Dictionary<string, Color> teamColorDictionary = new Dictionary<string, Color>
        {
            { "Lakers", Color.Gold },
            { "Cavaliers", Color.Maroon },
            { "Heat", Color.Black },
            { "Bucks", Color.Green },
            { "Kings", Color.Purple },
            { "Suns", Color.Orange },
            { "76ers", Color.Red }
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
            yAxis = 80; //btn starting location yAxis
            foreach (var player in playerData)
            {
                CreateCard(player, yAxis);
                yAxis += 35 + 5;
            }
            playerList.SelectedIndex = 0;
        }

        private void CreateCard(PlayerData player, int yAxis)
        {   
            playerList.Items.Add(player);
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is PlayerData player)
            {
                lbl_PlayerName.Text = player.Name;
                lbl_PlayerTeam.Text = player.Team;
                rtb_Card.Text = "Points (PPG): " + player.PPG + "\nRebounds (RPG): " + player.RPG +
                                "\nAssists (APG): " + player.APG + "\nField Goal (FG%): " + player.FGP + "\n3-Points (3P%): " + player.TPG;
                if (teamColorDictionary.ContainsKey(player.Team))
                {
                    panel1.BackColor = teamColorDictionary[player.Team];
                }
                if (playerImageDictionary.ContainsKey(player.Name))
                {
                    pb_PlayerImage.Image = playerImageDictionary[player.Name];
                }
            }
        }

        private void pb_PlayerImage_Click(object sender, EventArgs e)
        {

        }
    }
    
}
