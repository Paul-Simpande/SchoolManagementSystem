using Sms.Core.Entities;
using Sms.Services.CoreTenant;

namespace Sms.Api.GraphQL.Queries.CoreTenant;

[ExtendObjectType("Query")]
public class SchoolContactQuery
{
    public Task<IEnumerable<SchoolContact>> GetSchoolContacts(int id, [Service] SchoolContactsService service)
    {
        return service.GetBySchoolAsync(id);
    }

    public Task<SchoolContact?> GetSchoolContact(int id, [Service] SchoolContactsService service)
    {
        return service.GetById(id);
    }
}