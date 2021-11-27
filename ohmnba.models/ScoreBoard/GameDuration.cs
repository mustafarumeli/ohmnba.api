using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class GameDuration
    {
        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("minutes")]
        public string Minutes { get; set; }
    }

}
