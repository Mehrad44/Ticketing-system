using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem.Application.Dtos.Autrh
{
    public record LoginRequestDto(
        string Email,
        string Password
    );
}
