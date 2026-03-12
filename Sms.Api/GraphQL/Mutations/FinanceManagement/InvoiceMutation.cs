using Sms.Core.DTOs.inputs.FinanceManagement;
using Sms.Core.Entities;
using Sms.Services.FinanceManagement;

namespace Sms.Api.GraphQL.Mutations.FinanceManagement;

[ExtendObjectType("Mutation")]
public class InvoiceMutation
{
    // CREATE
    public Task<Invoice> CreateInvoice(
        InvoiceInputs input,
        int? createdByUserId,
        [Service] InvoiceService service)
        => service.CreateInvoice(input, createdByUserId);

    // DELETE
    public Task<bool> DeleteInvoice(
        int id,
        int? deletedByUserId,
        [Service] InvoiceService service)
        => service.DeleteInvoice(id, deletedByUserId);
}