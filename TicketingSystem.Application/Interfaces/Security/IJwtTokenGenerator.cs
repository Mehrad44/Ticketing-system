using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Domain.Entities;

namespace TicketingSystem.Application.Interfaces.Security
{

    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
