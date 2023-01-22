using ScorePanel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public class MatchDao : IMatchDao
    {
        private List<MatchManager> ListMatchResult { get; set; }

        public MatchDao(List<MatchManager> ListMatchResult)
        {
            this.ListMatchResult = ListMatchResult;
        }

        public MatchManager StartGame(string home, string away)
        {
            MatchManager matchManager = null;

            if (this.ListMatchResult.Exists(q => q.HomeTeam == home && q.AwayTeam == away))
                throw new MatchDaoException("Value exits in DB.");

            matchManager = new MatchManager(home, away);
            this.ListMatchResult.Add(matchManager);

            return matchManager;
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
            IMatchManager game = this.ListMatchResult.Find(q => q.HomeTeam == home && q.AwayTeam == away);

            if (game != null)
            {
                game.UpdateScore(homeResult, awayResult);
            }
            else
                throw new MatchDaoException("UpdateScore error, not found value in DB.");
        }

        public List<MatchManager> GetSummary()
        {
            return this.ListMatchResult.OrderByDescending(q => q.TotalResult).ThenByDescending(q => q.StartDate).ToList();
        }
    }
}
