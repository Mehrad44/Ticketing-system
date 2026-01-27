using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Application.Dtos.Tickets;
using TicketingSystem.Application.Interfaces.Repositories;
using TicketingSystem.Domain.Entities;

namespace TicketingSystem.Application.Features.Tickets.Reply
{
    public class ReplyTicketCommand
    {
        private readonly ITicketRepository _ticketRepository;

        public ReplyTicketCommand(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task ExecuteAsync(Guid ticketId, TicketMessageDto dto, Guid userId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId)
                         ?? throw new Exception("Ticket not found");

            var message = new TicketMessage(dto.Message, ticketId, userId);
            // EF later message attach می‌کنه

            await _ticketRepository.AddAsync(ticket);
        }
    }
}
