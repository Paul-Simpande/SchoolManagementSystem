using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Infrastructure.Context;
using Sms.Infrastructure.Repositories.StatusBased;

namespace Sms.Infrastructure.Repositories.NonStatusMaster;

public class ErrorSeverityRepository : BaseActivatableRepository<BillingCycle>,
        IBillingCycleRepository
{
    public ErrorSeverityRepository(SchoolDbContext context)
        : base(context) { }
}
