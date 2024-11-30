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
            { "Kobe Bryant",  Image.FromFile("TradingCardsImg\\KobeBryant.png")},
            { "LeBron James", Image.FromFile("TradingCardsImg\\LebronJames.png") },
            { "Dwyane Wade", Image.FromFile("TradingCardsImg\\DwyaneWade.png") },
            { "Giannis Antetokounmpo", Image.FromFile("TradingCardsImg\\Giannis.png") },
            { "Bradley Beal", Image.FromFile("TradingCardsImg\\BradleyBeal.png") },
            { "Jimmy Butler", Image.FromFile("TradingCardsImg\\JimmyButler.png") },
            { "Harrison Barnes", Image.FromFile("TradingCardsImg\\HarrisonBarnes.png") },
            { "Nicolas Batum", Image.FromFile("TradingCardsImg\\NicolasBatum.png") },
            { "Patrick Beverley", Image.FromFile("TradingCardsImg\\PatrickBeverley.png") },
            { "Alec Burks", Image.FromFile("TradingCardsImg\\AlecBurks.png") }
        };
        public void BuildDBFromFile()
        {
            string path = "TradingCards.csv";
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
        }

        private void CreateCard(PlayerData player, int yAxis)
        {   
            Button btn = new Button();
            btn.Name = player.Name;
            btn.Text = player.Name;
            btn.Tag = player;
            btn.Location = new Point(50, yAxis);
            btn.Height = 35;
            btn.Width = 100;

            btn.Click += Btn_Click;
            btn.Click += ShowImage;

            this.Controls.Add(btn);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is PlayerData player)
            {
                rtb_Card.Text = "Name: " + player.Name + "\nTeam: " + player.Team + "\nPPG: " + player.PPG + "\nRPG: " + player.RPG + 
                                "\nAPG: " + player.APG + "\nFG%: " + player.FGP + "\n3P%: " + player.TPG;
                if(teamColorDictionary.ContainsKey(player.Team))
                {
                    panel1.BackColor = teamColorDictionary[player.Team];
                }
            }
        }
        private void ShowImage(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is PlayerData player)
            {
                pb_PlayerImage.Image = playerImageDictionary[player.Name];
            }
        }

        
    }
    
}
