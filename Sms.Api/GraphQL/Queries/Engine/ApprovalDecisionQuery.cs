using Sms.Core.Entities;
using Sms.Services.Engine;

namespace Sms.Api.GraphQL.Queries.Engine;

[ExtendObjectType("Query")]
public class ApprovalDecisionQuery
{
    public Task<IEnumerable<ApprovalDecision>> GetApprovalDecisions([Service] ApprovalDecisionService service)
    {
        return service.GetAllAsync();
    }

    public Task<ApprovalDecision> GetApprovalDecision(int id, [Service] ApprovalDecisionService service)
    {
        return service.GetByIdAsync(id);
    }
}