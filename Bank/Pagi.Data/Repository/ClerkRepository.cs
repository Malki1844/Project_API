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
        public async void PostAsync(Clerk clerk)
        {
            _context.Clerks.Add(clerk);
          await   _context.SaveChangesAsync();
        }
        public Clerk GetById(int id)
        {

          return _context.Clerks.FirstOrDefault(x => x.Id==id);
            _context.SaveChanges();
        }

        public void Put(int id, Clerk value)
        {
            _context.Clerks.FirstOrDefault(x => x.Id == id).Name=value.Name;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var clerk = _context.Clerks.FirstOrDefault(x => x.Id == id);
            if (clerk != null)
            {
                _context.Clerks.Remove(clerk);
                _context.SaveChanges();
            }
         
           
        }
        
    }
}
