using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class CorrectionStatusQuery
{
    public Task<IEnumerable<CorrectionStatus>> GetCorrectionStatuses([Service] CorrectionStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<CorrectionStatus> GetCorrectionStatus(int id, [Service] CorrectionStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}