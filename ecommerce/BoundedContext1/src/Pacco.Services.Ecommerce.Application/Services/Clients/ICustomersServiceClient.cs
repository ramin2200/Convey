using Pacco.Services.Ecommerce.Application.DTO;
using System;
using System.Threading.Tasks;

namespace Pacco.Services.Ecommerce.Application.Services.Clients
{
    public interface ICustomersServiceClient
    {
        Task<CustomerStateDto> GetStateAsync(Guid id);
    }
}