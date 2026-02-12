using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class InvoiceStatusRepository 
    : BaseActivatableRepository<InvoiceStatus>,
    IInvoiceStatusRepository
{
    public InvoiceStatusRepository(SchoolDbContext context)
        : base(context){}
}