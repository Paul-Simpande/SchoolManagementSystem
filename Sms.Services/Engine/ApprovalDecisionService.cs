using Sms.Core.Entities;
using Sms.Core.Interfaces.Engine;
using Sms.Services.Common;

namespace Sms.Services.Engine;

public class ApprovalDecisionService : BaseActivatableService<ApprovalDecision>
{
    public ApprovalDecisionService(
        IApprovalDecisionRepository repo,
        AuditLogService audit) : base(repo, audit){}
}