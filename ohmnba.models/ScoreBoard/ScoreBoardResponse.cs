using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class ScoreBoardResponse
    {
        [JsonProperty("numGames")]
        public string NumGames { get; set; }

        [JsonProperty("games")]
        public Game[] Games { get; set; }
    }

}
