using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoySaloon.Models;

namespace BoySaloon.Data
{
    public class BoySaloonContext : DbContext
    {
        public BoySaloonContext (DbContextOptions<BoySaloonContext> options)
            : base(options)
        {
        }

        public DbSet<BoySaloon.Models.Product> Product { get; set; }

        public DbSet<BoySaloon.Models.Clients> Clients { get; set; }

        public DbSet<BoySaloon.Models.Saloon> Saloon { get; set; }
    }
}
