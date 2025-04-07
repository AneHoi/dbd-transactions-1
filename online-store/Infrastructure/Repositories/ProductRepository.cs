using online_store.Domain.Entities;
using online_store.Domain.Interfaces;
using online_store.Infrastructure.Contexts;

namespace online_store.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ECommerceDbContext _context;
    
    public ProductRepository(ECommerceDbContext context)
    {
        _context = context;
    }
    public async Task<Product?> GetByIdAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        return product; 
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }
}