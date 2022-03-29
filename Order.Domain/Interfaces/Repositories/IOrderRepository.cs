using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
         Task CreateAsync(OrderModel order);

         Task UpdateAsync(OrderModel order);

         Task DeleteAsync(string orderId);

         Task<OrderModel> GetByIdAsync(string orderId);

         Task<List<OrderModel>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null);

         Task CreateItemAsync(OrderItemModel item);

         Task UpdateItemAsync(OrderItemModel item);

         Task DeleteItemAsync(string itemId);

         Task<List<OrderItemModel>> ListItemByOrderIdAsync(string orderId);

         Task<bool> ExistByIdAsync(string orderId);
    }
}