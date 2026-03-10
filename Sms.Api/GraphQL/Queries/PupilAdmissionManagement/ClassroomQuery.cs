using Sms.Core.Entities;
using Sms.Services.PupilAdmissionManagement;

namespace Sms.Api.GraphQL.Queries.PupilAdmissionManagement;

[ExtendObjectType("Query")]
public class ClassroomQuery
{
    // READ ALL
    public Task<IEnumerable<Classroom>> Classrooms(int id, [Service] ClassroomService service)
        => service.GetAllClassrooms(id);
    
    // READ ONE
    public Task<Classroom?> Classroom(int id, [Service] ClassroomService service)
        => service.GetClassroom(id);
}