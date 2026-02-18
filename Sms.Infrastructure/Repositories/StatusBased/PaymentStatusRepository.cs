using Sms.Core.Entities;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;

namespace Sms.Infrastructure.Repositories.StatusBased;

public class PaymentStatusRepository 
    : BaseActivatableRepository<PaymentStatus>,
        IPaymentStatusRepository
{
    public PaymentStatusRepository(SchoolDbContext context)
        : base(context){}
}