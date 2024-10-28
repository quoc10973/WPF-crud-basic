using EnglishPremierLeague2024.DAL.Entities;
using EnglishPremierLeague2024.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPremierLeague2024.BLL.Services
{
    public class FootballPlayerService
    {
        private FoolballPlayerRepository _footballPlayerRepository = new();

        public List<FootballPlayer> getAllFootballPlayers()
        {
            return _footballPlayerRepository.getAllFootballPlayers();
        }

        public void InsertFootballPlayer(FootballPlayer footballPlayer)
        {
            _footballPlayerRepository.AddFootballPlayer(footballPlayer);
        }

        public void UpdateFootballPlayer(FootballPlayer footballPlayer)
        {
            _footballPlayerRepository.UpdateFootballPlayer(footballPlayer);
        }

        public void DeleteFootballPlayer(FootballPlayer footballPlayer)
        {
            _footballPlayerRepository.DeleteFootballPlayer(footballPlayer);
        }
    }
}
