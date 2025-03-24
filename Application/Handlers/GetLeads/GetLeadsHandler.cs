using Infra;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.GetLeads
{
    public class GetLeadsHandler : IRequestHandler<GetLeadsRequest, GetLeadsResponse>
    {
        private readonly ApplicationDbContext _context;

        public GetLeadsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GetLeadsResponse> Handle(GetLeadsRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Executando GetLeadHandler");

            var leads = await _context.Leads.Where(x => x.Status == request.LeadStatus).ToListAsync();

            if (leads == null)
            {
                throw new Exception("Lead not found");
            }

            var response = new GetLeadsResponse(leads);

            return response;

        }
    }
}
