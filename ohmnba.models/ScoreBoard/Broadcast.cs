using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Broadcast
    {
        [JsonProperty("broadcasters")]
        public Broadcasters Broadcasters { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("audio")]
        public Audio Audio { get; set; }
    }

}
