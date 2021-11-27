using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Canadian
    {
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("stringName")]
        public string stringName { get; set; }
    }

}
