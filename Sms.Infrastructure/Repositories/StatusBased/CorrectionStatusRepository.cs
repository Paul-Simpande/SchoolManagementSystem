using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class CorrectionStatusRepository :
    BaseActivatableRepository<CorrectionStatus>,
    ICorrectionStatusRepository
{
    public CorrectionStatusRepository(SchoolDbContext context)
        : base(context){}
}