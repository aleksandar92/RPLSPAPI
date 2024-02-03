namespace RockPaperScissorsSpockLizard.NumberRandomizer
{
    public interface INumberRandomizer
    {
        public Task<int> GetRandomNumber();
    }
}
