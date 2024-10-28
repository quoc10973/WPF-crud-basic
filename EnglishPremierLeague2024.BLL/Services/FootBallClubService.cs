using EnglishPremierLeague2024.DAL.Entities;
using EnglishPremierLeague2024.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPremierLeague2024.BLL.Services
{
    public class FootBallClubService
    {
        private FootballClubRepository footballClubRepository = new();

        public List<FootballClub> getAllFootballClub()
        {
            return footballClubRepository.GetAll();
        }
        
        public void InsertFootballClub(FootballClub footballClub)
        {
            footballClubRepository.Add(footballClub);
        }
        public void DeleteFootBallClub(FootballClub footballClub)
        {
            footballClubRepository.Delete(footballClub);
        }

        public void UpdateFootBallClub(FootballClub footballClub)
        {
            footballClubRepository.Update(footballClub);
        }
    }
}
