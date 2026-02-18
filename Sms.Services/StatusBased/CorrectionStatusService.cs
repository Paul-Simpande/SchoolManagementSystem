using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class CorrectionStatusService : BaseActivatableService<CorrectionStatus>
{
    public CorrectionStatusService(
        ICorrectionStatusRepository repo,
        AuditLogService audit) : base(repo, audit){}
}