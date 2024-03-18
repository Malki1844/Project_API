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
        public async Task<Client> GetIdAsync(int id)
        {
            return await _clientsRepository.GetByIdAsync(id);

         
        }
        public async Task PostAsync(Client client)
        {
           await _clientsRepository.PostAsync(client);
        }
        public async Task PutAsync(int id, Client value) {
         await   _clientsRepository.PutAsync(id, value);


          }
        public async Task DeleteAsync(int id)
        {
            //int index = _clientsRepository.GetList().ToList().FindIndex(x => x.Id == id);
            //if (index != -1)
            //    _clientsRepository.Delete(index);
          await  _clientsRepository.DeleteAsync(id);
        }
    }
}
