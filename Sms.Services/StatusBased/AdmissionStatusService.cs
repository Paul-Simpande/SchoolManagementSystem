using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class AdmissionStatusService : BaseActivatableService<AdmissionStatus>
{
    public AdmissionStatusService(
        IAdmissionStatusRepository repo,
        AuditLogService audit) : base(repo, audit)
    {
        
    }
}