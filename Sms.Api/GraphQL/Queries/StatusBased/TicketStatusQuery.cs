using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class TicketStatusQuery
{
    public Task<IEnumerable<TicketStatus>> GetTicketStatuses([Service] TicketStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<TicketStatus> GetTicketStatus(int id, [Service] TicketStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}