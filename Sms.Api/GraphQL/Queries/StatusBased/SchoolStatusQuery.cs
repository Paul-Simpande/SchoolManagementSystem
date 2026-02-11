using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class SchoolStatusQuery
{
    public Task<IEnumerable<SchoolStatus>> GetSchoolStatuses([Service] SchoolStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<SchoolStatus> GetSchoolStatus(int id, [Service] SchoolStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}