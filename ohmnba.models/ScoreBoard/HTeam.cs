using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class HTeam
    {
        [JsonProperty("streams")]
        public HTeamStream[] Streams { get; set; }

        [JsonProperty("broadcasters")]
        public Canadian[] Broadcasters { get; set; }
    }

}
