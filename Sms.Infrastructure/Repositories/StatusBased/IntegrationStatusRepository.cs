using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class IntegrationStatusRepository :
    BaseActivatableRepository<IntegrationStatus>,
    IIntegrationStatusRepository
{
    public IntegrationStatusRepository(SchoolDbContext context)
        : base(context){}
}