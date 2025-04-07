using online_store.Domain.Entities;

namespace online_store.Domain.Interfaces;

public interface IOrderRepository
{
    Task<Order?> AddAsync(Order order);
}