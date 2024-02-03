using MediatR;
using Microsoft.OpenApi.Extensions;
using RockPaperScissorsSpockLizard.Domain;
using RockPaperScissorsSpockLizard.Dto;

namespace RockPaperScissorsSpockLizard.Queries
{
    public class GetChoicesQueryHandler : IRequestHandler<GetChoicesQuery,IEnumerable<ChoiceDto>>
    {
        public GetChoicesQueryHandler() { }

        public async Task<IEnumerable<ChoiceDto>> Handle(GetChoicesQuery request, CancellationToken cancellationToken)
        {
           return await  Task.FromResult( ((Choice[])Enum.GetValues(typeof(Choice)))
                 .Select(x => new ChoiceDto()
                 {
                     Id = ((int)x),
                     Name = x.GetDisplayName().ToLower()
                 })
                 .ToList());
        }
    }
}
