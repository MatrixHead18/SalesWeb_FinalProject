using PROJETOFINAL_SalesWeb.Data;
using PROJETOFINAL_SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROJETOFINAL_SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly PROJETOFINAL_SalesWebContext _context;

        public DepartmentService(PROJETOFINAL_SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
