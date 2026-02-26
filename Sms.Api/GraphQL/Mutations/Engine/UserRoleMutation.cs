using Sms.Services.Engine;

namespace Sms.Api.GraphQL.Mutations.Engine;

[ExtendObjectType("Mutation")]
public class UserRoleMutation
{
    public async Task<bool> AssignRole(
        int userId,
        int roleId,
        int? performedByUserId,
        [Service] UserRoleService service)
    {
        return await service.AssignRole(userId, roleId, performedByUserId);
    }

    public async Task<bool> RemoveRole(
        int userId,
        int roleId,
        int? performedByUserId,
        [Service] UserRoleService service)
    {
        return await service.RemoveRole(userId, roleId, performedByUserId);
    }
}