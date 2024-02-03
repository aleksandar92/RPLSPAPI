using RockPaperScissorsSpockLizard.Repository;

namespace RockPaperScissorsSpockLizard.UnitTests.DomainTests;

public class ScoreRepositoryTests
{
    [Test]
    public void  ScoreRepository_GetLatest() 
    {
        var scoreRepository = new ScoreRepository();

        scoreRepository.AddScore(Domain.GameResult.Win);
        scoreRepository.AddScore(Domain.GameResult.Tie);
        scoreRepository.AddScore(Domain.GameResult.Lose);
        scoreRepository.AddScore(Domain.GameResult.Lose);

        var result =  scoreRepository.GetTopLatestResults(2).ToList();

        Assert.True(result.Count == 2);
        Assert.True(result.All(x => x == Domain.GameResult.Lose));
    }

    [Test]
    public void ScoreRepository_Reset()
    {
        var scoreRepository = new ScoreRepository();

        scoreRepository.AddScore(Domain.GameResult.Win);
        scoreRepository.AddScore(Domain.GameResult.Tie);
        scoreRepository.AddScore(Domain.GameResult.Lose);
        scoreRepository.AddScore(Domain.GameResult.Lose);

        scoreRepository.Reset();

        var result = scoreRepository.GetTopLatestResults(2).ToList();

        Assert.True(result.Count == 0);
    }
}
