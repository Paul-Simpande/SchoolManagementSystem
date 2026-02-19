using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Services.Common;

namespace Sms.Services.NonStatusMaster;

public class SupplierTypeService : BaseCrudService<SupplierType>
{
    public SupplierTypeService(
        ISupplierTypeRepository repo,
        AuditLogService audit) : base(repo, audit){}
}