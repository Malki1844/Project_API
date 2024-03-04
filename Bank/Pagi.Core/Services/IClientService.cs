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
        Client GetId(int id);
        void Post(Client client);
        void Put(int id, Client value);
        void Delete(int id);
    }
}
