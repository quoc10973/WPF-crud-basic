using EnglishPremierLeague2024.BLL.Services;
using EnglishPremierLeague2024.DAL.Repository;
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
    /// Interaction logic for ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window
    {
        public String? Role { get; set; } = null;

        private FootBallClubService footBallClubService = new FootBallClubService();
        private FootballPlayerService footballPlayerService = new FootballPlayerService();
        public ViewWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lblWelcome.Content = "Welcome " + (string.IsNullOrEmpty(Role) ? "Guest" : Role);
            refreshData();
        }

        public void refreshData()
        {
            dgvFoolballClub.ItemsSource = null;
            dgvFoolballClub.ItemsSource = footBallClubService.getAllFootballClub();
            dgvFootballPlayer.ItemsSource = footballPlayerService.getAllFootballPlayers();
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
    }
}
