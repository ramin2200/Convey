using Ramin.MicroServices.Catelog.Application.DTO;
using System;
using System.Threading.Tasks;

namespace Ramin.MicroServices.Catelog.Application.Services.Clients
{
    public interface ICustomersServiceClient
    {
        Task<CustomerStateDto> GetStateAsync(Guid id);
    }
}