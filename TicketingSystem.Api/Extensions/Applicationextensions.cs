using TicketingSystem.Application.Features.Auth.Login;
using TicketingSystem.Application.Features.Tickets.Create;
using TicketingSystem.Application.Features.Tickets.Reply;

namespace TicketingSystem.Api.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<LoginCommand>();
            services.AddScoped<CreateTicketCommand>();
            services.AddScoped<ReplyTicketCommand>();
            return services;
        }
    }
}
