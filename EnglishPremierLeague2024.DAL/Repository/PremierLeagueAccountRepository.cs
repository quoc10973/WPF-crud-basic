using EnglishPremierLeague2024.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPremierLeague2024.DAL.Repository
{
    public class PremierLeagueAccountRepository
    {
        private EnglishPremierLeague2024DbContext _context;

        public void AddPremierLeagueAccount(PremierLeagueAccount premierLeagueAccount)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.PremierLeagueAccounts.Add(premierLeagueAccount);
            _context.SaveChanges();
        }

        public List<PremierLeagueAccount> GetAllPremierLeagueAccounts()
        {
            _context = new EnglishPremierLeague2024DbContext();
            return _context.PremierLeagueAccounts.ToList();
        }

        public async Task<PremierLeagueAccount?>  CheckLoginAsyn(String email, String password)
        {
            _context = new EnglishPremierLeague2024DbContext();
            return await _context.PremierLeagueAccounts.FirstOrDefaultAsync(x => x.EmailAddress == email && x.Password == password);
        }

        public List<int?> GetAllRole()
        {
            _context = new EnglishPremierLeague2024DbContext();
            return _context.PremierLeagueAccounts.Select(x => x.Role).Distinct().ToList();
        }

        public void UpdatePremierLeagueAccount(PremierLeagueAccount premierLeagueAccount)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.PremierLeagueAccounts.Update(premierLeagueAccount);
            _context.SaveChanges();
        }
        public void DeletePremierLeagueAccount(PremierLeagueAccount premierLeagueAccount)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.PremierLeagueAccounts.Remove(premierLeagueAccount);
            _context.SaveChanges();
        }
    }
}
