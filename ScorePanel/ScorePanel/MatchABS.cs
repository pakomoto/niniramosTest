using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public abstract class MatchABS
    {
        public string HomeTeam { get; set; }
        public int HomeTeamResult { get; protected set; }
        public string AwayTeam { get; set; }
        public int AwayTeamResult { get; protected set; }
        public int TotalResult { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime? EndDate { get; protected set; }

        public MatchABS()
        {
            this.HomeTeamResult = 0;
            this.AwayTeamResult = 0;
            this.StartDate = DateTime.Now;
        }

        public MatchABS(string HomeTeam, string AwayTeam)
            : this()
        {
            this.HomeTeam = HomeTeam;
            this.AwayTeam = AwayTeam;
        }

        public override string ToString()
        {
            return string.Format("{0} {2} - {1} {3}", this.HomeTeam, this.AwayTeam, this.HomeTeamResult, this.AwayTeamResult);
        }
    }
}
