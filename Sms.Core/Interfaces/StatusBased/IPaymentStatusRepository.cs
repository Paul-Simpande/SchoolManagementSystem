using Sms.Core.Entities;

namespace Sms.Core.Interfaces.StatusBased;

public interface IPaymentStatusRepository 
    : IBaseStatusRepository<PaymentStatus> { }