using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Services.Common;

namespace Sms.Services.StatusBased;

public class TicketStatusService : BaseActivatableService<TicketStatus>
{
    public TicketStatusService(
        ITicketStatusRepository repo,
        AuditLogService audit) : base(repo, audit){}
}