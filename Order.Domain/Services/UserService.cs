using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
  public class UserService : IUserService
  {
    public Task<bool> AuthenticationAsync(UserModel user)
    {
      throw new System.NotImplementedException();
    }

    public Task CreateAsync(UserModel user)
    {
      throw new System.NotImplementedException();
    }

    public Task DeleteAsync(string userId)
    {
      throw new System.NotImplementedException();
    }

    public Task<UserModel> GetByIdAsync(string userId)
    {
      throw new System.NotImplementedException();
    }

    public Task<List<UserModel>> ListByFiltersAsync(string userId = null, string name = null)
    {
      throw new System.NotImplementedException();
    }

    public Task UpdateAsync(UserModel user)
    {
      throw new System.NotImplementedException();
    }
  }
}