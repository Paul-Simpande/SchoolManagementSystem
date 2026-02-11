using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.NonStatusMaster;


public class DayOfWeekRepository : IDayOfWeekRepository
{
    private readonly SchoolDbContext _context;

    public DayOfWeekRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<DayOfWeeks?> GetByIdAsync(int id)
        => await _context.DayOfWeeks.FindAsync(id);

    public async Task<List<DayOfWeeks>> GetAllAsync()
        => await _context.DayOfWeeks.ToListAsync();

    public Task AddAsync(DayOfWeeks dayOfWeek)
    {
        _context.DayOfWeeks.Add(dayOfWeek);
        return _context.SaveChangesAsync();
    }

    public Task UpdateAsync(DayOfWeeks dayOfWeek)
    {
        _context.DayOfWeeks.Update(dayOfWeek);
        return _context.SaveChangesAsync();
    }

    public Task DeleteAsync(DayOfWeeks dayOfWeek)
    {
        _context.DayOfWeeks.Remove(dayOfWeek);
        return _context.SaveChangesAsync();
    }
}
