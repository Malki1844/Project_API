using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Core.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Turn turn { get; set; }
        public int TurnId { get; set; }
        public List<Clerk> Clerks { get; set; }
      
    }
}
