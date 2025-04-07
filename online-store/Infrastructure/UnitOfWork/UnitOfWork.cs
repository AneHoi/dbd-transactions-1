using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using online_store.Domain.Interfaces;
using online_store.Infrastructure.Contexts;

namespace online_store.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ECommerceDbContext _context;
    private IDbContextTransaction? _transaction;

    public UnitOfWork(ECommerceDbContext context)
    {
        _context = context;
    }
    
    public async Task<IDbContextTransaction?> BeginTransactionAsync(IsolationLevel isolationLevel)
    {
        _transaction = await _context.Database.BeginTransactionAsync(isolationLevel);
        return _transaction;
    }

    public async Task CommitAsync()
    {
        if (_transaction == null)
        {
            throw new InvalidOperationException("Transaction has not been started.");
        }
        await _transaction.CommitAsync();
        await _transaction.DisposeAsync();
    }

    public async Task RollbackAsync()
    {
        if(_transaction == null)
        {
            throw new InvalidOperationException("Transaction has not been started.");
        }
        await _transaction.RollbackAsync();
        await _transaction.DisposeAsync();
    }
}   