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
        public async Task<Turn> GetByIdAsync(int id)
        {
           
            return  _context.Turns.FirstOrDefault(x => x.Id==id);
             await _context.SaveChangesAsync();
        }
        public async Task PostAsync(Turn turn)
        {
            _context.Turns.Add(turn);
           await _context.SaveChangesAsync();
        }
        public async Task PutAsync(int id, Turn turn)
        {
            _context.Turns.FirstOrDefault(x=>x.Id==id).Date= turn.Date;
          await  _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var turn=_context.Turns.FirstOrDefault(x=>x.Id==id);
            if (turn!=null)
            {
                _context.Turns.Remove(turn);
              await  _context.SaveChangesAsync();
            }
        }

    }
}
