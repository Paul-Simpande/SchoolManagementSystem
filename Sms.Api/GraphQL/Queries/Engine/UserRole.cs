using Sms.Core.Entities;
using Sms.Services.Engine;

namespace Sms.Api.GraphQL.Queries.Engine;

[ExtendObjectType("Query")]
public class UserRoleQuery
{
    public Task<IEnumerable<UserRole>> GetUserRoles(
        int userId,
        [Service] UserRoleService service)
    {
        return service.GetUserRoles(userId);
    }

    public Task<IEnumerable<UserRole>> GetUsersByRole(
        int roleId,
        [Service] UserRoleService service)
    {
        return service.GetUsersByRole(roleId);
    }

    public Task<bool> UserHasRole(
        int userId,
        int roleId,
        [Service] UserRoleService service)
    {
        return service.UserHasRole(userId, roleId);
    }
}