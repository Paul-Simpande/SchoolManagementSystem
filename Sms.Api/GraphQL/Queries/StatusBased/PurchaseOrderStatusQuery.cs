using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class PurchaseOrderStatusQuery
{
    public Task<IEnumerable<PurchaseOrderStatus>> GetPurchaseOrderStatuses([Service] PurchaseOrderStatusService service)
    {
        return service.GetAllAsync();
    }
    
    public Task<PurchaseOrderStatus> GetPurchaseOrderStatus(int id, [Service] PurchaseOrderStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}