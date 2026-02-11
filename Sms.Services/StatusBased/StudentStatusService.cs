using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class StudentStatusService : BaseActivatableService<StudentStatus>
{
    public StudentStatusService(
        IStudentStatusRepository repo,
        AuditLogService audit)
        : base(repo, audit) { }
}