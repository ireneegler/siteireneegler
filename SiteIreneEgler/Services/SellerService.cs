using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteIreneEgler.Data;
using SiteIreneEgler.Models;

namespace SiteIreneEgler.Services
{
    public class SellerService
    {
        private readonly SiteIreneEglerContext _context;
        public SellerService(SiteIreneEglerContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
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
