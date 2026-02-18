using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class UptimeStatusService : BaseActivatableService<UptimeStatus>
{
    public UptimeStatusService(
        IUptimeStatusRepository repo,
        AuditLogService audit) : base(repo, audit){}
}