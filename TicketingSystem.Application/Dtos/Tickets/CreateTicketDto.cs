using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem.Application.Dtos.Tickets
{
    public record CreateTicketDto(
        string Title,
        string Description
    );
}
