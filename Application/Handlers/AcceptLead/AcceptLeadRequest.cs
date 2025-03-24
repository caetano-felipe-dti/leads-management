using MediatR;

namespace Application.Handlers.AcceptLead
{
    public class AcceptLeadRequest : IRequest
    {
        public int LeadId { get; set; }

    }
}
