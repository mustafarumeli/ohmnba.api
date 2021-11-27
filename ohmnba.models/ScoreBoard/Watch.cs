using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Watch
    {
        [JsonProperty("broadcast")]
        public Broadcast Broadcast { get; set; }
    }

}
