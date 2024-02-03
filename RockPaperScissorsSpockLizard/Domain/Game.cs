namespace RockPaperScissorsSpockLizard.Domain
{
    public class Game
    {
        private static Dictionary<Choice, List<Choice>> _strongerThan =
    new Dictionary<Choice, List<Choice>>()
    {
                { Choice.Rock, new List<Choice>() { Choice.Lizard, Choice.Scissors } },
                { Choice.Lizard, new List<Choice>() {Choice.Spock, Choice.Paper } },
                { Choice.Spock, new List<Choice>() {Choice.Rock, Choice.Scissors } },
                { Choice.Scissors, new List<Choice>() {Choice.Paper, Choice.Lizard } },
                { Choice.Paper, new List<Choice>() {Choice.Spock, Choice.Rock }
            }
 };

        public GameResult Play(Choice playerOneChoice, Choice playerTwoChoice) 
        {
            if (playerOneChoice == playerTwoChoice) 
            {
                return GameResult.Tie;
            }

            if (HasPlayerOneWon(playerOneChoice, playerTwoChoice)) 
            {
                return GameResult.Win;
            }

            return GameResult.Lose;
        }

        private bool HasPlayerOneWon(Choice playerOneChoice, Choice playerTwoChoice) 
        {
            return _strongerThan[playerOneChoice].Any(x => x == playerTwoChoice);
        }

    }
}
