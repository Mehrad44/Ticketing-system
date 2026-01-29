using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Application.Dtos.Auth;
using TicketingSystem.Application.Interfaces.Repositories;
using TicketingSystem.Application.Interfaces.Security;

namespace TicketingSystem.Application.Features.Auth.Login
{
    public class LoginCommand
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public LoginCommand(
            IUserRepository userRepository,
            IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<LoginResponseDto> ExecuteAsync(LoginRequestDto request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email)
                       ?? throw new Exception("Invalid credentials");

            // Password verification later (Infrastructure)
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new LoginResponseDto(token);
        }
    }

}
