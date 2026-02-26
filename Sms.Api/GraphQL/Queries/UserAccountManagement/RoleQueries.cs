using Sms.Core.Entities;
using Sms.Services.UserAccountManagement;

namespace Sms.Api.GraphQL.Queries.UserAccountManagement;

[ExtendObjectType("Query")]
public class RoleQueries
{
    // GET ALL
    public Task<IEnumerable<Role>> Roles([Service] RoleService service)
        => service.GetRoles();
    
    // GET BY ID
    public Task<Role?> RoleByIs(int id, [Service] RoleService service)
        => service.GetRole(id);
}