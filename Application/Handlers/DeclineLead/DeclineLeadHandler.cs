using Infra;
using MediatR;

namespace Application.Handlers.DeclineLead
{
    public class DeclineLeadHandler : IRequestHandler<DeclineLeadRequest>
    {
        private readonly ApplicationDbContext _context;

        public DeclineLeadHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(DeclineLeadRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Executando DeclineLeadHandler");

            var lead = await _context.Leads.FindAsync(request.LeadId);

            if (lead == null)
            {
                throw new Exception("Lead not found");
            }

            lead.Decline();
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
