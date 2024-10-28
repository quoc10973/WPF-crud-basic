using EnglishPremierLeague2024.BLL.Services;
using EnglishPremierLeague2024.DAL.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnglishPremierLeague2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PremierLeagueAccountService premierLeagueAccountService = new PremierLeagueAccountService();
        public MainWindow()
        {
            InitializeComponent();
        }

    

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult answer = MessageBox.Show("CLosing the application","Exit",MessageBoxButton.YesNo,MessageBoxImage.Exclamation);
            if(answer == MessageBoxResult.No)
            {
               return;
            }
            Application.Current.Shutdown();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Password;
           PremierLeagueAccount? premierLeagueAccount = await premierLeagueAccountService.CheckLoginAsyn(email, password);
            if(premierLeagueAccount == null)
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(premierLeagueAccount.Role == 1)
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                MenuWindow menu = new MenuWindow();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ViewWindow view = new ViewWindow();
                String role = "";
                if(premierLeagueAccount.Role == 2)
                {
                    role = "Staff";
                }
                else if(premierLeagueAccount.Role == 3)
                {
                    role = "Manager";
                }
                else
                {
                    role = "Member";
                }
                view.Role = role;
                view.Show();            
                this.Hide();
            }
        }

       
    }
}