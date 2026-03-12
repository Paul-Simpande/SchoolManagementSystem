using Sms.Core.DTOs.inputs.FinanceManagement;
using Sms.Core.Entities;
using Sms.Services.FinanceManagement;

namespace Sms.Api.GraphQL.Mutations.FinanceManagement;

[ExtendObjectType("Mutation")]
public class PaymentMutation
{
    // RECORD PAYMENT
    public Task<Payment?> RecordPayment(
        PaymentInputs input,
        int? createdByUserId,
        [Service] PaymentService service)
        => service.RecordPayment(input, createdByUserId);

    // DELETE
    public Task<bool> DeletePayment(
        int id,
        int? deletedByUserId,
        [Service] PaymentService service)
        => service.DeletePayment(id, deletedByUserId);
}