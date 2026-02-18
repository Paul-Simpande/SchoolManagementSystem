using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class AdmissionStatusQuery
{
    public Task<IEnumerable<AdmissionStatus>> GetAdmissionStatuses([Service] AdmissionStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<AdmissionStatus> GetAdmissionStatus(int id, [Service] AdmissionStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}