using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {

        }

        public ModelContext(DbContextOptions opt) : base(opt) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }


        public DbSet<User> Users { get; set; }
    }

}
