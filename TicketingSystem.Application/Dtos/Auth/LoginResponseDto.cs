using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingSystem.Application.Dtos.Auth
{
    public record LoginResponseDto(
        string Token
    );
}

