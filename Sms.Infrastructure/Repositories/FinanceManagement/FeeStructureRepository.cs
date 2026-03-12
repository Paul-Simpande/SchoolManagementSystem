using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.FinanceManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.FinanceManagement;

public class FeeStructureRepository : IFeeStructureRepository
{
    private readonly SchoolDbContext _context;

    public FeeStructureRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(FeeStructure feeStructure)
    {
        _context.FeeStructures.Add(feeStructure);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(FeeStructure feeStructure)
    {
        _context.FeeStructures.Update(feeStructure);
        await _context.SaveChangesAsync();
    }

    public async Task<FeeStructure?> GetById(int feeStructureId)
        => await _context.FeeStructures.FindAsync(feeStructureId);

    public async Task<IEnumerable<FeeStructure>> GetBySchool(int schoolId)
        => await _context.FeeStructures
            .Where(f => f.SchoolId == schoolId)
            .ToListAsync();

    public async Task<IEnumerable<FeeStructure>> GetByAcademicYear(int academicYearId)
        => await _context.FeeStructures
            .Where(f => f.AcademicYearId == academicYearId)
            .ToListAsync();

    public async Task DeleteAsync(FeeStructure feeStructure)
    {
        feeStructure.IsDeleted = true;
        feeStructure.DeletedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }
}