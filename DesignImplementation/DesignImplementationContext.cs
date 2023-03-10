using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignImplementation
{
    public class DesignImplementationContext : DbContext
    {
        public DesignImplementationContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = DesignImplement; Trusted_Connection = True");
        }

        public DbSet<Person> Person { get; set; }
    }
}
