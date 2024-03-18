using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Reposiroty
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetListAsync();
        Task PostAsync(Client client);
        Task PutAsync(int id, Client value);
        Task DeleteAsync(int id);
        Task<Client> GetByIdAsync(int id);

    }
}
