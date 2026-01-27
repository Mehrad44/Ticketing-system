using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Application.Dtos.Tickets;
using TicketingSystem.Application.Interfaces.Repositories;
using TicketingSystem.Domain.Entities;

namespace TicketingSystem.Application.Features.Tickets.Create
{
    public class CreateTicketCommand
    {
        private readonly ITicketRepository _ticketRepository;

        public CreateTicketCommand(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task ExecuteAsync(CreateTicketDto dto, Guid userId)
        {
            var ticket = new Ticket(dto.Title, dto.Description, userId);
            await _ticketRepository.AddAsync(ticket);
        }
    }
}
