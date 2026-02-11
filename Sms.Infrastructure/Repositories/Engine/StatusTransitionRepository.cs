using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Core.Interfaces.Engine;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.Engine;

public class StatusTransitionRepository : IStatusTransitionRepository
{
    private readonly SchoolDbContext _context;

    public StatusTransitionRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<StatusTransition?> GetByIdAsync(int id)
        => await _context.StatusTransitions.FindAsync(id);

    public async Task<IEnumerable<StatusTransition>> GetByDomainAsync(int domainId)
        => await _context.StatusTransitions
            .Where(t => t.DomainId == domainId)
            .ToListAsync();

    public Task AddAsync(StatusTransition transition)
    {
        _context.StatusTransitions.Add(transition);
        return _context.SaveChangesAsync();
    }

    public Task DeleteAsync(StatusTransition transition)
    {
        _context.StatusTransitions.Remove(transition);
        return _context.SaveChangesAsync();
    }
}