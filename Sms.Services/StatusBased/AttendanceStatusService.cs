using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class AttendanceStatusService : BaseActivatableService<AttendanceStatus>
{
    public AttendanceStatusService(
        IAttendanceStatusRepository repo,
        AuditLogService audit) : base(repo, audit) { }
}