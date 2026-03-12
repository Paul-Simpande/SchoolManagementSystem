using Sms.Core.Entities;

namespace Sms.Core.Interfaces.FinanceManagement;

public interface IInvoiceRepository
{
    Task AddAsync(Invoice invoice);

    Task UpdateAsync(Invoice invoice);

    Task<Invoice?> GetById(int invoiceId);

    Task<IEnumerable<Invoice>> GetByStudent(int studentId);

    Task<Invoice?> GetByStudentAndYear(int studentId, int academicYearId);

    Task<IEnumerable<Invoice>> GetOutstandingInvoices();

    Task DeleteAsync(Invoice invoice);
}