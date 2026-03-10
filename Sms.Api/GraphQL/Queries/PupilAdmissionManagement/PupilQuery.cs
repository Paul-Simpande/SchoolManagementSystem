using Sms.Core.Entities;
using Sms.Services.PupilAdmissionManagement;

namespace Sms.Api.GraphQL.Queries.PupilAdmissionManagement;

[ExtendObjectType("Query")]
public class PupilQuery
{
    // GET ALL
    public Task<IEnumerable<Student>> Pupils(int id, [Service] PupilService service)
        => service.GetAllBySchool(id);
    
    // GET ONE
    public Task<Student?> Pupil(int id, [Service] PupilService service)
        => service.GetStudent(id);
}