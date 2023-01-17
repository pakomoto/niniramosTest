using System;

namespace ScorePanel
{
    public class MatchResult
    {
        public string HomeTeam { get; set; }
        public int HomeTeamResult { get; set; }
        public string AwayTeam { get; set; }
        public int AwayTeamResult { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public MatchResult()
        {
            this.HomeTeamResult = 0;
            this.AwayTeamResult = 0;
            this.StartDate = DateTime.Now;
        }

        public MatchResult(string HomeTeam, string AwayTeam)
            : this()
        {
            this.HomeTeam = HomeTeam;
            this.AwayTeam = AwayTeam;
        }

        public void UpdateScore(int homeTeam, int awayTeam)
        {
            this.HomeTeamResult = homeTeam;
            this.AwayTeamResult = awayTeam;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}: {2}-{3}", this.HomeTeam, this.AwayTeam, this.HomeTeamResult, this.AwayTeamResult);
        }
    }
}
