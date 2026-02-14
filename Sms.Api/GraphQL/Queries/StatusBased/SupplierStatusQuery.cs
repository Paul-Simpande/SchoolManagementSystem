using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class SupplierStatusQuery
{
    public Task<IEnumerable<SupplierStatus>> GetSupplierStatuses([Service] SupplierStatusService repository)
    {
        return repository.GetAllAsync();
    }
    
    public Task<SupplierStatus> GetSupplierStatus(int id, [Service] SupplierStatusService repository)
    {
        return repository.GetByIdAsync(id);
    }
}