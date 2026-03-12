using Sms.Core.Entities;

namespace Sms.Core.Interfaces.FinanceManagement;

public interface IPaymentRepository
{
    Task AddAsync(Payment payment);

    Task UpdateAsync(Payment payment);

    Task<Payment?> GetById(int paymentId);

    Task<IEnumerable<Payment>> GetByInvoice(int invoiceId);

    Task<IEnumerable<Payment>> GetByStudent(int studentId);

    Task DeleteAsync(Payment payment);
}