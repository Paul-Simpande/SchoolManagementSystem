using Sms.Core.DTOs.inputs.PupilsAdmissionManagement;
using Sms.Core.Entities;
using Sms.Services.PupilAdmissionManagement;

namespace Sms.Api.GraphQL.Mutations.PupilAdmissionManagement;

[ExtendObjectType("Mutation")]
public class PupilsEnrollmentMutation
{
    // ENROLL STUDENT
    public Task<StudentEnrollment?> EnrollStudent(
        PupilsEnrollmentInputs input,
        int? approvedByUserId,
        [Service] PupilsEnrollmentService service)
        => service.EnrollStudent(input, approvedByUserId);

    // TRANSFER STUDENT
    public Task<StudentEnrollment?> TransferStudent(
        int enrollmentId,
        int newClassroomId,
        int? approvedByUserId,
        [Service] PupilsEnrollmentService service)
        => service.TransferStudent(enrollmentId, newClassroomId, approvedByUserId);

    // REMOVE ENROLLMENT
    public Task<bool> RemoveEnrollment(
        int enrollmentId,
        int? deletedByUserId,
        [Service] PupilsEnrollmentService service)
        => service.RemoveEnrollment(enrollmentId, deletedByUserId);
}