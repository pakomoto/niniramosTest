using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public interface IMatchDao
    {
        public MatchManager StartGame(string home, string away);
        public void EndGame(MatchManager game);
        void UpdateScore(string home, string away, int homeResult, int awayResult);
        List<MatchManager> GetSummary();
    }
}
