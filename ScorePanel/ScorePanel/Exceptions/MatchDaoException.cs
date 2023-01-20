using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePanel.Exceptions
{
    public class MatchDaoException : Exception
    {
        public MatchDaoException()
        {
        }

        public MatchDaoException(string message)
            : base(message)
        {
        }

        public MatchDaoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
