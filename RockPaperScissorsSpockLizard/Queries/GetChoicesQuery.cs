using MediatR;
using RockPaperScissorsSpockLizard.Dto;

namespace RockPaperScissorsSpockLizard.Queries;

public class GetChoicesQuery : IRequest<IEnumerable<ChoiceDto>>
{

}
