using System.Data;
using online_store.Application.DTOs;
using online_store.Domain.Interfaces;

namespace online_store.Application.Services;

public class OrderService
{
    private readonly IProductRepository _productRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly IPaymentRepository _paymentRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public OrderService(
        IProductRepository productRepository,
        IOrderRepository orderRepository,
        IPaymentRepository paymentRepository,
        IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _orderRepository = orderRepository;
        _paymentRepository = paymentRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<bool> PlaceOrderAsync(PlaceOrderDTO orderDto)
    {
        // begin the transaction
        await using var transaction = await _unitOfWork.BeginTransactionAsync(IsolationLevel.Serializable);
        try
        {
            // the logic
            // 1. Check if the product exists & sufficient items are in stock
            await _unitOfWork.CommitAsync();
            return true;
        } catch (Exception ex)
        {
            await _unitOfWork.RollbackAsync();
            return false;
        }
    }
}