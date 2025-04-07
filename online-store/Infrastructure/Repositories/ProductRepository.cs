


using online_store.Domain.Entities;
using online_store.Domain.Interfaces;

public class ProductRepository : IProductRepository
{
    public Task<Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Product product)
    {
        throw new NotImplementedException();
    }
}