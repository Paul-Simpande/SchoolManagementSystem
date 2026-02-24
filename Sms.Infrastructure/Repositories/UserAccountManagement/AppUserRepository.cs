using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.UserAccountManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.UserAccountManagement;

public class AppUserRepository : IAppUserRepository
{
    private readonly SchoolDbContext _context;

    public AppUserRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(AppUser user)
    {
        _context.AppUsers.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<AppUser>> GetAllBySchool(int schoolId)
        => await _context.AppUsers
            .Where(y => y.SchoolId == schoolId)
            .ToListAsync();

    public async Task<AppUser?> GetByIdAsync(int id)
        => await _context.AppUsers.FindAsync(id);

    public async Task<IEnumerable<AppUser>> GetAllAsync()
    {
        return await _context.AppUsers
            .Where(u => u.IsDeleted == false)
            .ToListAsync();
    }

    public async Task UpdateAsync(AppUser user)
    {
        _context.AppUsers.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(AppUser user)
    {
        user.IsDeleted = true;
        user.DeletedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
    }

    public async Task<bool> EmailExistsAsync(string email)
    {
        return await _context.AppUsers.AnyAsync(u => u.Email == email && u.IsDeleted == false);
    }

    public async Task<AppUser?> GetByEmailAsync(string email)
    {
        return await _context.AppUsers
            .FirstOrDefaultAsync(x => x.Email == email && x.IsDeleted == false);
    }
}