using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using FluentAssertions;
using TicketingSystem.Application.Dtos.Auth;

namespace TicketingSystem.Tests.Integration
{
    public class AuthTests : IClassFixture<ApiFactory>
    {
        private readonly HttpClient _client;

        public AuthTests(ApiFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task login_should_fail_with_invalid_user()
        {
            var response = await _client.PostAsJsonAsync(
                "/api/auth/login",
                new LoginRequestDto("x@test.com", "123")
            );

            response.IsSuccessStatusCode.Should().BeFalse();
        }
    }
}
