using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories;

public class AuditLogRepository : IAuditLogRepository
{
    private readonly SchoolDbContext _context;

    public AuditLogRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(AuditLog log)
    {
        await _context.AuditLogs.AddAsync(log);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<AuditLog>> GetAuditLogsAsync(int userId)
    {
        return await _context.AuditLogs.ToListAsync();
    }
}