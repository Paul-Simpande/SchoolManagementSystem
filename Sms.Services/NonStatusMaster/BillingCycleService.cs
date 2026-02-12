using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Services.Common;

namespace Sms.Services.NonStatusMaster;

public class BillingCycleService : BaseActivatableService<BillingCycle>
{
    public BillingCycleService(
        IBillingCycleRepository repo,
        AuditLogService audit)
        : base(repo, audit){}
}