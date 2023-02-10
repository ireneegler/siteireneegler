using System;
using SiteIreneEgler.Services;
using System.Linq;
using System.Collections.Generic;
using SiteIreneEgler.Data;
using SiteIreneEgler.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteIreneEgler.Services
{
    public class DepartamentService
    {
        private readonly SiteIreneEglerContext _context;
        public DepartamentService(SiteIreneEglerContext context)
        {
            _context = context;
        }
        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy
                (x => x.Name).ToListAsync();
        }
    }
}
