using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class BudgetStatusQuery
{
    public Task<IEnumerable<BudgetStatus>> GetBudgetStatuses([Service] BudgetStatusService service)
    {
        return service.GetAllAsync();
    }
    
    public Task<BudgetStatus> GetBudgetStatus(int id, [Service] BudgetStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}