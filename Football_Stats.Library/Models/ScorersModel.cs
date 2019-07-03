using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Stats.Library.Models
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public object lastName { get; set; }
        public string dateOfBirth { get; set; }
        public string countryOfBirth { get; set; }
        public string nationality { get; set; }
        public string position { get; set; }
        public int? shirtNumber { get; set; }
        public DateTime lastUpdated { get; set; }
    }


    public class Scorer
    {
        public Player player { get; set; }
        public Team team { get; set; }
        public int numberOfGoals { get; set; }
    }

    public class Scorers
    {
        public int count { get; set; }
        public Filters filters { get; set; }
        public Competition competition { get; set; }
        public Season season { get; set; }
        public List<Scorer> scorers { get; set; }
    }
}
