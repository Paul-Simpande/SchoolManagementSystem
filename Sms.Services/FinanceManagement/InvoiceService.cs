using Sms.Core.DTOs.inputs.FinanceManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.FinanceManagement;

namespace Sms.Services.FinanceManagement;

public class InvoiceService
{
    private readonly IInvoiceRepository _repo;
    private readonly AuditLogService _audit;

    public InvoiceService(IInvoiceRepository repo, AuditLogService audit)
    {
        _repo = repo;
        _audit = audit;
    }

    // CREATE INVOICE
    public async Task<Invoice> CreateInvoice(InvoiceInputs input, int? createdByUserId)
    {
        var invoice = new Invoice
        {
            StudentId = input.StudentId,
            AcademicYearId = input.AcademicYearId,
            StatusId = input.StatusId,
            CreatedAt = DateTime.UtcNow
        };

        await _repo.AddAsync(invoice);

        await _audit.LogAsync(
            createdByUserId,
            $"Created Invoice for Student '{invoice.StudentId}'");

        return invoice;
    }

    // GET BY STUDENT
    public Task<IEnumerable<Invoice>> GetStudentInvoices(int studentId)
        => _repo.GetByStudent(studentId);

    // GET ONE
    public Task<Invoice?> GetInvoice(int invoiceId)
        => _repo.GetById(invoiceId);

    // GET OUTSTANDING
    public Task<IEnumerable<Invoice>> GetOutstandingInvoices()
        => _repo.GetOutstandingInvoices();

    // DELETE
    public async Task<bool> DeleteInvoice(int id, int? deletedByUserId)
    {
        var invoice = await _repo.GetById(id);
        if (invoice == null) return false;

        await _repo.DeleteAsync(invoice);

        await _audit.LogAsync(
            deletedByUserId,
            $"Deleted Invoice '{invoice.InvoiceId}'");

        return true;
    }
}