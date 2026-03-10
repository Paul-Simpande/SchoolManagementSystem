using Sms.Core.DTOs.inputs.PupilsAdmissionManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.PupilsAdmissionManagement;

namespace Sms.Services.PupilAdmissionManagement;

public class PupilService
{
    private readonly IPupilRepository _repo;
    private readonly AuditLogService _audit;

    public PupilService(IPupilRepository repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }
    
    //CREATE
    public async Task<Student> CreateStudent(PupilsInput input, int? createdByUserId)
    {
        var pupil = new Student
        {
            SchoolId = input.SchoolId,
            GenderId = input.GenderId,
            StatusId = input.StatusId,
            AdmissionNumber = input.AdmissionNumber,
            SchoolAssignedNumber = input.SchoolAssignedNumber,
            EczExamNumber = input.EczExamNumber,
            FirstName = input.FirstName,
            LastName = input.LastName,
            DateOfBirth = input.DateOfBirth,
            CreatedAt = DateTime.UtcNow
        };

        await _repo.AddAsync(pupil);

        await _audit.LogAsync(
            createdByUserId,
            $"Created Pupil '{pupil.FirstName}' '{pupil.LastName}'");

        return pupil;
    }
    
    //READ ALL
    public Task<IEnumerable<Student>> GetAllBySchool(int schoolId)
        => _repo.GetAllBySchool(schoolId);
    
    // GET ONE BY USER
    public Task<Student?> GetStudent(int id)
        => _repo.GetByUser(id);
    
    // Update
    public async Task<Student?> UpdateStudent(int id, PupilsInput input, int? createdByUserId)
    {
        var pupil = await _repo.GetByUser(id);
        if (pupil == null) return null;
        
        pupil.SchoolId = input.SchoolId;
        pupil.GenderId = input.GenderId;
        pupil.StatusId = input.StatusId;
        pupil.AdmissionNumber = input.AdmissionNumber;
        pupil.SchoolAssignedNumber = input.SchoolAssignedNumber;
        pupil.EczExamNumber = input.EczExamNumber;
        pupil.FirstName = input.FirstName;
        pupil.LastName = input.LastName;
        pupil.DateOfBirth = input.DateOfBirth;

        await _repo.UpdateAsync(pupil);

        await _audit.LogAsync(
            createdByUserId,
            $"Updated Pupil '{pupil.FirstName}' '{pupil.LastName}'");

        return pupil;
    }
    
    // DELETE
    public async Task<bool> DeleteStudent(int id, int? userId)
    {
        var pupil = await _repo.GetByUser(id);
        if (pupil == null) return false;

        await _repo.DeleteAsync(pupil);

        await _audit.LogAsync(
            userId,
            $"Deleted Pupil '{pupil.FirstName}' '{pupil.LastName}'");

        return true;
    }
}