using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class UptimeStatusRepository :
    BaseActivatableRepository<UptimeStatus>,
    IUptimeStatusRepository
{
    public UptimeStatusRepository(SchoolDbContext context)
        : base(context){}
}