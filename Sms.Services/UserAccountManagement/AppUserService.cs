using Sms.Core.DTOs.inputs.UserAccountManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.Engine;
using Sms.Core.Interfaces.UserAccountManagement;
using Sms.Services.Security;

namespace Sms.Services.UserAccountManagement;

public class AppUserService
{
    private readonly IAppUserRepository _repo;
    private readonly AuditLogService _auditLogService;

    public AppUserService(
        IAppUserRepository repo,
        AuditLogService auditLogService)
    {
        _repo = repo;
        _auditLogService = auditLogService;
    }

    // CREATE
    public async Task<AppUser> CreateUser(AppUserInput input, int? createdByUserId)
    {
        if (await _repo.EmailExistsAsync(input.Email))
            throw new Exception("Email already exists");

        var defaultPassword = "password";
        var hashedPassword = PasswordHasher.Hash(defaultPassword);

        var user = new AppUser
        {
            SchoolId = input.SchoolId,
            StatusId = input.StatusId,
            FirstName = input.FirstName,
            LastName = input.LastName,
            Email = input.Email,
            Phone = input.Phone,
            PasswordHash = hashedPassword,
            CreatedAt = DateTime.UtcNow,
            GenderId = input.GenderId
        };

        await _repo.AddAsync(user);

        await _auditLogService.LogAsync(
            createdByUserId,
            $"Created User '{user.Email}' (ID: {user.UserId}) with default password"
        );

        return user;
    }

    // READ ALL
    public Task<IEnumerable<AppUser>> GetUsers()
        => _repo.GetAllAsync();

    // READ ONE BY ID
    public Task<AppUser?> GetUser(int id)
        => _repo.GetByIdAsync(id);
    
    // READ ONE BY EMAIL
    public Task<AppUser?> GetUser(string email)
        => _repo.GetByEmailAsync(email);
    
    // READ ALL BY SCHOOL
    public Task<IEnumerable<AppUser>> GetUsers(int schoolId)
        => _repo.GetAllBySchool(schoolId);

    // UPDATE
    public async Task<AppUser?> UpdateUser(int id, AppUserInput input, int? userId)
    {
        var user = await _repo.GetByIdAsync(id);
        if (user == null) return null;

        user.FirstName = input.FirstName;
        user.LastName = input.LastName;
        user.Phone = input.Phone;
        user.StatusId = input.StatusId;
        user.GenderId = input.GenderId;

        await _repo.UpdateAsync(user);

        await _auditLogService.LogAsync(
            userId,
            $"Updated User '{user.Email} to new name' (ID: {user.UserId})"
        );

        return user;
    }

    // DELETE (SOFT DELETE)
    public async Task<bool> DeleteUser(int id, int? userId)
    {
        var user = await _repo.GetByIdAsync(id);
        if (user == null) return false;

        await _repo.DeleteAsync(user);

        await _auditLogService.LogAsync(
            userId,
            $"Deleted User '{user.Email}' (ID: {user.UserId})"
        );

        return true;
    }
    
    // LOGING METHOD
    public async Task<string> Login(
        string email,
        string password,
        IUserRoleRepository userRoleRepo,
        IRoleRepository roleRepo,
        JwtTokenService jwtService)
    {
        var user = await _repo.GetByEmailAsync(email);

        if (user == null)
            throw new Exception("Invalid email or password");

        if (!PasswordHasher.Verify(password, user.PasswordHash))
            throw new Exception("Invalid email or password");

        // 🔹 Get user's roles
        var userRoles = await userRoleRepo.GetByUserIdAsync(user.UserId);

        var roleNames = new List<string>();

        foreach (var ur in userRoles)
        {
            var role = await roleRepo.GetByRoleIdAsync(ur.RoleId);
            if (role != null)
                roleNames.Add(role.RoleName);
        }

        // 🔹 Generate token with roles
        return jwtService.GenerateToken(user, roleNames);
    }
}