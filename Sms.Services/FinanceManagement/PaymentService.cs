using Sms.Core.DTOs.inputs.FinanceManagement;
using Sms.Core.Entities;
using Sms.Core.Interfaces.FinanceManagement;

namespace Sms.Services.FinanceManagement;

public class PaymentService
{
    private readonly IPaymentRepository _repo;
    private readonly IInvoiceRepository _invoiceRepo;
    private readonly AuditLogService _audit;

    public PaymentService(
        IPaymentRepository repo,
        IInvoiceRepository invoiceRepo,
        AuditLogService audit)
    {
        _repo = repo;
        _invoiceRepo = invoiceRepo;
        _audit = audit;
    }

    // RECORD PAYMENT
    public async Task<Payment?> RecordPayment(PaymentInputs input, int? createdByUserId)
    {
        var invoice = await _invoiceRepo.GetById(input.InvoiceId);
        if (invoice == null) return null;

        var payment = new Payment
        {
            InvoiceId = input.InvoiceId,
            AcademicYearId = input.AcademicYearId,
            PaymentMethodId = input.PaymentMethodId,
            Amount = input.Amount,
            CreatedAt = DateTime.UtcNow
        };

        await _repo.AddAsync(payment);

        await _audit.LogAsync(
            createdByUserId,
            $"Recorded Payment '{payment.Amount}' for Invoice '{payment.InvoiceId}'");

        return payment;
    }

    // GET PAYMENTS BY INVOICE
    public Task<IEnumerable<Payment>> GetPaymentsByInvoice(int invoiceId)
        => _repo.GetByInvoice(invoiceId);

    // DELETE
    public async Task<bool> DeletePayment(int id, int? deletedByUserId)
    {
        var payment = await _repo.GetById(id);
        if (payment == null) return false;

        await _repo.DeleteAsync(payment);

        await _audit.LogAsync(
            deletedByUserId,
            $"Deleted Payment '{payment.PaymentId}'");

        return true;
    }
}