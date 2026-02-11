using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class UserStatusService : BaseActivatableService<UserStatus>
{
    public UserStatusService(
        IUserStatusRepository repo,
        AuditLogService audit)
        : base(repo, audit) { }
}