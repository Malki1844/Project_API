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
       Task<Turn> GetIdAsync(int id);
        Task PutAsync(int id, Turn value);
        Task DeleteAsync(int id);
        Task PostAsync(Turn turn);
    }
}
