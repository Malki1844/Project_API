using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Services
{
    public interface IClerkService
    {
        Task<IEnumerable<Clerk>> GetAllAsync();
       Task<Clerk> GetIdAsync(int id);
        Task PostAsync(Clerk clerk);
        Task PutAsync(int id, Clerk value);
        Task DeleteAsync(int id);
    }
}
