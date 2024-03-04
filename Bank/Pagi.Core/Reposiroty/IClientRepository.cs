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
        void Post(Client client);
        public void Put(int id, Client value);
        public void Delete(int index);
        public Client GetById(int id);  
    }
}
