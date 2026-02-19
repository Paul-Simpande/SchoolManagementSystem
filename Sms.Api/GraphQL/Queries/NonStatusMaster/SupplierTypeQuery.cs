using Sms.Core.Entities;
using Sms.Services.NonStatusMaster;

namespace Sms.Api.GraphQL.Queries.NonStatusMaster;

[ExtendObjectType ("Query")]
public class SupplierTypeQuery
{
    public Task<IEnumerable<SupplierType>> GetSupplierTypes([Service] SupplierTypeService service)
    {
        return service.GetAllAsync();
    }

    public Task<SupplierType> GetSupplierType(int id, [Service] SupplierTypeService service)
    {
        return service.GetByIdAsync(id);
    }
}