using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=Desktop-G46VU0J; Database=WriterDb; Trusted_Connection=true");
        }
        public DbSet<Writer> Writer { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}
