using Pagi.Core.Models;
using Pagi.Core.Reposiroty;
using Pagi.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Service
{
    public class ClientService: IClientService
    {
        private readonly IClientRepository _clientsRepository;
        public ClientService(IClientRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }
        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _clientsRepository.GetListAsync();
        }
        public Client GetId(int id)
        {
            return _clientsRepository.GetById(id);

         
        }
        public void Post(Client client)
        {
            _clientsRepository.Post(client);
        }
        public void Put(int id, Client value) {
            _clientsRepository.Put(id, value);


          }
        public void Delete(int id)
        {
            //int index = _clientsRepository.GetList().ToList().FindIndex(x => x.Id == id);
            //if (index != -1)
            //    _clientsRepository.Delete(index);
            _clientsRepository.Delete(id);
        }
    }
}
