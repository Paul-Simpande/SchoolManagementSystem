using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class RequestStatusService : BaseActivatableService<RequestStatus>
{
    public RequestStatusService(
        IRequestStatusRepository repo,
        AuditLogService audit) : base(repo, audit){}
}