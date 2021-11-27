using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class HTeamStream
    {
        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("isOnAir")]
        public bool IsOnAir { get; set; }

        [JsonProperty("streamId")]
        public string StreamId { get; set; }
    }

}
