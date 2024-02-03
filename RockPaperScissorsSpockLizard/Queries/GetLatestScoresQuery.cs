using MediatR;
using RockPaperScissorsSpockLizard.Dto;

namespace RockPaperScissorsSpockLizard.Queries;

public class GetLatestScoresQuery : IRequest<IEnumerable<string>>
{
    public int NumberOfLatest { get; set; }
}
