using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UbiWebAPI.Models
{

   

    public class ScoreModel
    {
        public List<Details> ScoreDetails { get; set; }
    }
    public class Details
    {

        public string Username { get; set; }
        public int Rank { get; set; }
        public int Kills { get; set; }
        public int Score { get; set; }

        public DateTime Time { get; set; }

        public string MatchId { get; set; }
    }

}