using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;


public class SchoolStatusRepository
    : BaseActivatableRepository<SchoolStatus>,
        ISchoolStatusRepository
{
    public SchoolStatusRepository(SchoolDbContext context)
        : base(context) { }
}
