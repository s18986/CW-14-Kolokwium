using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_14_Kolokwium.Models
{
    public class Championship
    {
        public int IdChampionShip { get; set; }
        public string OfficialName { get; set; }
        public int Year { get; set; }
        public ICollection<Championhip_Team> championhip_Teams { get; set; }
    }
}
