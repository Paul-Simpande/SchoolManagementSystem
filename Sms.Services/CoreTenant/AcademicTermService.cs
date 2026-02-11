using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;

namespace Sms.Services.CoreTenant;

public class AcademicTermService
{
    private readonly IAcademicTermRepository _repo;
    private readonly AuditLogService _auditLogService;

    public AcademicTermService(IAcademicTermRepository academicTermRepository, AuditLogService auditLogService)
    {
        _repo = academicTermRepository;
        _auditLogService = auditLogService;
    }
    
    // CREATE
    public async Task<AcademicTerm> CreateAcademicTerm(AcademicTerm academicTerm, int? userId)
    {
        await _repo.AddAsync(academicTerm);
        await _auditLogService.LogAsync(userId, $"Created academic term '{academicTerm.TermName}' (ID: {academicTerm.TermId}) for school year {academicTerm.AcademicYearId}");
        return academicTerm;
    }
    
    // READ ALL BY SCHOOL YEAR
    public async Task<IEnumerable<AcademicTerm>> GetByYear(int schoolYearId)
    {
        return await _repo.GetByAcademicYearAsync(schoolYearId);
    }
    
    // READ SINGLE
    public async Task<AcademicTerm?> GetById(int termId)
    {
        return await _repo.GetByIdAsync(termId);
    }
    
    // UPDATE
    public async Task<AcademicTerm> UpdateAcademicTerm(int id, AcademicTerm updatedAcademicTerm, int? userId)
    {
        var academicTerm = await _repo.GetByIdAsync(id);
        if (academicTerm == null) throw new Exception("Academic term not found");
        
        academicTerm.TermName = updatedAcademicTerm.TermName;
        academicTerm.StartDate = updatedAcademicTerm.StartDate;
        academicTerm.EndDate = updatedAcademicTerm.EndDate;
        academicTerm.IsActive = updatedAcademicTerm.IsActive;
        
        await _repo.UpdateAsync(academicTerm);
        await _auditLogService.LogAsync(userId, $"Updated academic term '{academicTerm.TermName}' (ID: {academicTerm.TermId}) for school year {academicTerm.AcademicYearId}");
        
        return academicTerm;
    }
    
    // DELETE
    public async Task<bool> DeleteAcademicTerm(int id, int? userId)
    {
        var academicTerm = await _repo.GetByIdAsync(id);
        if (academicTerm == null) throw new Exception("Academic term not found");
        
        await _repo.DeleteAsync(academicTerm);
        await _auditLogService.LogAsync(userId, $"Deleted academic term (ID: {id})");

        return true;
    }
    
    // DEACTIVATE
    public async Task<bool> DeactivateAcademicTerm(int id, int? userId)
    {
        var academicTerm = await _repo.GetByIdAsync(id);
        if (academicTerm == null) throw new Exception("Academic term not found");
        
        academicTerm.IsActive = false;
        await _repo.UpdateAsync(academicTerm);
        await _auditLogService.LogAsync(userId, $"Deactivated academic term (ID: {id})");

        return true;
    }
    
    // ACTIVATE
    public async Task<bool> ActivateAcademicTerm(int id, int? userId)
    {
        var academicTerm = await _repo.GetByIdAsync(id);
        if (academicTerm == null) throw new Exception("Academic term not found");
        
        academicTerm.IsActive = true;
        await _repo.UpdateAsync(academicTerm);
        await _auditLogService.LogAsync(userId, $"Activated academic term (ID: {id})");

        return true;
    }
}
