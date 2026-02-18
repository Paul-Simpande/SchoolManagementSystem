using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class TicketStatusRepository :
    BaseActivatableRepository<TicketStatus>,
    ITicketStatusRepository
{
    public TicketStatusRepository(SchoolDbContext context)
        : base(context){}
}