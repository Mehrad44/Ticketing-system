using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Application.Dtos.Auth;
using TicketingSystem.Application.Features.Auth.Login;

namespace TicketingSystem.Api.Controllers
{

    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly LoginCommand _loginCommand;

        public AuthController(LoginCommand loginCommand)
        {
            _loginCommand = loginCommand;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto dto)
        {
            var result = await _loginCommand.ExecuteAsync(dto);
            return Ok(result);
        }
    }
}
