using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.NonStatusMaster;

public class SupplierTypeRepository : ISupplierTypeRepository
{
    private readonly SchoolDbContext _context;

    public SupplierTypeRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<SupplierType?> GetByIdAsync(int id)
        => await _context.SupplierTypes.FindAsync(id);

    public async Task<IEnumerable<SupplierType>> GetAllAsync()
        => await _context.SupplierTypes.ToListAsync();

    public Task AddAsync(SupplierType supplierType)
    {
        _context.SupplierTypes.Add(supplierType);
        return _context.SaveChangesAsync();
    }

    public Task UpdateAsync(SupplierType supplierType)
    {
        _context.SupplierTypes.Update(supplierType);
        return _context.SaveChangesAsync();
    }

    public Task DeleteAsync(SupplierType supplierType)
    {
        _context.SupplierTypes.Remove(supplierType);
        return _context.SaveChangesAsync();
    }
}
