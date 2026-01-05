using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Domain.Common;
using TicketingSystem.Domain.Enums;

namespace TicketingSystem.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public TicketStatus Status { get; private set; }

        public Guid UserId { get; private set; }
        public User User { get; private set; }

        private readonly List<TicketMessage> _messages = new();
        public IReadOnlyCollection<TicketMessage> Messages => _messages.AsReadOnly();

        private Ticket() { }

        public Ticket(string title, string description, Guid userId)
        {
            Title = title;
            Description = description;
            UserId = userId;
            Status = TicketStatus.Open;
        }

        public void Close()
        {
            Status = TicketStatus.Closed;
        }
    }
}
