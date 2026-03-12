using Sms.Core.Entities;
using Sms.Services.FinanceManagement;

namespace Sms.Api.GraphQL.Queries.FinanceManagement;

[ExtendObjectType("Query")]
public class PaymentQuery
{
    // GET PAYMENTS FOR AN INVOICE
    public Task<IEnumerable<Payment>> PaymentsByInvoice(
        int invoiceId,
        [Service] PaymentService service)
        => service.GetPaymentsByInvoice(invoiceId);
}