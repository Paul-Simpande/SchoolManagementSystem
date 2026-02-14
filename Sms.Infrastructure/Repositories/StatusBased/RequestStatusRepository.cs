using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class RequestStatusRepository
    : BaseActivatableRepository<RequestStatus>,
        IRequestStatusRepository
{
    public RequestStatusRepository(SchoolDbContext context)
        : base(context){}
}