using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;

namespace Sms.Services.CoreTenant;

public class AcademicYearService
{
    private readonly IAcademicYearRepository _repo;
    private readonly AuditLogService _auditLogService;

    public AcademicYearService(IAcademicYearRepository repo, AuditLogService auditLogService)
    {
        _repo = repo;
        _auditLogService = auditLogService;
    }
    
    // CREATE
    public async Task<AcademicYear> CreateAcademicYear(AcademicYear academicYear, int? userId)
    {
        await _repo.AddAsync(academicYear);
        await _auditLogService.LogAsync(userId, 
            $"Created academic year '{academicYear.YearName}' (ID: {academicYear.AcademicYearId}) for school {academicYear.SchoolId}");

        
        return academicYear;
    }
    
    // READ ALL BY SCHOOL
    public async Task<IEnumerable<AcademicYear>> GetBySchool(int schoolId)
        => await _repo.GetBySchoolAsync(schoolId);
    
    // READ SINGLE
    public async Task<AcademicYear?> GetById(int id)
        => await _repo.GetByIdAsync(id);
    
    // UPDATE
    public async Task<AcademicYear?> UpdateAcademicYear(int id, AcademicYear updateAcademicYear, int? userId)
    {
        var academicYear = await _repo.GetByIdAsync(id);
        if (academicYear == null)
            throw new Exception("Academic year not found");
        
        academicYear.YearName = updateAcademicYear.YearName;
        academicYear.StartDate = updateAcademicYear.StartDate;
        academicYear.EndDate = updateAcademicYear.EndDate;
        academicYear.IsActive = updateAcademicYear.IsActive;
        
        await _repo.UpdateAsync(academicYear);
        
        await _auditLogService.LogAsync(userId, 
            $"Update academic year '{academicYear.YearName}' (ID: {academicYear.AcademicYearId}) for school {academicYear.SchoolId}");

        return academicYear;
    }
    
    // DELETE
    public async Task<bool> DeleteAcademicYear(int id, int? userId)
    {
        var academicYear = await _repo.GetByIdAsync(id);
        if (academicYear == null) return false;
        
        await _repo.DeleteAsync(academicYear);
        await _auditLogService.LogAsync(userId, 
            $"Deleted academic year '{academicYear.YearName}' (ID: {academicYear.AcademicYearId}) for school {academicYear.SchoolId}");

        
        return true;
    }
    
    // DEACTIVATE
    public async Task<bool> DeactivateAcademicYear(int id, int? userId)
    {
        var academicYear = await _repo.GetByIdAsync(id);
        if (academicYear == null) return false;

        var success = await _repo.DeactivateAsync(id);
        if (!success) return false;

        await _auditLogService.LogAsync(userId,
            $"Deactivated academic year '{academicYear.YearName}' (ID: {academicYear.AcademicYearId}) for school {academicYear.SchoolId}");

        return true;
    }
    
    // ACTIVATE
    public async Task<bool> ActivateAcademicYear(int id, int? userId)
    {
        var academicYear = await _repo.GetByIdAsync(id);
        if (academicYear == null) return false;

        var success = await _repo.ActivateAsync(id);
        if (!success) return false;

        await _auditLogService.LogAsync(userId,
            $"Activated academic year '{academicYear.YearName}' (ID: {academicYear.AcademicYearId}) for school {academicYear.SchoolId}");

        return true;
    }
}
