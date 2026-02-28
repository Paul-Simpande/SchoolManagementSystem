using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.Engine;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.Engine;

public class UserRoleRepository : IUserRoleRepository
{
    private readonly SchoolDbContext _context;

    public UserRoleRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task<UserRole?> GetByIdAsync(int id)
        => await _context.UserRoles
            .Include(ur => ur.User)
            .Include(ur => ur.Role)
            .FirstOrDefaultAsync(ur => ur.UserRoleId == id);

    public async Task<IEnumerable<UserRole>> GetAllAsync()
        => await _context.UserRoles
            .Include(ur => ur.User)
            .Include(ur => ur.Role)
            .ToListAsync();

    public async Task<IEnumerable<UserRole>> GetByUserIdAsync(int userId)
        => await _context.UserRoles
            .Include(ur => ur.Role)
            .Where(ur => ur.UserId == userId)
            .ToListAsync();

    public async Task<IEnumerable<UserRole>> GetByRoleIdAsync(int roleId)
        => await _context.UserRoles
            .Include(ur => ur.User)
            .Where(ur => ur.RoleId == roleId)
            .ToListAsync();

    public async Task<bool> AssignRoleAsync(int userId, int roleId)
    {
        var exists = await _context.UserRoles
            .AnyAsync(ur => ur.UserId == userId && ur.RoleId == roleId);

        if (exists)
            return false;

        var userRole = new UserRole
        {
            UserId = userId,
            RoleId = roleId
        };

        _context.UserRoles.Add(userRole);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> RemoveRoleAsync(int userId, int roleId)
    {
        var userRole = await _context.UserRoles
            .FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roleId);

        if (userRole == null)
            return false;

        _context.UserRoles.Remove(userRole);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UserHasRoleAsync(int userId, int roleId)
        => await _context.UserRoles
            .AnyAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
}