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
        public void BuildDBFromFile()
        {
            string path = "C:\\Users\\joeyp\\OneDrive\\Documents\\school\\BVC\\FALL 2024\\SODV 2101 Rapid\\TradingCards\\bin\\Debug\\TradingCards.csv";
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
                //MessageBox.Show("Loaded " + playerData.Count + " rows.");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

            this.Controls.Add(btn);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is PlayerData player)
            {
                rtb_Card.Text = "Name: " + player.Name + "\nTeam: " + player.Team;
            }
        }

    }
    
}
