using MediatR;
using RockPaperScissorsSpockLizard.Repository;

namespace RockPaperScissorsSpockLizard.Queries;

public class GetLatestScoresQueryHandler : IRequestHandler<GetLatestScoresQuery, IEnumerable<string>>
{
    private readonly IScoreRepository _scoreRepository;

    public GetLatestScoresQueryHandler(IScoreRepository scoreRepository)
    {
        _scoreRepository = scoreRepository;
    }

    public async Task<IEnumerable<string>> Handle(GetLatestScoresQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_scoreRepository.GetTopLatestResults(request.NumberOfLatest)
        .Select(x => x.ToString().ToLower())
        .ToList());
    }
}
