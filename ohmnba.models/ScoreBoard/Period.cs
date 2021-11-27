using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Period
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("maxRegular")]
        public string MaxRegular { get; set; }

        [JsonProperty("isHalftime")]
        public bool IsHalftime { get; set; }

        [JsonProperty("isEndOfPeriod")]
        public bool IsEndOfPeriod { get; set; }
    }

}
