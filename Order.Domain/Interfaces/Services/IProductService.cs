using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IProductService
    {
         Task CreateAsync(ProductModel product);

         Task UpdateAsync(ProductModel product);

         Task DeleteAsync(string productId);

         Task<ProductModel> GetByIdAsync(string productId);

         Task<List<ProductModel>> ListByFiltersAsync(string productId = null, string description = null);
    }
}