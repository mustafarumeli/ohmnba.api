using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class VideoStream
    {
        [JsonProperty("streamType")]
        public string StreamType { get; set; }

        [JsonProperty("isOnAir")]
        public bool IsOnAir { get; set; }

        [JsonProperty("doesArchiveExist")]
        public bool DoesArchiveExist { get; set; }

        [JsonProperty("isArchiveAvailToWatch")]
        public bool IsArchiveAvailToWatch { get; set; }

        [JsonProperty("streamId")]
        public string StreamId { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

}
