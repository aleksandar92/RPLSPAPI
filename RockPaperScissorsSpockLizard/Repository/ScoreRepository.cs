using RockPaperScissorsSpockLizard.Domain;

namespace RockPaperScissorsSpockLizard.Repository;

public class ScoreRepository : IScoreRepository
{
    private readonly IDictionary<DateTime, GameResult> _scores;

    public ScoreRepository()
    {
        _scores = new SortedDictionary<DateTime, GameResult>(new DescendingComparer<DateTime>());
    }

    public void AddScore(GameResult result)
    {
        _scores.Add(DateTime.UtcNow,result);
    }

    public IEnumerable<GameResult> GetTopLatestResults(int numberOfLatestResults)
    {
       return _scores.Values.Take(numberOfLatestResults).ToList();
    }

    public void Reset()
    {
        _scores.Clear();
    }
}
