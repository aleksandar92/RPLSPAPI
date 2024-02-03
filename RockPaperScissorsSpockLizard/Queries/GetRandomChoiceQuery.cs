using MediatR;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using RockPaperScissorsSpockLizard.Dto;

namespace RockPaperScissorsSpockLizard.Queries;

public class GetRandomChoiceQuery : IRequest<ChoiceDto>
{

}
