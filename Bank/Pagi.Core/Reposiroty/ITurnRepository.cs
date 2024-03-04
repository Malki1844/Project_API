using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Reposiroty
{
    public interface ITurnRepository
    {
        Task<IEnumerable<Turn>> GetListAsync();
        Turn GetById(int id);
        public void Post(Turn turn);
        public void Put(int id, Turn turn);
        public void Delete(int id);
    }
}
