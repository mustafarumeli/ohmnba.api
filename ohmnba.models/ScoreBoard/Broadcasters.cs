using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Broadcasters
    {
        [JsonProperty("national")]
        public Canadian[] National { get; set; }

        [JsonProperty("canadian")]
        public Canadian[] Canadian { get; set; }

        [JsonProperty("vTeam")]
        public object[] VTeam { get; set; }

        [JsonProperty("hTeam")]
        public object[] HTeam { get; set; }

        [JsonProperty("spanish_hTeam")]
        public object[] SpanishHTeam { get; set; }

        [JsonProperty("spanish_vTeam")]
        public object[] SpanishVTeam { get; set; }

        [JsonProperty("spanish_national")]
        public object[] SpanishNational { get; set; }
    }

}
