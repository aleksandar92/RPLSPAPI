using MediatR;
using RockPaperScissorsSpockLizard.Repository;

namespace RockPaperScissorsSpockLizard.Commands;

public class ResetScoreboardCommandHandler : IRequestHandler<ResetScoreboardCommand>
{
    private readonly IScoreRepository _scoreRepository;

    public ResetScoreboardCommandHandler(IScoreRepository scoreRepository)
    {
        _scoreRepository = scoreRepository;
    }

    public async Task Handle(ResetScoreboardCommand request, CancellationToken cancellationToken)
    {
        _scoreRepository.Reset();

        await Task.CompletedTask;
    }
}
