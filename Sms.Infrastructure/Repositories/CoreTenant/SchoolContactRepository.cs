using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.CoreTenant;

public class SchoolContactRepository : ISchoolContactRepository
{
    private readonly SchoolDbContext _context;

    public SchoolContactRepository(SchoolDbContext context)
    {
        _context = context;
    }


    public async Task<SchoolContact?> GetByIsAsync(int id)
        => await _context.SchoolContacts.FindAsync(id);

    public async Task<IEnumerable<SchoolContact>> GetBySchoolAsync(int schoolId)
        => await _context.SchoolContacts
            .Where(y => y.SchoolId == schoolId)
            .ToListAsync();

    public async Task AddAsync(SchoolContact schoolContact)
    {
        _context.SchoolContacts.Add(schoolContact);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SchoolContact schoolContact)
    {
        _context.SchoolContacts.Update(schoolContact);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(SchoolContact schoolContact)
    {
        _context.SchoolContacts.Remove(schoolContact);
        await _context.SaveChangesAsync();
    }
}