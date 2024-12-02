using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace A3_TradingCards
{
    public partial class Form1 : Form
    {

        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            RefreshListBox();
        }

        private void LoadData()
        {
            // Load the cricket players data
            players = new List<Player>
            {
                new Player
                {
                    Name = "Virat Kohli",
                    Team = "Team A",
                    Photo = "Images/Virat.jpg",
                    Runs = 12000,
                    Wickets = 0,
                    StrikeRate = 93.5,
                    Catches = 120,
                },
                new Player
                {
                    Name = "Rohit Sharma",
                    Team = "Team A",
                    Photo = "Images/Rohit Sharma.jpg",
                    Runs = 11000,
                    Wickets = 2,
                    StrikeRate = 89.2,
                    Catches = 95,
                },


                 new Player
                 {
                     Name = "Jasprit Bumrah",
                     Team = "Team A",
                     Photo = "Images/Jasprit.jpg",
                     Runs = 150,
                     Wickets = 230,
                     StrikeRate = 85.0,
                     Catches = 45,
                 },
                 new Player
                 {
                     Name = "Shubman Gill",
                     Team = "Team A",
                     Photo = "Images/Shubman.jpg",
                     Runs = 2500,
                     Wickets = 0,
                     StrikeRate = 92.4,
                     Catches = 30,
                 },
                 new Player
                 {
                     Name = "Steve Smith",
                     Team = "Team B",
                     Photo = "Images/Steve.jpg",
                     Runs = 8500,
                     Wickets = 10,
                     StrikeRate = 88.5,
                     Catches = 100,
                 },
                 new Player
                 {
                     Name = "David Warner",
                     Team = "Team B",
                     Photo = "Images/David.jpg",
                     Runs = 10000,
                     Wickets = 1,
                     StrikeRate = 95.3,
                     Catches = 85,
                 },
                  new Player
                  {
                     Name = "Pat Cummins",
                     Team = "Team B",
                     Photo = "Images/Pat.jpg",
                     Runs = 650,
                     Wickets = 200,
                     StrikeRate = 80.4,
                     Catches = 60
                  },
                  new Player
                  {
                     Name = "Kane Williamson",
                     Team = "Team C",
                     Photo = "Images/Kane.jpg",
                     Runs = 9500,
                     Wickets = 5,
                     StrikeRate = 80.2,
                     Catches = 90
                  },
                   new Player
                   {
                      Name = "Trent Boult",
                      Team = "Team C",
                      Photo = "Images/Trent.jpg",
                      Runs = 450,
                      Wickets = 210,
                      StrikeRate = 78.6,
                      Catches = 40
                   },
                   new Player
                   {
                      Name = "Glen Philips",
                      Team = "Team C",
                      Photo = "Images/Glen.jpg",
                      Runs = 700,
                      Wickets = 275,
                      StrikeRate = 88.3,
                      Catches = 55
                   }
            };
        }

        private void RefreshListBox()
        {
            lstPlayers.DataSource = null;  // Disconnect the data source to force refresh
            lstPlayers.DataSource = players;
            lstPlayers.DisplayMember = "Name";
            lstPlayers.SelectedIndexChanged += lstPlayers_SelectedIndexChanged;
        }


        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is Player selectedPlayer)
            {
                lblName.Text = $"Name: {selectedPlayer.Name}";
                lblTeam.Text = $"Team: {selectedPlayer.Team}";
                lblRuns.Text = $"Runs: {selectedPlayer.Runs}";
                lblWickets.Text = $"Wickets: {selectedPlayer.Wickets}";
                lblStrikeRate.Text = $"Strike Rate: {selectedPlayer.StrikeRate}";
                lblCatches.Text = $"Catches: {selectedPlayer.Catches}";
                picPlayer.ImageLocation = selectedPlayer.Photo;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (PlayerDetailsForm addForm = new PlayerDetailsForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    players.Add(addForm.Player); // Add new player
                    RefreshListBox(); // Refresh list manually
                    MessageBox.Show("Player added successfully!");
                }

            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is Player selectedPlayer)
            {
                using (PlayerDetailsForm updateForm = new PlayerDetailsForm(selectedPlayer))
                {
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update occurs by reference, so we just need to refresh the list
                        RefreshListBox();
                        MessageBox.Show("Player updated successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a player to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedItem is Player selectedPlayer)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this player?", "Confirm Delete",MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    players.Remove(selectedPlayer);// remove player
                    RefreshListBox();  // Refresh list
                    MessageBox.Show("Player deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.");
            }

        }
    }
}

