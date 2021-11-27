using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Audio
    {
        [JsonProperty("national")]
        public HTeam National { get; set; }

        [JsonProperty("vTeam")]
        public HTeam VTeam { get; set; }

        [JsonProperty("hTeam")]
        public HTeam HTeam { get; set; }
    }

}
