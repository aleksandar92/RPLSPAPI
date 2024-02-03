using RockPaperScissorsSpockLizard.Domain;

namespace RockPaperScissorsSpockLizard.Repository
{
    public interface IScoreRepository
    {
        public void AddScore(GameResult result);

        public IEnumerable<GameResult> GetTopLatestResults(int numberOfLatestResults);

        public void Reset();
    }
}
