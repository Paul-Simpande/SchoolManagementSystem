using Sms.Core.Entities;
using Sms.Services.FinanceManagement;

namespace Sms.Api.GraphQL.Queries.FinanceManagement;

[ExtendObjectType("Query")]
public class InvoiceQuery
{
    // GET STUDENT INVOICES
    public Task<IEnumerable<Invoice>> StudentInvoices(
        int studentId,
        [Service] InvoiceService service)
        => service.GetStudentInvoices(studentId);

    // GET ONE
    public Task<Invoice?> Invoice(
        int id,
        [Service] InvoiceService service)
        => service.GetInvoice(id);

    // GET OUTSTANDING
    public Task<IEnumerable<Invoice>> OutstandingInvoices(
        [Service] InvoiceService service)
        => service.GetOutstandingInvoices();
}