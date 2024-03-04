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
    public class ClientRepository: IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context=context;
        }
        public async Task<IEnumerable<Client>> GetListAsync()
        {
            return await _context.Clients.Include(t=>t.turn).ToListAsync();
        }
        public void Post(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChangesAsync();
        }
        public void Put(int id, Client value)
        {
            _context.Clients.FirstOrDefault(x => x.Id == id).Name=value.Name;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
        public Client GetById(int id)
        {
            return _context.Clients.FirstOrDefault(x => x.Id==id);
            _context.SaveChanges();
        }
    }
}
