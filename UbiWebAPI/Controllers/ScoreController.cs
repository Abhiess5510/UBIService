using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UbiWebAPI.Models;
using UbiWebAPI.Services;
using UbiWebAPI.Services.Interfaces;


namespace UbiWebAPI.Controllers
{
    [Route("api/score/")]
    public class ScoreController : ApiController
    {
        private IScore _iScore;

        public ScoreController()
        {
            _iScore = new ScoreService();
        }

        [HttpGet]
        [Route("LeaderBoad")]
        public List<Details> LeaderBoad(string match, DateTime time)
        {

            return _iScore.GetLeaderBoad(match,time);

        }

        [HttpGet]
        [Route("playersStats")]
        public List<Details> GetMatchStats(string match,DateTime time)
        {
            //assuming time variable will be having value set from client side itself
            return _iScore.GetMatchStats(match,time);

        }

        [HttpGet]
        [Route("playersStats/:id")]
        public List<Details> GetPlayersStats(string username)
        {

            return _iScore.GetPlayersStats(username);

        }

        [HttpPost]
        [Route("savescore")]
        public string SaveScore(ScoreModel request)
        {
            return _iScore.SaveScore(request);

        }
    }
}
