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
    public class TurnService: ITurnService
    {
        private readonly ITurnRepository _turnRepository ;
        public TurnService(ITurnRepository turnRepository)
        {
            _turnRepository = turnRepository;
        }
        public async Task<IEnumerable<Turn>> GetAllAsync()
        {
            return await _turnRepository.GetListAsync();
        }
        public async Task<Turn> GetIdAsync(int id)
        {
          
            return await _turnRepository.GetByIdAsync(id);
        }
        public async Task PostAsync(Turn date)
        {
           await _turnRepository.PostAsync(date);
        }
        public async Task PutAsync(int id, Turn value)
        {
           await _turnRepository.PutAsync(id, value);
        }
        public async Task DeleteAsync(int id)
        {
           await _turnRepository.DeleteAsync(id);
        }
    }
}
