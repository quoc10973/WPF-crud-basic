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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private FootBallClubService footBallClubService = new FootBallClubService();
        public MenuWindow()
        {
            InitializeComponent();
        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            refreshData();
        }

        private void dgvFoolballClub_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FootballClub? footballClub = dgvFoolballClub.SelectedItem as FootballClub;
            if (footballClub != null)
            {
                txtClubName.Text = footballClub.ClubName;
                txtId.Text = footballClub.FootballClubId;
                txtField.Text = footballClub.SoccerPracticeField;
                txtDescription.Text = footballClub.ClubShortDescription;
                txtMascos.Text = footballClub.Mascos;

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            
            refreshData();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            List<FootballClub> footballClubs = footBallClubService.getAllFootballClub();
            FootballClub footballClub = new FootballClub();
            foreach (var i in footballClubs)
            {
                if (i.FootballClubId == txtId.Text)
                {
                    MessageBox.Show("Id already exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (txtClubName.Text == "" || txtId.Text == "" || txtField.Text == "" || txtDescription.Text == "" || txtMascos.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            footballClub.ClubName = txtClubName.Text;
            footballClub.FootballClubId = txtId.Text;
            footballClub.SoccerPracticeField = txtField.Text;
            footballClub.ClubShortDescription = txtDescription.Text;
            footballClub.Mascos = txtMascos.Text;
            footBallClubService.InsertFootballClub(footballClub);
            MessageBox.Show("Insert successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
            refreshData();
        }

        public void refreshData()
        {
            dgvFoolballClub.ItemsSource = null;
            dgvFoolballClub.ItemsSource = footBallClubService.getAllFootballClub();
            txtId.Text = "";
            txtClubName.Text = "";
            txtField.Text = "";
            txtDescription.Text = "";
            txtMascos.Text = "";
            

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            FootballClub footballClub = dgvFoolballClub.SelectedItem as FootballClub;
            if (footballClub == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MessageBoxResult ans = MessageBox.Show("Do you want to delete this Football Club " + footballClub.FootballClubId, "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ans == MessageBoxResult.No)
                    return;
                footBallClubService.DeleteFootBallClub(footballClub);
                MessageBox.Show("Delete successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                refreshData();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            FootballClub footballClub = dgvFoolballClub.SelectedItem as FootballClub;
            if (footballClub == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                try
                {
                    FootballClub newFootBallClub = new FootballClub();
                    newFootBallClub.ClubName = txtClubName.Text;
                    newFootBallClub.Mascos = txtMascos.Text;
                    newFootBallClub.ClubShortDescription = txtDescription.Text;
                    newFootBallClub.SoccerPracticeField = txtField.Text;
                    newFootBallClub.FootballClubId = txtId.Text;

                    footBallClubService.UpdateFootBallClub(newFootBallClub);
                    MessageBox.Show("Update successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                    refreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The ID " + txtId.Text + " is not exist!","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
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

        private void btnManageAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow accountWindow = new AccountWindow();
            this.Close();
            accountWindow.Show();
        }

        private void btnManagePlayer_Click(object sender, RoutedEventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow();
            playerWindow.Show();
            this.Close();
        }
    }
    }
