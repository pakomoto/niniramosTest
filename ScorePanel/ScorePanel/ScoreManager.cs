using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public class ScoreManager
    {
        public List<MatchResult> ListMatchResult { get; set; }

        public ScoreManager(List<MatchResult> ListMatchResult)
        {
            this.ListMatchResult = ListMatchResult;
        }

        public void StartGame(string home, string away)
        {
            this.ListMatchResult.Add(new MatchResult(home, away));
        }

        public void EndGame(MatchResult game)
        {
            if (this.ListMatchResult.Exists(q => q.HomeTeam == game.HomeTeam && q.AwayTeam == game.AwayTeam))
                this.ListMatchResult.Remove(game);
        }

        public void UpdateScore(string home, string away, int homeResult, int awayResult)
        {
            MatchResult game = this.ListMatchResult.Find(q=>q.HomeTeam == home && q.AwayTeam == away);

            if (game != null)
            {
                game.HomeTeamResult = homeResult;
                game.AwayTeamResult = awayResult;
            }
        }

        public List<MatchResult> GetSummary
        {
            get
            {
                return null;
            }

        }
    }
}
