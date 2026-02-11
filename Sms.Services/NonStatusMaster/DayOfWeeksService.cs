using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Services.Common;

namespace Sms.Services.NonStatusMaster;

public class DayOfWeeksService : BaseActivatableService<DayOfWeeks>
{
    public DayOfWeeksService(
        IDayOfWeekRepository repo,
        AuditLogService audit)
        : base(repo, audit) { }
}