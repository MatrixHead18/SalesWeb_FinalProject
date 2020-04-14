using PROJETOFINAL_SalesWeb.Data;
using PROJETOFINAL_SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETOFINAL_SalesWeb.Services
{
    public class SellerService
    {
        private readonly PROJETOFINAL_SalesWebContext _context;

        public SellerService(PROJETOFINAL_SalesWebContext context)
        {
            _context = context;
        }

        public List<Seller>FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
