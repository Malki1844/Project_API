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
        void PostAsync(Clerk clerk);
        Clerk GetById(int id);
        public void Put(int id, Clerk value);
        public void Delete(int id);
    }
}
