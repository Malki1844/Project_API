using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Services
{
    public interface ITurnService
    {
        Task<IEnumerable<Turn>> GetAllAsync();
        Turn GetId(int id);
        void Put(int id, Turn value);
        void Delete(int id);
        void Post(Turn turn);
    }
}
