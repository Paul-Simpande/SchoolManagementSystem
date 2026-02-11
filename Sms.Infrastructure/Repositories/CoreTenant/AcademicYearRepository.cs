using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.CoreTenant;


public class AcademicYearRepository : IAcademicYearRepository
{
    private readonly SchoolDbContext _context;

    public AcademicYearRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<AcademicYear?> GetByIdAsync(int id)
        => await _context.AcademicYears.FindAsync(id);

    public async Task<IEnumerable<AcademicYear>> GetBySchoolAsync(int schoolId)
        => await _context.AcademicYears
            .Where(y => y.SchoolId == schoolId)
            .ToListAsync();

    public async Task AddAsync(AcademicYear year)
    {
        _context.AcademicYears.Add(year);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AcademicYear year)
    {
        _context.AcademicYears.Update(year);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(AcademicYear year)
    {
        _context.AcademicYears.Remove(year);
        await _context.SaveChangesAsync();
    }
    
    
    public async Task<bool> DeactivateAsync(int id)
    {
        var year = await _context.AcademicYears.FindAsync(id);
        if (year == null) return false;
        if (year.IsActive == true)
        {
            year.IsActive = false;
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public async Task<bool> ActivateAsync(int id)
    {
        var year = await _context.AcademicYears.FindAsync(id);
        if (year == null) return false;
        if (year.IsActive == false)
        {
            year.IsActive = true;
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }
}
