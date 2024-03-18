using Microsoft.EntityFrameworkCore;
using Pagi.Core.Models;
using Pagi.Core.Reposiroty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Data.Repository
{
    public class ClerkRepository: IClerkRepository
    {
        private readonly DataContext _context;
        public ClerkRepository(DataContext context)
        {
            _context=context;
        }
        public async Task<IEnumerable<Clerk>> GetListAsync()
        {
            return await _context.Clerks.ToListAsync();
        }
        public async Task PostAsync(Clerk clerk)
        {
            _context.Clerks.Add(clerk);
          await  _context.SaveChangesAsync();
        }
        public async Task<Clerk> GetByIdAsync(int id)
        {

          return _context.Clerks.FirstOrDefault(x => x.Id==id);
          await  _context.SaveChangesAsync();
        }

        public async Task PutAsync(int id, Clerk value)
        {
            _context.Clerks.FirstOrDefault(x => x.Id == id).Name=value.Name;
          await  _context.SaveChangesAsync();
        }
        public  async Task DeleteAsync(int id)
        {
            var clerk = _context.Clerks.FirstOrDefault(x => x.Id == id);
            if (clerk != null)
            {
                _context.Clerks.Remove(clerk);
             await   _context.SaveChangesAsync();
            }
         
           
        }
        
    }
}
