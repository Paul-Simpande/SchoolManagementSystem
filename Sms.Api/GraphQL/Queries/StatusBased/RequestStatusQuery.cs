using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class RequestStatusQuery
{
    public Task<IEnumerable<RequestStatus>> GetRequestStatuses([Service] RequestStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<RequestStatus> GetRequestStatus(int id, [Service] RequestStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}