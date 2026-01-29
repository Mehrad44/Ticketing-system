using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Application.Dtos.Tickets;
using TicketingSystem.Application.Features.Tickets.Create;
using TicketingSystem.Application.Features.Tickets.Reply;
using TicketingSystem.Domain.Entities;

namespace TicketingSystem.Api.Controllers
{
    [ApiController]
    [Route("api/tickets")]
    [Authorize]
    public class TicketController : ControllerBase
    {
        private readonly CreateTicketCommand _create;
        private readonly ReplyTicketCommand _reply;

        public TicketController(CreateTicketCommand create, ReplyTicketCommand reply)
        {
            _create = create;
            _reply = reply;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTicketDto dto)
        {
            var userId = Guid.Parse(User.FindFirst("sub")!.Value);
            await _create.ExecuteAsync(dto, userId);
            return Ok();
        }

        [HttpPost("{id}/reply")]
        public async Task<IActionResult> Reply(Guid id, TicketMessageDto dto)
        {
            var userId = Guid.Parse(User.FindFirst("sub")!.Value);
            await _reply.ExecuteAsync(id, dto, userId);
            return Ok();
        }
    }

}
