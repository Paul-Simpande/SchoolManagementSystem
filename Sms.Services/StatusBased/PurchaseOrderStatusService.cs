using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class PurchaseOrderStatusService :
    BaseActivatableService<PurchaseOrderStatus>
{
    public PurchaseOrderStatusService(
        IPurchaseOrderStatusRepository repo,
        AuditLogService audit)
        : base(repo, audit){}
}