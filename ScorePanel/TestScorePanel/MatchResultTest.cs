using ScorePanel;
using System;
using Xunit;

namespace TestScorePanel
{
    public class MatchResultTest
    {
        //[Fact]
        [Theory]
        [InlineData("Sevilla", "Betis")]
        [InlineData("Sevilla", "Español")]
        [InlineData("Sevilla", "Barcelona")]
        public void TestConstructor(string homeName, string awayName)
        {
            MatchResult matchResult = new MatchResult(homeName, awayName);

            Assert.True(matchResult.HomeTeam.Equals(homeName) && matchResult.AwayTeam.Equals(awayName) , "Comprobación de nombres");
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(3, 4)]
        [InlineData(1, 0)]
        public void ComprobacionResultados(int value1, int value2)
        {
            MatchResult matchResult = new MatchResult("Home", "Away");

            matchResult.UpdateScore(value1, value2);

            Assert.True(matchResult.HomeTeamResult == value1 && matchResult.AwayTeamResult == value2);
        }
    }
}
