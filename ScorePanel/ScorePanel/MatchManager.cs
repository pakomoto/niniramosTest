using System;

namespace ScorePanel
{
    public class MatchManager
    {
        public string HomeTeam { get; set; }
        public int HomeTeamResult { get; private set; }
        public string AwayTeam { get; set; }
        public int AwayTeamResult { get; private set; }
        public int TotalResult { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }

        public MatchManager()
        {
            this.HomeTeamResult = 0;
            this.AwayTeamResult = 0;
            this.StartDate = DateTime.Now;
        }

        public MatchManager(string HomeTeam, string AwayTeam)
            : this()
        {
            this.HomeTeam = HomeTeam;
            this.AwayTeam = AwayTeam;
        }

        public void UpdateScore(int homeTeam, int awayTeam)
        {
            this.HomeTeamResult = homeTeam;
            this.AwayTeamResult = awayTeam;

            this.TotalResult = this.HomeTeamResult + this.AwayTeamResult;
        }

        public override string ToString()
        {
            return string.Format("{0} {2} - {1} {3}", this.HomeTeam, this.AwayTeam, this.HomeTeamResult, this.AwayTeamResult);
        }
    }
}
