using Sms.Core.Entities;

namespace Sms.Core.Interfaces;

public interface IAuditLogRepository
{
    Task AddAsync(AuditLog log);
    Task<IEnumerable<AuditLog>> GetAuditLogsAsync(int userId);
}