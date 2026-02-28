using Sms.Core.DTOs.inputs.Auth;
using Sms.Core.Interfaces.Engine;
using Sms.Core.Interfaces.UserAccountManagement;
using Sms.Services.Security;
using Sms.Services.UserAccountManagement;

namespace Sms.Api.GraphQL.Mutations.Auth;

[ExtendObjectType("Mutation")]
public class AuthMutation
{
    public async Task<string> Login(
        LoginInputs input,
        [Service] AppUserService userService,
        [Service] IUserRoleRepository userRoleRepo,
        [Service] IRoleRepository roleRepo,
        [Service] JwtTokenService jwtService)
    {
        return await userService.Login(
            input.Email,
            input.Password,
            userRoleRepo,
            roleRepo,
            jwtService);
    }
}