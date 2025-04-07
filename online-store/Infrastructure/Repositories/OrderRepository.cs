using online_store.Domain.Entities;
using online_store.Domain.Interfaces;
using online_store.Infrastructure.Contexts;

namespace online_store.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{    
    private readonly ECommerceDbContext _context;
    public OrderRepository(ECommerceDbContext context)
    {
        _context = context;
    }

    public async Task<Order?> AddAsync(Order order)
    {
        var createdOrder = await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
        return createdOrder.Entity;
    }
}