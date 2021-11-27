using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ohmnba.apiModels.ScoreBoard;
using RestSharp;
using System;
using System.Collections.Generic;

namespace ohmnba.Infrastructure
{
    public static class NbaApiRest
    {
        public static T Get<T>(string endpoint)
        {
            var client = new RestClient(endpoint);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
    public class NbaEndpoints
    {
        private readonly IConfiguration _configuration;

        public NbaEndpoints(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ICollection<Game> GetScoreBoard(DateTime? date = null)
        {
            if (!date.HasValue)
            {
                date = DateTime.Now.AddDays(-1);
            }

            string apiUrl = _configuration["nbaEndpoints:todaysScoreBoard"].Replace("{date}",date.Value.ToString("yyyyMMdd"));
            var res = NbaApiRest.Get<ScoreBoardResponse>(apiUrl);
            return res.Games;
        }
    }
}
