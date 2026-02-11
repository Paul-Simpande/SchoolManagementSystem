using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Infrastructure.Context;
using Sms.Infrastructure.Repositories.StatusBased;

namespace Sms.Infrastructure.Repositories.NonStatusMaster;

public class BillingCycleRepository
    : BaseActivatableRepository<BillingCycle>,
        IBillingCycleRepository
{
    public BillingCycleRepository(SchoolDbContext context)
        : base(context) { }
}
