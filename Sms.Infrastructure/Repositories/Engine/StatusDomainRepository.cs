using Sms.Core.Entities;
using Sms.Core.Interfaces.Engine;
using Sms.Infrastructure.Context;
using Sms.Infrastructure.Repositories.StatusBased;

namespace Sms.Infrastructure.Repositories.Engine;

public class StatusDomainRepository
    : BaseActivatableRepository<StatusDomain>,
        IStatusDomainRepository
{
    public StatusDomainRepository(SchoolDbContext context)
        : base(context) { }
}
