using Sms.Core.Entities;
using Sms.Services.NonStatusMaster;

namespace Sms.Api.GraphQL.Queries.NonStatusMaster;

[ExtendObjectType("Query")]
public class PaymentMethodQuery
{
    public Task<IEnumerable<PaymentMethod>> GetPaymentMethods([Service] PaymentMethodService service)
    {
        return service.GetAllAsync();
    }

    public Task<PaymentMethod> GetPaymentMethod(int id, [Service] PaymentMethodService service)
    {
        return service.GetByIdAsync(id);
    }
}