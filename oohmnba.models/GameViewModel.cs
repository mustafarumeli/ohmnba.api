using System;
using System.Collections.Generic;

namespace oohmnba.models
{
    public class GameViewModel
    {
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string HomeTeamTriCode { get; set; }
        public string AwayTeamTriCode { get; set; }
        public string HomeTeamScore { get; set; }
        public string AwayTeamScore { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<PeriodScore> PeriodScores { get; set; } = new List<PeriodScore>();

    }
    public class PeriodScore
    {
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
}
