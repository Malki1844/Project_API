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
    public class TurnRepository: ITurnRepository
    {
        private readonly DataContext _context;
        public TurnRepository(DataContext context1)
        {
            _context=context1;
        }
        public async Task<IEnumerable<Turn>> GetListAsync()
        {
            return await _context.Turns.ToListAsync();
        }
        public Turn GetById(int id)
        {
            return _context.Turns.FirstOrDefault(x => x.Id==id);
        }
        public void Post(Turn turn)
        {
            _context.Turns.Add(turn);
            _context.SaveChangesAsync();
        }
        public void Put(int id, Turn turn)
        {
            _context.Turns.FirstOrDefault(x=>x.Id==id).Date= turn.Date;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var turn=_context.Turns.FirstOrDefault(x=>x.Id==id);
            if (turn!=null)
            {
                _context.Turns.Remove(turn);
                _context.SaveChanges();
            }
        }

    }
}
