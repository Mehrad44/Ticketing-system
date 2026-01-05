using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Domain.Common;

namespace TicketingSystem.Domain.Entities
{

    public class TicketMessage : BaseEntity
    {
        public string Message { get; private set; }

        public Guid TicketId { get; private set; }
        public Ticket Ticket { get; private set; }

        public Guid UserId { get; private set; }
        public User User { get; private set; }

        private TicketMessage() { }

        public TicketMessage(string message, Guid ticketId, Guid userId)
        {
            Message = message;
            TicketId = ticketId;
            UserId = userId;
        }
    }
}
