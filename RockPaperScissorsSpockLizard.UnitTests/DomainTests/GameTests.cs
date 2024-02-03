using RockPaperScissorsSpockLizard.Domain;

namespace RockPaperScissorsSpockLizard.UnitTests.DomainTests;

public class GameTests
{
    [TestCase(Choice.Rock,Choice.Lizard)]
    [TestCase(Choice.Rock, Choice.Scissors)]
    [TestCase(Choice.Lizard, Choice.Paper)]
    [TestCase(Choice.Lizard, Choice.Spock)]
    [TestCase(Choice.Spock, Choice.Rock)]
    [TestCase(Choice.Spock, Choice.Scissors)]
    [TestCase(Choice.Scissors, Choice.Paper)]
    [TestCase(Choice.Scissors, Choice.Lizard)]
    [TestCase(Choice.Paper, Choice.Rock)]
    [TestCase(Choice.Paper, Choice.Spock)]
    public void PlayerOne_Win_PlayerTwo(Choice playerOneChoice, Choice playerTwoChoice) 
    {
        var game = new Game();

        var result = game.Play(Choice.Rock, Choice.Lizard);

        Assert.True(result == GameResult.Win);
    }

    [TestCase(Choice.Rock, Choice.Paper)]
    [TestCase(Choice.Rock, Choice.Spock)]
    [TestCase(Choice.Lizard, Choice.Scissors)]
    [TestCase(Choice.Lizard, Choice.Rock)]
    [TestCase(Choice.Spock, Choice.Lizard)]
    [TestCase(Choice.Spock, Choice.Paper)]
    [TestCase(Choice.Scissors, Choice.Rock)]
    [TestCase(Choice.Scissors, Choice.Spock)]
    [TestCase(Choice.Paper, Choice.Scissors)]
    [TestCase(Choice.Paper, Choice.Lizard)]
    public void PlayerOne_Lose_PlayerTwo(Choice playerOneChoice, Choice playerTwoChoice)
    {
        var game = new Game();

        var result = game.Play(playerOneChoice, playerTwoChoice);

        Assert.True(result == GameResult.Lose);
    }


    [TestCase(Choice.Rock, Choice.Rock)]
    [TestCase(Choice.Lizard, Choice.Lizard)]
    [TestCase(Choice.Spock, Choice.Spock)]
    [TestCase(Choice.Scissors, Choice.Scissors)]
    [TestCase(Choice.Paper, Choice.Paper)]
    public void PlayerOne_Tie_PlayerTwo(Choice playerOneChoice, Choice playerTwoChoice)
    {
        var game = new Game();

        var result = game.Play(playerOneChoice, playerTwoChoice);

        Assert.True(result == GameResult.Tie);
    }
}
