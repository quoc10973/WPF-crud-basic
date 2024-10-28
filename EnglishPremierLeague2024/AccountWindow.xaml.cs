using EnglishPremierLeague2024.BLL.Services;
using EnglishPremierLeague2024.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        private PremierLeagueAccountService premierLeagueAccountService = new PremierLeagueAccountService();
        public AccountWindow()
        {
            InitializeComponent();
        }

        private void dgvAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PremierLeagueAccount? account = dgvAccount.SelectedItem as PremierLeagueAccount;
            if (account != null)
            {
                txtId.Text = account.AccId.ToString();
                txtEmail.Text = account.EmailAddress;
                cboDescription.Text = account.Description;
                cboRole.SelectedItem = account.Role;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            refreshData();
            cboRole.ItemsSource = premierLeagueAccountService.GetAllRole();
            cboRole.SelectedIndex = 0;
            cboDescription.ItemsSource = new List<string> { "System Admin", "Staff", "Manager", "Member" };
            cboDescription.SelectedIndex = 0;
        }

        private void refreshData()
        {
            dgvAccount.ItemsSource = null;
            dgvAccount.ItemsSource = premierLeagueAccountService.GetAllPremierLeagueAccounts();
            txtEmail.Text = "";
            cboRole.SelectedIndex = 0;
            cboDescription.SelectedIndex = 0;
            txtId.Text = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            refreshData();

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            List<PremierLeagueAccount> accounts = premierLeagueAccountService.GetAllPremierLeagueAccounts();
            PremierLeagueAccount account = new PremierLeagueAccount();
            foreach (var i in accounts)
            {
                if (i.AccId.ToString().Equals(txtId.Text))
                {
                    MessageBox.Show("Id already exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (i.EmailAddress.Equals(txtEmail.Text))
                {
                    MessageBox.Show("Email already exists", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (txtEmail.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                account.AccId = int.Parse(txtId.Text);
                account.EmailAddress = txtEmail.Text;
                account.Password = "@1";
                int role = (int)cboRole.SelectedItem;
                account.Description = (String)cboDescription.SelectedItem;
                account.Role = role;
                premierLeagueAccountService.AddPremierLeagueAccount(account);
                refreshData();
                MessageBox.Show("Insert successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ID must be nummber", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cboRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int role = (int)cboRole.SelectedItem;
            if (role == 1)
            {
                cboDescription.SelectedIndex = 0;
            }
            if (role == 2)
            {
                cboDescription.SelectedIndex = 1;
            }
            if (role == 3)
            {
                cboDescription.SelectedIndex = 2;
            }
            if (role == 4)
            {
                cboDescription.SelectedIndex = 3;
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PremierLeagueAccount account = dgvAccount.SelectedItem as PremierLeagueAccount;
            if (account == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                MessageBoxResult ans = MessageBox.Show("Do you want to delete this account " + account.AccId, "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ans == MessageBoxResult.No)
                    return;
                premierLeagueAccountService.DeletePremierLeagueAccount(account);
                MessageBox.Show("Delete successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                refreshData();
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

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            PremierLeagueAccount account = dgvAccount.SelectedItem as PremierLeagueAccount;
            if (account == null)
            {
                MessageBox.Show("Please select a row", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            String Id = txtId.Text;
            if(txtEmail.Text == "" || txtId.Text =="")
            {

                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(!Regex.IsMatch(Id,"\\d+"))
            {
                MessageBox.Show("Id must be number", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                try
                {
           
                    PremierLeagueAccount newAccount = new PremierLeagueAccount();
                    newAccount.AccId = int.Parse(txtId.Text);
                    newAccount.EmailAddress = txtEmail.Text;
                    newAccount.Description = cboDescription.SelectedItem.ToString();
                    newAccount.Role = (int)cboRole.SelectedItem;
                    newAccount.Password = "@1";
                    premierLeagueAccountService.UpdatePremierLeagueAccount(newAccount);
                    MessageBox.Show("Update successful", "Done", MessageBoxButton.OK, MessageBoxImage.Information);
                    refreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The ID " + txtId.Text + " is not exist or Duplicated email in DB", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnManageAccount_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            this.Close();
            menuWindow.Show();
        }

        private void btnManagePlayer_Click(object sender, RoutedEventArgs e)
        {
            PlayerWindow playerWindow = new PlayerWindow();
            playerWindow.Show();
            this.Close();
        }
    }
}

