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
        public Clerk GetId(int id)
        {
          //  int index = _clerksRepository.GetList().FindIndex(c => c.Id == id);
            return _clerksRepository.GetById(id);
        }
        public void PostAsync(Clerk clerk)
        {
            _clerksRepository.PostAsync(clerk);
         //await   _clerksRepository.PostAsync(clerk);

        }
        public void Put(int id, Clerk value)
        {
            _clerksRepository.Put(id, value);
            // _clerksRepository.GetById(id).Name=value.Name;
            //   _clerksRepository.GetList()[index].Name = value.Name;

        }
        public void Delete(int id)
        {
            _clerksRepository.Delete(id);
         //   int index = _clerksRepository.GetList().ToList().FindIndex(c => c.Id == id);
         //_clerksRepository.GetList().ToList().Remove(_clerksRepository.GetList().ToList()[index]);
        }
    }
}
