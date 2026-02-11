using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;

namespace Sms.Services.CoreTenant;

public class SchoolService
{
    private readonly ISchoolRepository _repo;
    private readonly AuditLogService _auditLogService;

    public SchoolService(ISchoolRepository repo, AuditLogService auditLogService)
    {
        _repo = repo;
        _auditLogService = auditLogService;
    }

    // CREATE
    public async Task<School> CreateSchool(School school, int? userId)
    {
        await _repo.AddAsync(school);
        await _auditLogService.LogAsync(userId,$"Created School '{school.SchoolName}' (ID: {school.SchoolId}) ");
        return school;
    }

    // READ ALL
    public Task<IEnumerable<School>> GetSchools() => _repo.GetAllAsync();

    // READ SINGLE
    public Task<School?> GetSchool(int id) => _repo.GetByIdAsync(id);

    // UPDATE
    public async Task<School?> UpdateSchool(int id, School updatedSchool, int? userId)
    {
        var school = await _repo.GetByIdAsync(id);
        if (school == null) return null;

        // update fields
        school.SchoolName = updatedSchool.SchoolName;
        school.EmisNumber = updatedSchool.EmisNumber;
        school.EczCenterNumber = updatedSchool.EczCenterNumber;
        school.SchoolType = updatedSchool.SchoolType;
        school.Website = updatedSchool.Website;
        school.Address = updatedSchool.Address;
        school.District = updatedSchool.District;
        school.Province = updatedSchool.Province;
        school.Country = updatedSchool.Country;
        school.StatusId = updatedSchool.StatusId;

        await _repo.UpdateAsync(school);
        await _auditLogService.LogAsync(userId,$"Updated School '{school.SchoolName}' (ID: {school.SchoolId}) ");
        return school;
    }

    // DELETE
    public async Task<bool> DeleteSchool(int id, int? userId)
    {
        var school = await _repo.GetByIdAsync(id);
        if (school == null) return false;

        await _repo.DeleteAsync(school);
        await _auditLogService.LogAsync(userId,$"Deleted School '{school.SchoolName}' (ID: {school.SchoolId}) ");
        return true;
    }
}