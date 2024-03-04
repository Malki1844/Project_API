using Microsoft.EntityFrameworkCore;
using Pagi.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagi.Data
{

    public class DataContext:DbContext
    {
       
        public DbSet<Clerk> Clerks { get; set; }
        public DbSet<Turn> Turns { get; set; }
        public DbSet<Client> Clients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
            optionsBuilder.LogTo(massage=>Debug.WriteLine(massage));
        }

    }
}
