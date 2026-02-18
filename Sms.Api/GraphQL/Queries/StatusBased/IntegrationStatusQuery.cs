using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class IntegrationStatusQuery
{
    public Task<IEnumerable<IntegrationStatus>> GetIntegrationStatuses([Service] IntegrationStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<IntegrationStatus> GetIntegrationStatus(int id, [Service] IntegrationStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}