using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel
{
    public interface IMatchManager
    {
        void UpdateScore(int homeTeam, int awayTeam);
    }
}
