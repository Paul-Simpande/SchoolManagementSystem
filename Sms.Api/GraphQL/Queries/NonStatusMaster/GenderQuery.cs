using Sms.Core.Entities;
using Sms.Services.NonStatusMaster;

namespace Sms.Api.GraphQL.Queries.NonStatusMaster;

[ExtendObjectType("Query")]
public class GenderQuery
{
    public Task<IEnumerable<Gender>> GetGenders([Service] GenderService service)
    {
        return service.GetAllAsync();
    }
    
    public Task<Gender> GetGender(int id, [Service] GenderService service)
    {
        return service.GetByIdAsync(id);
    }
}