using Sms.Core.Entities;
using Sms.Services;

namespace Sms.Api.GraphQL.Queries;

[ExtendObjectType("Query")]
public class AuditLogQuery
{
    // Get all By UserID
    public Task<IEnumerable<AuditLog>> AuditLogs(int id, [Service] AuditLogService service)
    => service.GetAuditLogs(id);
}