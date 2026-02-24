using Sms.Core.Entities;
using Sms.Services.UserAccountManagement;

namespace Sms.Api.GraphQL.Queries.UserAccountManagement;

[ExtendObjectType("Query")]
public class AppUserQuery
{
    // GET ALL
    public Task<IEnumerable<AppUser>> AppUsers([Service] AppUserService service)
        => service.GetUsers();
    
    // GET All BY SCHOOL
    public Task<IEnumerable<AppUser>> AppUsersBySchool(int schoolId, [Service] AppUserService service) 
        => service.GetUsers(schoolId);
    
    // GET BY ID
    public Task<AppUser?> AppUserById(int id, [Service] AppUserService service)
        => service.GetUser(id);
    
    // GET BY EMAIL
    public Task<AppUser?> AppUserByEmail(string email, [Service] AppUserService service)
        => service.GetUser(email);
}