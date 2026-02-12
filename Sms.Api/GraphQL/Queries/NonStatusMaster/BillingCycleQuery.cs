using Sms.Core.Entities;
using Sms.Services.NonStatusMaster;

namespace Sms.Api.GraphQL.Queries.NonStatusMaster;

[ExtendObjectType("Query")]
public class BillingCycleQuery
{
    public Task<IEnumerable<BillingCycle>> GetBillingCycles([Service] BillingCycleService service)
    {
        return service.GetAllAsync();
    }

    public Task<BillingCycle> GetBillingCycle(int id, [Service] BillingCycleService service)
    {
        return service.GetByIdAsync(id);
    }
}