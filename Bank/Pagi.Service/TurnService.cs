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
        public Turn GetId(int id)
        {
          
            return _turnRepository.GetById(id);
        }
        public void Post(Turn date)
        {
            _turnRepository.Post(date);
        }
        public void Put(int id, Turn value)
        {
            _turnRepository.Put(id, value);
        }
        public void Delete(int id)
        {
            _turnRepository.Delete(id);
        }
    }
}
