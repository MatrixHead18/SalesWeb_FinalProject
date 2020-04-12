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

        public DbSet<PROJETOFINAL_SalesWeb.Models.Department> Department { get; set; }
    }
}
