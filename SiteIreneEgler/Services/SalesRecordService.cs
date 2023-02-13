using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteIreneEgler.Data;
using SiteIreneEgler.Models;
using Microsoft.EntityFrameworkCore;

namespace SiteIreneEgler.Services
{
    public class SalesRecordService
    {
        private readonly SiteIreneEglerContext _context;
        public SalesRecordService(SiteIreneEglerContext context)
        {
            _context = context;
        }

        public SiteIreneEglerContext Get_context()
        {
            return _context;
        }

        public async Task<List<SalesRecord>> FindByDate(DateTime? minDate, DateTime? maxDate, SiteIreneEglerContext _context)
        {
            var result = from obj in _context.SalesRecords select obj;
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
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        internal Task FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            throw new NotImplementedException();
        }
    }
}
