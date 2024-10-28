using EnglishPremierLeague2024.BLL.Services;
using EnglishPremierLeague2024.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EnglishPremierLeague2024
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        private FootballPlayerService footballPlayerService = new();
        public PlayerWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           refreshData();
        }

        private void refreshData()
        {
            dgvFootballPlayer.ItemsSource = null;
            dgvFootballPlayer.ItemsSource = footballPlayerService.getAllFootballPlayers();
            cboClubName.ItemsSource = new FootBallClubService().getAllFootballClub();
            cboClubName.DisplayMemberPath = "ClubName";
            cboClubName.SelectedValuePath = "FootballClubId";
            cboClubName.SelectedIndex = 0;
            dpkBirthday.SelectedDate = DateTime.Now;
            txtAchievements.Text = "";
            txtExperiences.Text = "";
            txtId.Text = "";
            txtFullName.Text = "";
            txtNomination.Text = "";
            cboClubName.SelectedIndex = 0;
        }

        private void dgvFootballPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FootballPlayer? footballPlayer = dgvFootballPlayer.SelectedItem as FootballPlayer;
            if (footballPlayer != null)
            {
                txtId.Text = footballPlayer.FootballPlayerId;
                txtFullName.Text = footballPlayer.FullName;
                txtAchievements.Text = footballPlayer.Achievements;
                dpkBirthday.SelectedDate = footballPlayer.Birthday;
                txtExperiences.Text = footballPlayer.PlayerExperiences;
                txtNomination.Text = footballPlayer.Nomination;
                cboClubName.SelectedValue = footballPlayer.FootballClubId;
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            List<FootballPlayer> players = footballPlayerService.getAllFootballPlayers();
            FootballPlayer player = new FootballPlayer();
            foreach (var i in players)
            {
                if (i.FootballPlayerId == txtId.Text)
                {
                    MessageBox.Show("Id already exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (txtFullName.Text == "" || dpkBirthday == null || txtId.Text == "" || txtAchievements.Text == "" || txtExperiences.Text == "" || txtNomination.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            player.FullName = txtFullName.Text;
            player.FootballPlayerId = txtId.Text;
            player.Achievements = txtAchievements.Text;
            player.Birthday = dpkBirthday.SelectedDate.Value;
            player.FootballClubId = cboClubName.SelectedValue.ToString();
            player.PlayerExperiences = txtExperiences.Text;
            player.Nomination = txtNomination.Text;
            footballPlayerService.InsertFootballPlayer(player);
            MessageBox.Show("Insert successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            refreshData();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            refreshData();
            
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            FootballPlayer player = dgvFootballPlayer.SelectedItem as FootballPlayer;
            if (player == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MessageBoxResult ans = MessageBox.Show("Do you want to delete this Football Club " + player.FootballPlayerId, "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ans == MessageBoxResult.No)
                    return;
                footballPlayerService.DeleteFootballPlayer(player);
                MessageBox.Show("Delete successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                refreshData();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            FootballPlayer player = dgvFootballPlayer.SelectedItem as FootballPlayer;
            if (player == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                try
                {
                    FootballPlayer newFootballPlayer = new FootballPlayer();
                    newFootballPlayer.FootballPlayerId = txtId.Text;
                    newFootballPlayer.Achievements = txtAchievements.Text;
                    newFootballPlayer.Birthday = dpkBirthday.SelectedDate.Value;
                    newFootballPlayer.FullName = txtFullName.Text;
                    newFootballPlayer.Nomination = txtNomination.Text;
                    newFootballPlayer.PlayerExperiences = txtExperiences.Text;
                    newFootballPlayer.FootballClubId = cboClubName.SelectedValue.ToString();

                    footballPlayerService.UpdateFootballPlayer(newFootballPlayer);
                    MessageBox.Show("Update successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                    refreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The ID " + txtId.Text + " is not exist!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnManageAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow accountWindow = new AccountWindow();
            this.Close();
            accountWindow.Show();
        }

        private void btnShutdown_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("CLosing the application", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (answer == MessageBoxResult.No)
            {
                return;
            }
            Application.Current.Shutdown();
        }

        private void btnManagePlayer_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
