using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UbiWebAPI.Models;
using UbiWebAPI.Respository;
using UbiWebAPI.Respository.Interfaces;
using UbiWebAPI.Services.Interfaces;

namespace UbiWebAPI.Services
{
    public class ScoreService:IScore
    {

        IRepository _iRepository;

        public ScoreService()
        {
            _iRepository = new ScoreRepository();
        }

        public string SaveScore(ScoreModel request)
        {
            return _iRepository.SaveScore(request);
        }
        public List<Details> GetPlayersStats(string username)
        {
            return _iRepository.GetPlayersStats(username);
        }
        public List<Details> GetMatchStats(string match,DateTime time)
        {
            return _iRepository.GetMatchStats(match,time);
        }
        public List<Details> GetLeaderBoad(string match, DateTime time)
        {
            return _iRepository.GetLeaderBoad(match, time);
        }
    }
}