using Sms.Core.Entities;
using Sms.Core.Interfaces.UserAccountManagement;

namespace Sms.Services.UserAccountManagement;

public class RoleService
{
    private readonly IRoleRepository _repo;

    public RoleService(
        IRoleRepository repo)
    {
        _repo = repo;
    }
    
    //READ ALL
    public Task<IEnumerable<Role>> GetRoles()
        => _repo.GetAllAsync();
    
    // READ ONE BY ID
    public Task<Role?> GetRole(int id)
        => _repo.GetByRoleIdAsync(id);
}