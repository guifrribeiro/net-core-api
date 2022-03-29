using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
  public class ProductService : IProductService
  {
    public Task CreateAsync(ProductModel product)
    {
      throw new System.NotImplementedException();
    }

    public Task DeleteAsync(string productId)
    {
      throw new System.NotImplementedException();
    }

    public Task<ProductModel> GetByIdAsync(string productId)
    {
      throw new System.NotImplementedException();
    }

    public Task<List<ProductModel>> ListByFiltersAsync(string productId = null, string description = null)
    {
      throw new System.NotImplementedException();
    }

    public Task UpdateAsync(ProductModel product)
    {
      throw new System.NotImplementedException();
    }
  }
}