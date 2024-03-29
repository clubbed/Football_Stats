﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Stats.Library.Models
{
    public class Area2
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ActiveCompetition
    {
        public int id { get; set; }
        public Area2 area { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string plan { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class Squad
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string countryOfBirth { get; set; }
        public string nationality { get; set; }
        public int? shirtNumber { get; set; }
        public string role { get; set; }
    }

    public class TeamModel
    {
        public int id { get; set; }
        public Area area { get; set; }
        public List<ActiveCompetition> activeCompetitions { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string crestUrl { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public int founded { get; set; }
        public string clubColors { get; set; }
        public string venue { get; set; }
        public List<Squad> squad { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}
