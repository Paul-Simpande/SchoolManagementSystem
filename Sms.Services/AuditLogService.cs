using Sms.Core.Entities;
using Sms.Core.Interfaces;

namespace Sms.Services;

public class AuditLogService
{
    private readonly IAuditLogRepository _repo;

    public AuditLogService(IAuditLogRepository repo)
    {
        _repo = repo;
    }

    /// <summary>
    /// Logs an action performed by a user.
    /// </summary>
    /// <param name="userId">ID of the user performing the action</param>
    /// <param name="action">Description of the action</param>
    /// <returns></returns>
    public async Task LogAsync(int? userId, string action)
    {
        var log = new AuditLog
        {
            UserId = userId,
            Action = action,
            ActionTime = DateTime.UtcNow
        };

        await _repo.AddAsync(log);
    }

    public async Task<IEnumerable<AuditLog>> GetAuditLogs(int userId) => await _repo.GetAuditLogsAsync(userId);
}