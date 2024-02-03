using MediatR;
using RockPaperScissorsSpockLizard.Domain;
using RockPaperScissorsSpockLizard.Dto;
using RockPaperScissorsSpockLizard.Repository;

namespace RockPaperScissorsSpockLizard.Commands;

public class PlayGameCommandHandler : IRequestHandler<PlayGameCommand, ResultDto>
{
    private readonly IChoiceGenerator _choiceGenerator;
    private readonly IScoreRepository _scoreRepository;

    public PlayGameCommandHandler(IChoiceGenerator choiceGenerator, IScoreRepository scoreRepository)
    {
        _choiceGenerator = choiceGenerator;
        _scoreRepository = scoreRepository;
    }

    public async Task<ResultDto> Handle(PlayGameCommand request, CancellationToken cancellationToken)
    {
        var computerChoice = await _choiceGenerator.Generate();

        var game = new Game();

        var result = game.Play(request.PlayerChoice, computerChoice);

        _scoreRepository.AddScore(result);

        return new ResultDto()
        {
            Results = result.ToString().ToLower(),
            Player = (int)request.PlayerChoice,
            Computer = (int)computerChoice
        };
    }
}
