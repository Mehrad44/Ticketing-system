using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem.Application.Dtos.Auth
{
    public record LoginRequestDto(
        string Email,
        string Password
    );
}
