using EnglishPremierLeague2024.DAL.Entities;
using EnglishPremierLeague2024.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPremierLeague2024.DAL.Repository
{
    public class FoolballPlayerRepository : IFoolballPlayerRepository
    {
        EnglishPremierLeague2024DbContext _context;

        public void AddFootballPlayer(FootballPlayer footballPlayer)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.FootballPlayers.Add(footballPlayer);
            _context.SaveChanges();
        }

        public void UpdateFootballPlayer(FootballPlayer footballPlayer)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.FootballPlayers.Update(footballPlayer);
            _context.SaveChanges();
        }

        public void DeleteFootballPlayer(FootballPlayer footballPlayer)
        {
            _context = new EnglishPremierLeague2024DbContext();
            _context.FootballPlayers.Remove(footballPlayer);
            _context.SaveChanges();
        }

        public List<FootballPlayer> getAllFootballPlayers()
        {
            
            _context = new EnglishPremierLeague2024DbContext();
            return _context.FootballPlayers.ToList();
            
        }

    }
}
