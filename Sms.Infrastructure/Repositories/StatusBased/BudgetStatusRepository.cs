using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class BudgetStatusRepository
: BaseActivatableRepository<BudgetStatus>,
    IBudgetStatusRepository
{
    public BudgetStatusRepository(SchoolDbContext context)
        : base(context){}
}