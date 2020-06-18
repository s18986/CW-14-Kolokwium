using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_14_Kolokwium.Models
{
    public class Championhip_Team
    {
        public int idTeam { get; set; }
        public int idChampionship { get; set; }
        public float score { get; set; }
        public Championship championship { get; set; }
        public Team team { get; set; }
    }
}
