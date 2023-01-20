using ScorePanel;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace TestScorePanel
{
    public class ScoreManagerTest
    {
        [Fact]        
        public void TestConstructor()
        {
            ScoreManager scoreManager = new ScoreManager(new MatchDao(new List<MatchManager>()));

            Assert.True(scoreManager != null && scoreManager.MatchDao.ListMatchResult != null);
        }

        [Theory]
        [InlineData("Sevilla", "Betis")]
        [InlineData("Sevilla", "Español")]
        [InlineData("Sevilla", "Barcelona")]
        public void StartGame(string homeName, string awayName)
        {
            ScoreManager scoreManager = new ScoreManager(new MatchDao(new List<MatchManager>()));

            scoreManager.StartGame(homeName, awayName);

            Assert.True(scoreManager != null && scoreManager.MatchDao.ListMatchResult != null && scoreManager.MatchDao.ListMatchResult.Count == 1
                && scoreManager.MatchDao.ListMatchResult[0].HomeTeam == homeName && scoreManager.MatchDao.ListMatchResult[0].AwayTeam == awayName);
        }

        [Fact]
        public void TestPrint()
        {
            ScoreManager scoreManager = new ScoreManager(new MatchDao(new List<MatchManager>()));

            scoreManager.StartGame("Mexico", "Canada");
            Thread.Sleep(1000);
            scoreManager.StartGame("Spain", "Brazil");
            Thread.Sleep(1000);
            scoreManager.StartGame("Germany", "France");
            Thread.Sleep(1000);
            scoreManager.StartGame("Uruguay", "Italy");
            Thread.Sleep(1000);
            scoreManager.StartGame("Argentina", "Australia");

            scoreManager.UpdateScore("Mexico", "Canada", 0, 5);
            scoreManager.UpdateScore("Spain", "Brazil", 10, 2);
            scoreManager.UpdateScore("Germany", "France", 2, 2);
            scoreManager.UpdateScore("Uruguay", "Italy", 6, 6);
            scoreManager.UpdateScore("Argentina", "Australia", 3, 1);

            var list = scoreManager.GetSummary;

            int nPos = 0;
            foreach(var elemento in list)
            {
                switch(nPos)
                {
                    case 0:
                        Assert.Equal("Uruguay 6 - Italy 6", elemento.ToString());
                        break;
                    case 1:
                        Assert.Equal("Spain 10 - Brazil 2", elemento.ToString());
                        break;
                    case 2:
                        Assert.Equal("Mexico 0 - Canada 5", elemento.ToString());
                        break;
                    case 3:
                        Assert.Equal("Argentina 3 - Australia 1", elemento.ToString());
                        break;
                    case 4:
                        Assert.Equal("Germany 2 - France 2", elemento.ToString());
                        break;
                }

                nPos += 1;
            }
        }
    }
}
