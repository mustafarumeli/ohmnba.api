using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Linescore
    {
        [JsonProperty("score")]
        public int Score { get; set; }
    }

}
