using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class StudentStatusRepository
    : BaseActivatableRepository<StudentStatus>,
        IStudentStatusRepository
{
    public StudentStatusRepository(SchoolDbContext context)
        : base(context) { }
}
