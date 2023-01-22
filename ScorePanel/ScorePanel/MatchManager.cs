using System;

namespace ScorePanel
{
    public class MatchManager : MatchABS, IMatchManager
    {
        

        public MatchManager()
            :base()
        {
            
        }

        public MatchManager(string HomeTeam, string AwayTeam)
            : base(HomeTeam, AwayTeam)
        {
        }        

        public void UpdateScore(int homeTeam, int awayTeam)
        {
            this.HomeTeamResult = homeTeam;
            this.AwayTeamResult = awayTeam;

            this.TotalResult = this.HomeTeamResult + this.AwayTeamResult;
        }

        
    }
}
