using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.FinanceManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.FinanceManagement;

public class PaymentRepository : IPaymentRepository
{
    private readonly SchoolDbContext _context;

    public PaymentRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Payment payment)
    {
        _context.Payments.Add(payment);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Payment payment)
    {
        _context.Payments.Update(payment);
        await _context.SaveChangesAsync();
    }

    public async Task<Payment?> GetById(int paymentId)
        => await _context.Payments.FindAsync(paymentId);

    public async Task<IEnumerable<Payment>> GetByInvoice(int invoiceId)
        => await _context.Payments
            .Where(p => p.InvoiceId == invoiceId)
            .ToListAsync();

    public async Task<IEnumerable<Payment>> GetByStudent(int studentId)
        => await _context.Payments
            .Where(p => p.Invoice.StudentId == studentId)
            .ToListAsync();

    public async Task DeleteAsync(Payment payment)
    {
        payment.IsDeleted = true;
        payment.DeletedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }
}