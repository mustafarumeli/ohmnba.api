using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Arena
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isDomestic")]
        public bool IsDomestic { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateAbbr")]
        public string StateAbbr { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

}
