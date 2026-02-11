using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Services.Common;

namespace Sms.Services.NonStatusMaster;

public class GenderService : BaseActivatableService<Gender>
{
    public GenderService(
        IGenderRepository repo,
        AuditLogService audit)
        : base(repo, audit) { }
}
