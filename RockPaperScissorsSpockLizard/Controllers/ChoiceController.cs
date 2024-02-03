using MediatR;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsSpockLizard.Dto;
using RockPaperScissorsSpockLizard.Queries;

namespace RockPaperScissorsSpockLizard.Controllers;

[Route("/")]
[ApiController]
public class ChoiceController : ControllerBase
{
    private readonly IMediator _mediator;

    public ChoiceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("choices")]
    public async Task<IEnumerable<ChoiceDto>> GetChoices() 
    {
        return await _mediator.Send(new GetChoicesQuery());
    }

    [HttpGet("choice")]
    public async Task<ChoiceDto> GetChoice()
    {
        return await _mediator.Send(new GetRandomChoiceQuery());
    }
}
