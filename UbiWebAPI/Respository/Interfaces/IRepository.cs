using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiWebAPI.Models;

namespace UbiWebAPI.Respository.Interfaces
{
    public interface IRepository
    {
        string SaveScore(ScoreModel request);

        List<Details> GetPlayersStats(string username);
        List<Details> GetMatchStats(string match, DateTime time);
        List<Details> GetLeaderBoad(string match, DateTime time);
    }
}
