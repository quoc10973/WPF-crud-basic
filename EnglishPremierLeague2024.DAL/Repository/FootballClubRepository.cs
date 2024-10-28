using EnglishPremierLeague2024.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPremierLeague2024.DAL.Repository
{
    public class FootballClubRepository
    {
        private EnglishPremierLeague2024DbContext _context;

        public void Add(FootballClub footballClub)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.FootballClubs.Add(footballClub);
            _context.SaveChanges();
        }

        public void Update(FootballClub footballClub)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.FootballClubs.Update(footballClub);
            _context.SaveChanges();
        }

        public void Delete(FootballClub footballClub)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.FootballClubs.Remove(footballClub);
            _context.SaveChanges();
        }

        public List<FootballClub> GetAll()
        {
            _context = new EnglishPremierLeague2024DbContext();
            return _context.FootballClubs.ToList();
        }


    }
}
