namespace RockPaperScissorsSpockLizard.Domain;

public interface IChoiceGenerator
{
    Task<Choice> Generate();
}
