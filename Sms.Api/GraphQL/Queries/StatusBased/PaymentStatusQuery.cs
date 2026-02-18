using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class PaymentStatusQuery
{
    public Task<IEnumerable<PaymentStatus>> GetPaymentStatuses([Service] PaymentStatusService service)
    {
        return service.GetAllAsync();
    }
    
    public Task<PaymentStatus> GetPaymentStatus(int id, [Service] PaymentStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}