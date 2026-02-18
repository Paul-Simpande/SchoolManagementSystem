using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class IntegrationStatusService : BaseActivatableService<IntegrationStatus>
{
    public IntegrationStatusService(
        IIntegrationStatusRepository repo,
        AuditLogService audit) : base(repo, audit){}
}