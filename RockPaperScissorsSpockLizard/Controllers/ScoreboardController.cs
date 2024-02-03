using MediatR;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsSpockLizard.Commands;
using RockPaperScissorsSpockLizard.Queries;

namespace RockPaperScissorsSpockLizard.Controllers;

[Route("/scoreboard")]
[ApiController]
public class ScoreboardController : ControllerBase
{ 
    private readonly IMediator _mediator;

    public ScoreboardController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("latest")]
    public  async Task<IEnumerable<string>> GetLatestScores(int? number = 10) 
    {
        return await _mediator.Send(new GetLatestScoresQuery() { NumberOfLatest = number.Value });
    }

    [HttpPost("reset")]
    public async Task  ResetScoreboard()
    {
        await _mediator.Send(new ResetScoreboardCommand());
    }

}
