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
       Task<Turn> GetByIdAsync(int id);
        Task PostAsync(Turn turn);
        Task PutAsync(int id, Turn turn);
        Task DeleteAsync(int id);
    }
}
