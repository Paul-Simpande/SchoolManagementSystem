using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.CoreTenant;

public class AcademicTermRepository : IAcademicTermRepository
{
    private readonly SchoolDbContext _context;
    
    public AcademicTermRepository(SchoolDbContext context)
    {
        _context = context;
    }
    
    public async Task<AcademicTerm?> GetByIdAsync(int id)
        => await _context.AcademicTerms.FindAsync(id);

    public async Task<IEnumerable<AcademicTerm>> GetByAcademicYearAsync(int academicYearId)
        => await _context.AcademicTerms
            .Where(y => y.AcademicYearId == academicYearId)
            .ToListAsync();

    public Task AddAsync(AcademicTerm term)
    {
        _context.AcademicTerms.Add(term);
        return _context.SaveChangesAsync();
    }

    public Task UpdateAsync(AcademicTerm term)
    {
        _context.AcademicTerms.Update(term);
        return _context.SaveChangesAsync();
    }

    public Task DeleteAsync(AcademicTerm term)
    {
        _context.AcademicTerms.Remove(term);
        return _context.SaveChangesAsync();
    }

    public async Task<bool> ActivateAsync(int id)
    {
        var term = await _context.AcademicTerms.FindAsync(id);
        if (term == null) return false;
        if (term.IsActive == false)
        {
            term.IsActive = true;
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<bool> DeactivateAsync(int id)
    {
        var term = await _context.AcademicTerms.FindAsync(id);
        if (term == null) return false;
        if (term.IsActive == true)
        {
            term.IsActive = false;
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }
}