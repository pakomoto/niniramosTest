using ScorePanel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public class ScoreManager
    {
        public MatchDao MatchDao { get; set; }

        public ScoreManager(MatchDao MatchDao)
        {
            this.MatchDao = MatchDao;
        }

        public void StartGame(string home, string away)
        {
            try
            {
                this.MatchDao.StartGame(home, away);
            }
            catch (MatchDaoException mex)
            {
                throw new Exception("Starting game exception.",mex);
            }
        }

        public void EndGame(MatchManager game)
        {
            try
            {
                this.MatchDao.EndGame(game);
            }
            catch(Exception ex)
            {
                throw new Exception("End game exception.", ex);
            }
        }

        public void UpdateScore(string home, string away, int homeResult, int awayResult)
        {
            try
            {
                this.MatchDao.UpdateScore(home, away, homeResult, awayResult);
            }
            catch (Exception ex)
            {
                throw new Exception("UpdateScore exception.", ex);
            }
        }

        public List<MatchManager> GetSummary
        {
            get
            {
                return null;
            }

        }
    }
}
