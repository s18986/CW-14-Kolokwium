using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_14_Kolokwium.Models
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public int MaxAge { get; set; }
        public ICollection<Championhip_Team> championhip_Teams { get; set; }
        public ICollection<Player_Team> player_Teams { get; set; }
    }
}
