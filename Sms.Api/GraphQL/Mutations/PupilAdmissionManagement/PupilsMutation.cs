using Sms.Core.DTOs.inputs.PupilsAdmissionManagement;
using Sms.Core.Entities;
using Sms.Services.PupilAdmissionManagement;

namespace Sms.Api.GraphQL.Mutations.PupilAdmissionManagement;

[ExtendObjectType("Mutation")]
public class PupilsMutation
{
    // CREATE
    public Task<Student> CreatePupil(PupilsInput input, int? createdByUserId, [Service] PupilService service)
        => service.CreateStudent(input, createdByUserId);
    
    // UPDATE
    public Task<Student?> UpdatePupil(int id, PupilsInput input, int? createdByUserId, [Service] PupilService service)
        => service.UpdateStudent(id, input, createdByUserId);
    
    // DELETE
    public Task<bool> DeleteUser(int id, int? userId, [Service] PupilService service)
        => service.DeleteStudent(id, userId);
}