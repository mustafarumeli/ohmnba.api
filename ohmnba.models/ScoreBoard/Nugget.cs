using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Nugget
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

}
