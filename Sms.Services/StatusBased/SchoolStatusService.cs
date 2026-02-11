using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class SchoolStatusService : BaseActivatableService<SchoolStatus>
{
    public SchoolStatusService(
        ISchoolStatusRepository repo,
        AuditLogService audit)
        : base(repo, audit) { }
}