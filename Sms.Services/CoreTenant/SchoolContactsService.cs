using Sms.Core.Entities;
using Sms.Core.Interfaces.CoreTenant;

namespace Sms.Services.CoreTenant;

public class SchoolContactsService
{
    private readonly ISchoolContactRepository _repo;
    private readonly AuditLogService _auditLogService;

    public SchoolContactsService(ISchoolContactRepository repo, AuditLogService auditLogService)
    {
        _repo = repo;
        _auditLogService = auditLogService;
    }
    
    // CREATE
    public async Task<SchoolContact> CreateSchoolService(SchoolContact schoolContact, int? userId)
    {
        await _repo.AddAsync(schoolContact);
        await _auditLogService.LogAsync(userId,
            $"Created school contact '{schoolContact.ContactType}'");

        return schoolContact;
    }
    
    // READ ALL BY SCHOOL
    public async Task<IEnumerable<SchoolContact>> GetBySchoolAsync(int schoolId)
        => await _repo.GetBySchoolAsync(schoolId);
    
    // READ SINGLE
    public async Task<SchoolContact?> GetById(int id)
        => await _repo.GetByIsAsync(id);
    
    // UPDATE
    public async Task<SchoolContact?> UpdateSchoolContact(int id, SchoolContact schoolContact, int? userId)
    {
        var schoolContext = await _repo.GetByIsAsync(id);
        if (schoolContext == null) throw new Exception("School Contact not found");
        
        schoolContext.ContactType = schoolContact.ContactType;
        schoolContext.ContactValue = schoolContact.ContactValue;
        await _repo.UpdateAsync(schoolContext);
        await _auditLogService.LogAsync(userId,
            $"Updated School Contact '{schoolContext.ContactId}' for School {schoolContext.SchoolId}");

        return schoolContact;
    }
    
    // DELETE
    public async Task<bool> DeleteSchoolContact(int id, int? userId)
    {
        var schoolContext = await _repo.GetByIsAsync(id);
        if (schoolContext == null) throw new Exception("School Contact not found");

        await _repo.DeleteAsync(schoolContext);
        await _auditLogService.LogAsync(userId,
            $"Deleted School Contact '{schoolContext.ContactId}' for School {schoolContext.SchoolId}");

        return true;
    }
    
}