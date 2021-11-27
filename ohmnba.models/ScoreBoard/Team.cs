using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Team
    {
        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("triCode")]
        public string TriCode { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }

        [JsonProperty("loss")]
        public string Loss { get; set; }

        [JsonProperty("seriesWin")]
        public string SeriesWin { get; set; }

        [JsonProperty("seriesLoss")]
        public string SeriesLoss { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("linescore")]
        public Linescore[] Linescore { get; set; }
    }

}
