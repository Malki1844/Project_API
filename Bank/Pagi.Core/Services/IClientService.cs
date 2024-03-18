using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Services
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client> GetIdAsync(int id);
        Task PostAsync(Client client);
        Task PutAsync(int id, Client value);
        Task DeleteAsync(int id);
    }
}
