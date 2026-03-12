using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;
using Sms.Core.Interfaces.FinanceManagement;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.FinanceManagement;

public class InvoiceRepository : IInvoiceRepository
{
    private readonly SchoolDbContext _context;

    public InvoiceRepository(SchoolDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Invoice invoice)
    {
        _context.Invoices.Add(invoice);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Invoice invoice)
    {
        _context.Invoices.Update(invoice);
        await _context.SaveChangesAsync();
    }

    public async Task<Invoice?> GetById(int invoiceId)
        => await _context.Invoices.FindAsync(invoiceId);

    public async Task<IEnumerable<Invoice>> GetByStudent(int studentId)
        => await _context.Invoices
            .Where(i => i.StudentId == studentId)
            .ToListAsync();

    public async Task<Invoice?> GetByStudentAndYear(int studentId, int academicYearId)
        => await _context.Invoices
            .FirstOrDefaultAsync(i =>
                i.StudentId == studentId &&
                i.AcademicYearId == academicYearId);

    public async Task<IEnumerable<Invoice>> GetOutstandingInvoices()
        => await _context.Invoices
            .Where(i => i.StatusId == 1) // example: Pending
            .ToListAsync();

    public async Task DeleteAsync(Invoice invoice)
    {
        invoice.IsDeleted = true;
        invoice.DeletedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }
}