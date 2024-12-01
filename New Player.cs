using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace TradingCards
{
    public partial class Add_Player : Form
    {
        // Declare properties for player
        public string PlayerName { get; private set; }
        public string Team { get; private set; }
        public double PPG { get; private set; }
        public double RPG { get; private set; }
        public double APG { get; private set; }
        public double FGP { get; private set; }
        public double TPG { get; private set; }

        public Add_Player()
        {
            InitializeComponent();
        }

        // Method when Add Player button is clicked
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Check if name and team are empty
            if (string.IsNullOrWhiteSpace(txtbox_Name.Text) || string.IsNullOrWhiteSpace(txtBox_Team.Text))
            {
                // Show error message popup
                MessageBox.Show("Player Name and Team cannot be empty.", "Empty Name/Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Update player details
                PlayerName = txtbox_Name.Text;
                Team = txtBox_Team.Text;
                PPG = Convert.ToDouble(num_PPG.Value);
                RPG = Convert.ToDouble(num_RPG.Value);
                APG = Convert.ToDouble(num_APG.Value);
                FGP = Convert.ToDouble(num_FG.Value);
                TPG = Convert.ToDouble(num_3P.Value);

                // Close popup and set DialogResult.OK;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        // Method when Cancel Button is clicked
        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            // Close popup and set DialogResult.Cancel;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
