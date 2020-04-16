using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROJETOFINAL_SalesWeb.Data;
using PROJETOFINAL_SalesWeb.Models;
using Microsoft.EntityFrameworkCore;
namespace PROJETOFINAL_SalesWeb.Services
{
    public class SalesRecordsService
    {
        private readonly PROJETOFINAL_SalesWebContext _context;

        public SalesRecordsService(PROJETOFINAL_SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x=> x.Seller.Department)
                .ToListAsync();
        }
    }
}
