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
        Clerk GetId(int id);
        void PostAsync(Clerk clerk);
        void Put(int id, Clerk name);
        void Delete(int id);
    }
}
