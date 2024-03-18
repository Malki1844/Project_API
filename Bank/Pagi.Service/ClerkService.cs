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
    public class ClerkService : IClerkService
    {
        private readonly IClerkRepository _clerksRepository;
        public ClerkService(IClerkRepository clerkRepository)
        {
            _clerksRepository = clerkRepository;
        }
        public async Task<IEnumerable<Clerk>> GetAllAsync()
        {
            return await _clerksRepository.GetListAsync();
        }
        public async Task<Clerk> GetIdAsync(int id)
        {
          //  int index = _clerksRepository.GetList().FindIndex(c => c.Id == id);
            return await _clerksRepository.GetByIdAsync(id);
        }
        public async Task PostAsync(Clerk clerk)
        {
           await _clerksRepository.PostAsync(clerk);
         //await   _clerksRepository.PostAsync(clerk);

        }
        public async Task PutAsync(int id, Clerk value)
        {
            await _clerksRepository.PutAsync(id, value);
            // _clerksRepository.GetById(id).Name=value.Name;
            //   _clerksRepository.GetList()[index].Name = value.Name;

        }
        public async Task DeleteAsync(int id)
        {
           await _clerksRepository.DeleteAsync(id);
         //   int index = _clerksRepository.GetList().ToList().FindIndex(c => c.Id == id);
         //_clerksRepository.GetList().ToList().Remove(_clerksRepository.GetList().ToList()[index]);
        }
    }
}
