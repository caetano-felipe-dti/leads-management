using Domain.Entities;

namespace Application.Handlers.GetLeads
{
    public class GetLeadsResponse
    {
        public IEnumerable<Lead> Leads { get; set; }

        public GetLeadsResponse(IEnumerable<Lead> leads)
        {
            Leads = leads;
        }
    }
}
