using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class UptimeStatusQuery
{
    public Task<IEnumerable<UptimeStatus>> GetUptimeStatuses([Service] UptimeStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<UptimeStatus> GetUptimeStatus(int id, [Service] UptimeStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}