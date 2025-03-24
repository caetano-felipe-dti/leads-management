using Infra;
using MediatR;

namespace Application.Handlers.AcceptLead
{

    public class AcceptLeadHandler : IRequestHandler<AcceptLeadRequest>
    {
        private readonly ApplicationDbContext _context;

        public AcceptLeadHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(AcceptLeadRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Executando AcceptLeadHandler");

            var lead = await _context.Leads.FindAsync(request.LeadId);

            if (lead == null)
            {
                throw new Exception("Lead not found");
            }

            lead.Accept();
            await _context.SaveChangesAsync(cancellationToken);

            File.WriteAllText("fake_email.txt", $"Email enviado para vendas@test.com sobre o lead {lead.Id}");
        }
    }
}
