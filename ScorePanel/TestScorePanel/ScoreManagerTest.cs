using ScorePanel;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestScorePanel
{
    public class ScoreManagerTest
    {
        [Fact]        
        public void TestConstructor()
        {
            ScoreManager scoreManager = new ScoreManager(new List<MatchResult>());
            

            Assert.True(scoreManager != null && scoreManager.ListMatchResult != null);
        }

        [Theory]
        [InlineData("Sevilla", "Betis")]
        [InlineData("Sevilla", "Español")]
        [InlineData("Sevilla", "Barcelona")]
        public void StartGame(string homeName, string awayName)
        {
            ScoreManager scoreManager = new ScoreManager(new List<MatchResult>());

            scoreManager.StartGame(homeName, awayName);

            Assert.True(scoreManager != null && scoreManager.ListMatchResult != null && scoreManager.ListMatchResult.Count == 1
                && scoreManager.ListMatchResult[0].HomeTeam == homeName && scoreManager.ListMatchResult[0].AwayTeam == awayName);
        }

        //[Theory]
        //[InlineData(5, 2)]
        //[InlineData(3, 4)]
        //[InlineData(1, 0)]
        //public void ComprobacionResultados(int value1, int value2)
        //{
        //    MatchResult matchResult = new MatchResult("Home", "Away");

        //    matchResult.UpdateScore(value1, value2);

        //    Assert.True(matchResult.HomeTeamResult == value1 && matchResult.AwayTeamResult == value2);
        //}
    }
}
