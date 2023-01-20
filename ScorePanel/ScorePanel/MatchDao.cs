using ScorePanel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public class MatchDao
    {
        public List<MatchManager> ListMatchResult { get; set; }

        public MatchDao(List<MatchManager> ListMatchResult)
        {
            this.ListMatchResult = ListMatchResult;
        }

        public void StartGame(string home, string away)
        {
            if (this.ListMatchResult.Exists(q => q.HomeTeam == home && q.AwayTeam == away))
                throw new MatchDaoException("Value exits in DB.");

            this.ListMatchResult.Add(new MatchManager(home, away));
        }

        public void EndGame(MatchManager game)
        {
            if (this.ListMatchResult.Exists(q => q.HomeTeam == game.HomeTeam && q.AwayTeam == game.AwayTeam))
                this.ListMatchResult.Remove(game);
            else
                throw new MatchDaoException("EndGame error, not found value in DB.");
        }

        public void UpdateScore(string home, string away, int homeResult, int awayResult)
        {
            MatchManager game = this.ListMatchResult.Find(q => q.HomeTeam == home && q.AwayTeam == away);

            if (game != null)
            {
                game.HomeTeamResult = homeResult;
                game.AwayTeamResult = awayResult;
            }
            else
                throw new MatchDaoException("UpdateScore error, not found value in DB.");
        }
    }
}
