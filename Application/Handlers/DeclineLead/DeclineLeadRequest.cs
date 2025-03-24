using MediatR;

namespace Application.Handlers.DeclineLead
{
    public class DeclineLeadRequest : IRequest
    {
        public int LeadId { get; set; }

    }
}
