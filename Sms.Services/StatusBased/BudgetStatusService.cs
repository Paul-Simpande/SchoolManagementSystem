using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class BudgetStatusService : BaseActivatableService<BudgetStatus>
{
    public BudgetStatusService(
        IBudgetStatusRepository repo,
        AuditLogService audit)
        : base(repo, audit){}
}