using Moq;
using RockPaperScissorsSpockLizard.Domain;
using RockPaperScissorsSpockLizard.NumberRandomizer;

namespace RockPaperScissorsSpockLizard.UnitTests.DomainTests;

public class ChoiceGeneratorTests
{
    [TestCase(5,Choice.Rock)]
    [TestCase(21, Choice.Paper)]
    [TestCase(92, Choice.Scissors)]
    [TestCase(53, Choice.Spock)]
    [TestCase(44, Choice.Lizard)]
    public void Choice_Generator_Test(int randomNumber,Choice expectedChoice) 
    {
        var numberRandomizer = new Mock<INumberRandomizer>();
        numberRandomizer.Setup(x => x.GetRandomNumber()).ReturnsAsync(randomNumber);

        var choiceGenerator = new ChoiceGenerator(numberRandomizer.Object);
    }

}
