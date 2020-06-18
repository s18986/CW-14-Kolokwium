using CW_14_Kolokwium.DTO.Request;
using CW_14_Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_14_Kolokwium.Services
{
    interface IOChampionshipDbService
    {
        public IEnumerable<Team> GetTeams( GetTeamsRequest request);
        public void addPlayer();
    }
}
