using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class AttendanceStatusRepository
    : BaseActivatableRepository<AttendanceStatus>,
        IAttendanceStatusRepository
{
    public AttendanceStatusRepository(SchoolDbContext context)
        : base(context){}
}