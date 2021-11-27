using Newtonsoft.Json;
using System;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Game
    {
 
        [JsonProperty("seasonYear")]
        public string SeasonYear { get; set; }

        [JsonProperty("gameId")]
        public string GameId { get; set; }

        [JsonProperty("arena")]
        public Arena Arena { get; set; }

        [JsonProperty("isGameActivated")]
        public bool IsGameActivated { get; set; }

        [JsonProperty("statusNum")]
        public string StatusNum { get; set; }

        [JsonProperty("extendedStatusNum")]
        public string ExtendedStatusNum { get; set; }

        [JsonProperty("startTimeEastern")]
        public string StartTimeEastern { get; set; }

        [JsonProperty("startTimeUTC")]
        public DateTimeOffset StartTimeUtc { get; set; }

        [JsonProperty("endTimeUTC")]
        public DateTimeOffset EndTimeUtc { get; set; }

        [JsonProperty("startDateEastern")]
        public string StartDateEastern { get; set; }

        [JsonProperty("homeStartDate")]
        public string HomeStartDate { get; set; }

        [JsonProperty("homeStartTime")]
        public string HomeStartTime { get; set; }

        [JsonProperty("visitorStartDate")]
        public string VisitorStartDate { get; set; }

        [JsonProperty("visitorStartTime")]
        public string VisitorStartTime { get; set; }

        [JsonProperty("gameUrlCode")]
        public string GameUrlCode { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("isBuzzerBeater")]
        public bool IsBuzzerBeater { get; set; }

        [JsonProperty("gameDuration")]
        public GameDuration GameDuration { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("vTeam")]
        public Team VTeam { get; set; }

        [JsonProperty("hTeam")]
        public Team HTeam { get; set; }
    }

}
