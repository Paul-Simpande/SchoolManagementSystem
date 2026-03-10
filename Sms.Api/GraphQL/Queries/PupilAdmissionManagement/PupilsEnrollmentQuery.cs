using Sms.Core.Entities;
using Sms.Services.PupilAdmissionManagement;

namespace Sms.Api.GraphQL.Queries.PupilAdmissionManagement;

[ExtendObjectType("Query")]
public class PupilsEnrollmentQuery
{
    // GET STUDENT ENROLLMENT HISTORY
    public Task<IEnumerable<StudentEnrollment>> StudentEnrollmentHistory(
        int studentId,
        [Service] PupilsEnrollmentService service)
        => service.GetStudentHistory(studentId);

    // GET STUDENTS IN CLASS
    public Task<IEnumerable<StudentEnrollment>> StudentsInClass(
        int classroomId,
        [Service] PupilsEnrollmentService service)
        => service.GetStudentsInClass(classroomId);
}