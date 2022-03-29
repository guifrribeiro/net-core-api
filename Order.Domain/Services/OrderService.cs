using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
  public class OrderService : IOrderService
  {
    public Task CreateAsync(OrderModel order)
    {
      throw new System.NotImplementedException();
    }

    public Task DeleteAsync(string orderId)
    {
      throw new System.NotImplementedException();
    }

    public Task<OrderModel> GetByIdAsync(string orderId)
    {
      throw new System.NotImplementedException();
    }

    public Task<List<OrderModel>> ListByFiltersAsync(string orderId = null, string clientId = null, string userId = null)
    {
      throw new System.NotImplementedException();
    }

    public Task UpdateAsync(OrderModel order)
    {
      throw new System.NotImplementedException();
    }
  }
}