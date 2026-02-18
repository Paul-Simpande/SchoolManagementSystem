using Sms.Core.Entities;
using Sms.Core.Interfaces.Engine;
using Sms.Infrastructure.Context;
using Sms.Infrastructure.Repositories.StatusBased;

namespace Sms.Infrastructure.Repositories.Engine;

public class ApprovalDecisionRepository : BaseActivatableRepository<ApprovalDecision>,
    IApprovalDecisionRepository
{
    public ApprovalDecisionRepository(SchoolDbContext context) : base(context){}
}