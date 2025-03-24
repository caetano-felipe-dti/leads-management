using Domain.Entities;
using MediatR;

namespace Application.Handlers.GetLeads
{
    public class GetLeadsRequest : IRequest<GetLeadsResponse>
    {
        public LeadStatus LeadStatus { get; set; }
    }
}
