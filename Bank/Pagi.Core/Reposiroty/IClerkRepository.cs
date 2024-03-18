using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Reposiroty
{
    public interface IClerkRepository
    {
        Task<IEnumerable<Clerk>> GetListAsync();
        Task PostAsync(Clerk clerk);
        Task<Clerk> GetByIdAsync(int id);
        Task PutAsync(int id, Clerk value);
        Task DeleteAsync(int id);
    }
}
