using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class InvoiceStatusQuery
{
    public Task<IEnumerable<InvoiceStatus>> GetInvoiceStatuses([Service] InvoiceStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<InvoiceStatus> GetInvoiceStatus(int id, [Service] InvoiceStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}