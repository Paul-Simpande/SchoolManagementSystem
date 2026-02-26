using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.UserAccountManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.UserAccountManagement;

public class RoleRepository : IRoleRepository
{
    private readonly SchoolDbContext _context;

    public RoleRepository(SchoolDbContext context)
    {
        _context = context;
    }
    
    public async Task AddAsync(Role role)
    {
        _context.Roles.Add(role);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Role>> GetAllAsync()
    {
        return await _context.Roles
            .ToListAsync();
    }

    public async Task<Role?> GetByRoleIdAsync(int id)
        => await _context.Roles.FindAsync(id);

    public async Task UpdateAsync(Role role)
    {
        _context.Roles.Update(role);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Role role)
    {
        _context.Roles.Remove(role);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> RoleExistsAsync(string inputRole)
    {
        return await _context.Roles.AnyAsync(r => r.RoleName == inputRole);
    }
}