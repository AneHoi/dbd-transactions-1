using online_store.Domain.Entities;
using online_store.Domain.Interfaces;
using online_store.Infrastructure.Contexts;

namespace online_store.Infrastructure.Repositories;

public class PaymentRepository : IPaymentRepository
{
    private readonly ECommerceDbContext _context;
    public PaymentRepository(ECommerceDbContext context)
    {
        _context = context;
    }
    public async Task<Payment?> AddAsync(Payment payment)
    {
        var paymentCreated = await _context.Payments.AddAsync(payment);
        await _context.SaveChangesAsync();
        return paymentCreated.Entity;
    }
}