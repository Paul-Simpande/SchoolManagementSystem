using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.NonStatusMaster;


public class GenderRepository : IGenderRepository
{
    private readonly SchoolDbContext _context;

    public GenderRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<Gender?> GetByIdAsync(int id)
        => await _context.Genders.FindAsync(id);

    public async Task<IEnumerable<Gender>> GetAllAsync()
        => await _context.Genders.ToListAsync();

    public Task AddAsync(Gender gender)
    {
        _context.Genders.Add(gender);
        return _context.SaveChangesAsync();
    }

    public Task UpdateAsync(Gender gender)
    {
        _context.Genders.Update(gender);
        return _context.SaveChangesAsync();
    }

    public Task DeleteAsync(Gender gender)
    {
        _context.Genders.Remove(gender);
        return _context.SaveChangesAsync();
    }
}
