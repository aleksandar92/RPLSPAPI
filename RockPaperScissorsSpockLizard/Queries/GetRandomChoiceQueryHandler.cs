using MediatR;
using RockPaperScissorsSpockLizard.Domain;
using RockPaperScissorsSpockLizard.Dto;

namespace RockPaperScissorsSpockLizard.Queries;

public class GetRandomChoiceQueryHandler : IRequestHandler<GetRandomChoiceQuery, ChoiceDto>
{
    private readonly IChoiceGenerator _choiceGenerator;

    public GetRandomChoiceQueryHandler(IChoiceGenerator choiceGenerator)
    {
        _choiceGenerator = choiceGenerator;
    }

    public async Task<ChoiceDto> Handle(GetRandomChoiceQuery request, CancellationToken cancellationToken)
    {
        var generatedChoice = await _choiceGenerator.Generate();

        return new ChoiceDto()
        {
            Id = (int)generatedChoice,
            Name = generatedChoice.ToString().ToLower()
        };
    }
}
