using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROJETOFINAL_SalesWeb.Models;

namespace PROJETOFINAL_SalesWeb.Data
{
    public class PROJETOFINAL_SalesWebContext : DbContext
    {
        public PROJETOFINAL_SalesWebContext (DbContextOptions<PROJETOFINAL_SalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
