using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UbiWebAPI.Models;
using UbiWebAPI.Respository.Interfaces;

namespace UbiWebAPI.Respository
{
    public class ScoreRepository : IRepository
    {
        public ScoreRepository()
        {
            //will create static dbcontext variable here
        }
        public List<Details>  GetLeaderBoad(string match, DateTime time)
        {
            List<Details> stats = new List<Details>();

            //get match stats with the help of linq and querying by matchId field

            /*
             stats=dbcontext.ScoreTbale.Where(x.MatchId=match && x.time < time).Select(s=>s).OrderByDesc(o=>o.score).Take(100).ToList().Distinct(new OrderComparer());
             
             */
            
            return stats;
        }

        class OrderComparer : IEqualityComparer<Details>
        {
          
            public bool Equals(Details x, Details y)
            {
                if (x.Username == y.Username)
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(Details obj)
            {
                return 1;
            }
        }

        public List<Details> GetPlayersStats(string username)
        {
            List<Details> statDetails = new List<Details>();

            //get player stats with the help of linq and querying by players username

            /*
             statDetails=dbcontext.ScoreTbale.Where(x.Username=username).Select(s=>s).FirstOrDefault().ToList();
             */

            return statDetails;
        }

        public List<Details> GetMatchStats(string match,DateTime time)
        {
            List<Details> stats = new List<Details>();

            //get match stats with the help of linq and querying by matchId field

            /*
             statDetails=dbcontext.ScoreTbale.Where(x.MatchId=match && x.time < time).Select(s=>s).FirstOrDefault().ToList();
             */

            return stats;
        }
        public string SaveScore(ScoreModel request)
        {
            Details sm = new Details();
            foreach (var req in request.ScoreDetails)
            {
                sm.Score = req.Score;
                sm.Kills = req.Kills;
                sm.Rank = CalculateRank(req.Score, req.Username);
                sm.Username = req.Username;
                sm.MatchId = req.MatchId;
                sm.Time = System.DateTime.UtcNow;

                //we  will save this sm model to Db.currently we will return hardcoded upated score.

                UpdateRanking(sm);   
            }

            return "Score updated successfully for all users";
        }

        public int CalculateRank(int currentScore,string currentUser)
        {
            int updatedRank = 0;

            //logic to get updated rank

            /*
             Sample code:

            updatedRank=dbcontext.ScoreTable.where(x=>x.score>currentscore).count();
              
             */

            return updatedRank+1;
        }

        public void UpdateRanking(Details currentPlayerDetails)
        {
            ScoreModel updateRankPlayer = new ScoreModel();
            //get all the data for players having less score than current player and increase their ranking by 1 with bulk update

            /*
            updateRankPlayer=dbcontext.ScoreTable.where(x=>x.score<currentscore).Select(s).FirstOrDefault();
             */
        }
    }
}