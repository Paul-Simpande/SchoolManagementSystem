using Sms.Core.DTOs.inputs.PupilsAdmissionManagement;
using Sms.Core.Entities;
using Sms.Services.PupilAdmissionManagement;

namespace Sms.Api.GraphQL.Mutations.PupilAdmissionManagement;

[ExtendObjectType("Mutation")]
public class ClassroomMutation
{
    // CREATE
    public Task<Classroom> CreateClassroom(ClassroomInputs input, int? createdByUserId,
        [Service] ClassroomService service)
        => service.CreateClassroom(input, createdByUserId);
    
    // UPDATE
    public Task<Classroom?> UpdateClassroom(int id, ClassroomInputs input, int? updatedByUserId,
        [Service] ClassroomService service)
        => service.UpdateClassroom(id, input, updatedByUserId);
    
    // DELETE
    public Task<bool> DeleteClassroom(int id, int? deletedBy, [Service] ClassroomService service)
        => service.DeleteClassroom(id, deletedBy);
}