using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class UserStatusRepository
    : BaseActivatableRepository<UserStatus>,
        IUserStatusRepository
{
    public UserStatusRepository(SchoolDbContext context)
        : base(context) { }
}
