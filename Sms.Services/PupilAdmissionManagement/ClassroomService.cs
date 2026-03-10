using Sms.Core.DTOs.inputs.PupilsAdmissionManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.PupilsAdmissionManagement;

namespace Sms.Services.PupilAdmissionManagement;

public class ClassroomService
{
    private readonly IClassroomRepository _repo;
    private readonly AuditLogService _audit;

    public ClassroomService(IClassroomRepository repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }
    
    // CREATE
    public async Task<Classroom> CreateClassroom(ClassroomInputs input, int? createdByUserId)
    {
        var classroom = new Classroom
        {
            SchoolId = input.SchoolId,
            AcademicYearId = input.AcademicYearId,
            ClassName = input.ClassroomName,
            Capacity = input.Capacity
        };

        await _repo.AddAsync(classroom);
        await _audit.LogAsync(
            createdByUserId,
            $"Creates Classroom '{classroom.ClassName}'");

        return classroom;
    }
    
    // READ ALL
    public Task<IEnumerable<Classroom>> GetAllClassrooms(int schoolId)
        => _repo.GetAllBySchoolAsync(schoolId);
    
    // READ ONE
    public Task<Classroom?> GetClassroom(int classroomId)
        => _repo.GetById(classroomId);
    
    public async Task<Classroom?> UpdateClassroom(int id, ClassroomInputs input, int? createdByUserId)
    {
        var classroom = await _repo.GetById(id);
        if (classroom == null) return null;
        
        classroom.SchoolId = input.SchoolId;
        classroom.AcademicYearId = input.AcademicYearId;
        classroom.ClassName = input.ClassroomName;
        classroom.Capacity = input.Capacity;
        
        await _repo.UpdateAsync(classroom);
        await _audit.LogAsync(
            createdByUserId,
            $"Updated Classroom '{classroom.ClassName}'");

        return classroom;
    }
    
    // DELETE
    public async Task<bool> DeleteClassroom(int classroomId, int? deletedByUserId)
    {
        var classroom = await _repo.GetById(classroomId);
        if (classroom == null) return false;

        await _repo.DeleteAsync(classroom);
        
        await _audit.LogAsync(
            deletedByUserId,
            $"Deleted Classroom '{classroom.ClassName}'");

        return true;
    }

}