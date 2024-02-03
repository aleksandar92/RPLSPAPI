using MediatR;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsSpockLizard.Commands;
using RockPaperScissorsSpockLizard.Dto;
using RockPaperScissorsSpockLizard.Dto.Input;
using RockPaperScissorsSpockLizard.Repository;

namespace RockPaperScissorsSpockLizard.Controllers;

[Route("/")]
[ApiController]
public class GameController :  ControllerBase
{
    private readonly IMediator _mediator;

    public GameController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("play")]
    public async Task<ResultDto> PlayGame([FromBody]PlayInputDto input) 
    {
        return await _mediator.Send(new PlayGameCommand() {PlayerChoice = input.Player });
    }

}
