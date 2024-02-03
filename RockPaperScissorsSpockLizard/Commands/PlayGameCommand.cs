using MediatR;
using RockPaperScissorsSpockLizard.Domain;
using RockPaperScissorsSpockLizard.Dto;

namespace RockPaperScissorsSpockLizard.Commands;

public class PlayGameCommand : IRequest<ResultDto>
{
    public Choice PlayerChoice { get; set; }
}
