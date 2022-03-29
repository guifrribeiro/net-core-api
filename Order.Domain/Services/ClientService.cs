using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
  public class ClientService : IClientService
  {
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
      _clientRepository = clientRepository;
    }

    public Task CreateAsync(ClientModel client)
    {
      throw new System.NotImplementedException();
    }

    public Task DeleteAsync(string clientId)
    {
      throw new System.NotImplementedException();
    }

    public Task<ClientModel> GetByIdAsync(string clientId)
    {
      throw new System.NotImplementedException();
    }

    public Task<List<ClientModel>> ListByFiltersAsync(string clientId = null, string name = null)
    {
      throw new System.NotImplementedException();
    }

    public Task UpdateAsync(ClientModel client)
    {
      throw new System.NotImplementedException();
    }
  }
}