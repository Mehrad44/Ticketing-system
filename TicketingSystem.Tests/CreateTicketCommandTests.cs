using FluentAssertions;
using Moq;
using TicketingSystem.Application.Dtos.Tickets;
using TicketingSystem.Application.Features.Tickets.Create;
using TicketingSystem.Application.Interfaces.Repositories;
using TicketingSystem.Domain.Entities;

public class CreateTicketCommandTests
{
    [Fact]
    public async Task should_create_ticket_successfully()
    {
        var repo = new Mock<ITicketRepository>();
        var command = new CreateTicketCommand(repo.Object);

        var dto = new CreateTicketDto("test", "desc");
        var userId = Guid.NewGuid();

        await command.ExecuteAsync(dto, userId);

        repo.Verify(x => x.AddAsync(It.IsAny<Ticket>()), Times.Once);
    }
}