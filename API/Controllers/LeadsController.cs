using Application.Handlers.AcceptLead;
using Application.Handlers.DeclineLead;
using Application.Handlers.GetLeads;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/leads")]
    public class LeadsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> GetActiveLeads([FromQuery] string leadStatus)
        {
            if (Enum.TryParse<LeadStatus>(leadStatus, true, out var status))
            {
                var result = await _mediator.Send(new GetLeadsRequest { LeadStatus = status });
                return Ok(result);
            }
            return BadRequest("Status inválido!");

        }

        [HttpPut("accepted")]
        public async Task<IActionResult> AcceptLead([FromQuery] int leadId)
        {
            try
            {
                await _mediator.Send(new AcceptLeadRequest { LeadId = leadId });
                return Ok();

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro durante o processo AcceptLead: {ex}");
                ;
            }
        }

        [HttpPut("decline")]
        public async Task<IActionResult> DeclineLead([FromQuery] int leadId)
        {
            try
            {
                await _mediator.Send(new DeclineLeadRequest { LeadId = leadId });
                return Ok();

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro durante o processo DeclineLead: {ex}");
                ;
            }
        }
    }
}
