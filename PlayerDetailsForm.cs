using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_TradingCards
{
    public partial class PlayerDetailsForm : Form
    {
        public Player Player { get; private set; }
        public PlayerDetailsForm(Player existingPlayer = null)
        {
            InitializeComponent();
            if (existingPlayer != null)
            {
                // Populate text fields with existing player data
                txtName.Text = existingPlayer.Name;
                txtTeam.Text = existingPlayer.Team;
                txtRuns.Text = existingPlayer.Runs.ToString();
                txtWickets.Text = existingPlayer.Wickets.ToString();
                txtStrikeRate.Text = existingPlayer.StrikeRate.ToString();
                txtCatches.Text = existingPlayer.Catches.ToString();
                

                Player = existingPlayer;
            }
            else
            {
                Player = new Player();
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtTeam.Text))
            {
                MessageBox.Show("Name and Team fields are required.");
                return;
            }

            try
            {
                Player.Name = txtName.Text;
                Player.Team = txtTeam.Text;
                Player.Runs = int.Parse(txtRuns.Text);
                Player.Wickets = int.Parse(txtWickets.Text);
                Player.StrikeRate = double.Parse(txtStrikeRate.Text);
                Player.Catches = int.Parse(txtCatches.Text);

                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Runs, Wickets, Strike Rate, and Catches.");
            }
        }
    }
}
