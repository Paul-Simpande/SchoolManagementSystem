using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.CoreTenant;


public class SchoolRepository : ISchoolRepository
{
    private readonly SchoolDbContext _context;

    public SchoolRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<School>> GetAllAsync()
        => await _context.Schools.ToListAsync();

    public async Task<School?> GetByIdAsync(int id)
        => await _context.Schools.FindAsync(id);

    public async Task AddAsync(School school)
    {
        _context.Schools.Add(school);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(School school)
    {
        _context.Schools.Update(school);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(School school)
    {
        _context.Schools.Remove(school);
        await _context.SaveChangesAsync();
    }
}
