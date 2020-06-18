using CW_14_Kolokwium.DTO.Request;
using CW_14_Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_14_Kolokwium.Services
{
    public class ChampionshipDbService : IOChampionshipDbService
    {
        private readonly KolosDbContext _context;

        public ChampionshipDbService(KolosDbContext context)
        {
            _context = context;
        }
        public void addPlayer()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> GetTeams(GetTeamsRequest request)
        {

            IEnumerable<Team> teams = _context.Teams.ToList();

            return teams;
        }
    }


}
