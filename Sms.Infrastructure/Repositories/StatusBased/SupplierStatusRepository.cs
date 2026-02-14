using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class SupplierStatusRepository
: BaseActivatableRepository<SupplierStatus>,
    ISupplierStatusRepository
{
    public SupplierStatusRepository(SchoolDbContext context)
        : base(context){}
}