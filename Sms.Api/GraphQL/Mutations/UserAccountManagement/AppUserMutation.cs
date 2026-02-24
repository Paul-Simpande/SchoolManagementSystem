using Sms.Core.DTOs.inputs.UserAccountManagement;
using Sms.Core.Entities;
using Sms.Services.UserAccountManagement;

namespace Sms.Api.GraphQL.Mutations.UserAccountManagement;

[ExtendObjectType("Mutation")]
public class AppUserMutation
{
    // CREATE
    public Task<AppUser> CreateUser(AppUserInput input, int? createdByUserId, [Service] AppUserService service)
        => service.CreateUser(input, createdByUserId);
    
    // UPDATE
    public Task<AppUser?> UpdateUser(int id, AppUserInput input, int? userId, [Service] AppUserService service)
        => service.UpdateUser(id, input, userId);
    
    // DELETE
    public Task<bool> DeleteUser(int id, int? userId, [Service] AppUserService service)
        => service.DeleteUser(id, userId);
}