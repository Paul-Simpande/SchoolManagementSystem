using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class SupplierStatusService : BaseActivatableService<SupplierStatus>
{
    public SupplierStatusService(ISupplierStatusRepository repo,
        AuditLogService audit) : base(repo, audit){}
}