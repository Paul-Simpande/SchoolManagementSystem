using Sms.Core.Entities;
using Sms.Services.StatusBased;

namespace Sms.Api.GraphQL.Queries.StatusBased;

[ExtendObjectType("Query")]
public class UserStatusQuery
{
    public Task<IEnumerable<UserStatus>> GetUserStatuses([Service] UserStatusService service)
    {
        return service.GetAllAsync();
    }

    public Task<UserStatus> GetUserStatus(int id, [Service] UserStatusService service)
    {
        return service.GetByIdAsync(id);
    }
}