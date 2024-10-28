using EnglishPremierLeague2024.DAL.Entities;
using EnglishPremierLeague2024.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPremierLeague2024.BLL.Services
{
    public class PremierLeagueAccountService
    {
        private PremierLeagueAccountRepository PremierLeagueAccountRepository = new PremierLeagueAccountRepository();

        public PremierLeagueAccount? CheckLogin(String email, String password)
        {
            return PremierLeagueAccountRepository.GetAllPremierLeagueAccounts().FirstOrDefault(x => x.EmailAddress == email && x.Password == password);            
        }

        public Task<PremierLeagueAccount?> CheckLoginAsyn(String email, String password)
        {
           return PremierLeagueAccountRepository.CheckLoginAsyn(email, password);
        }

        public void AddPremierLeagueAccount(PremierLeagueAccount premierLeagueAccount)
        {
            PremierLeagueAccountRepository.AddPremierLeagueAccount(premierLeagueAccount);
        }

        public List<PremierLeagueAccount> GetAllPremierLeagueAccounts()
        {
            return PremierLeagueAccountRepository.GetAllPremierLeagueAccounts();
        }

        public List<int?> GetAllRole()
        {
            return PremierLeagueAccountRepository.GetAllRole();
        }

        public void UpdatePremierLeagueAccount(PremierLeagueAccount premierLeagueAccount)
        {
            PremierLeagueAccountRepository.UpdatePremierLeagueAccount(premierLeagueAccount);
        }

        public void DeletePremierLeagueAccount(PremierLeagueAccount premierLeagueAccount)
        {
            PremierLeagueAccountRepository.DeletePremierLeagueAccount(premierLeagueAccount);
        }
    }
}
