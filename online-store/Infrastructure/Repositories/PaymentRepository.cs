using online_store.Domain.Entities;
using online_store.Domain.Interfaces;

namespace online_store.Infrastructure.Repositories;

public class PaymentRepository : IPaymentRepository
{
    
    public Task AddAsync(Payment payment)
    {
        throw new NotImplementedException();
    }

    public Task<Payment> FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Task SaveNewPayment(Payment payment)
    {
        throw new NotImplementedException();
    }
}