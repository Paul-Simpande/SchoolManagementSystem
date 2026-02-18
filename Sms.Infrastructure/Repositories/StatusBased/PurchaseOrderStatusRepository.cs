using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class PurchaseOrderStatusRepository
: BaseActivatableRepository<PurchaseOrderStatus>,
    IPurchaseOrderStatusRepository
{
    public PurchaseOrderStatusRepository(SchoolDbContext context)
        : base(context){}
}