using RockPaperScissorsSpockLizard.NumberRandomizer;

namespace RockPaperScissorsSpockLizard.Domain;

public class ChoiceGenerator : IChoiceGenerator
{
    private readonly INumberRandomizer _numberRandomizer;

    public ChoiceGenerator(INumberRandomizer numberRandomizer)
    {
        _numberRandomizer = numberRandomizer;
    }

    public async Task<Choice> Generate()
    {
        var randomNumber = (await _numberRandomizer.GetRandomNumber() % 5) + 1;
        return (Choice) randomNumber;
    }
}
