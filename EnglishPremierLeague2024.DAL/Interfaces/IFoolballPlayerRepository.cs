using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishPremierLeague2024.DAL.Entities;
namespace EnglishPremierLeague2024.DAL.Interfaces
{
    public interface IFoolballPlayerRepository
    {
        void AddFootballPlayer(FootballPlayer footballPlayer);
        void UpdateFootballPlayer(FootballPlayer footballPlayer);
        void DeleteFootballPlayer(FootballPlayer footballPlayer);
        List<FootballPlayer> getAllFootballPlayers();
    }
}
