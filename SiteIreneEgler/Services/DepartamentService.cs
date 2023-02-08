using System;
using SiteIreneEgler.Services;
using System.Linq;
using System.Collections.Generic;
using SiteIreneEgler.Data;
using SiteIreneEgler.Models;

namespace SiteIreneEgler.Services
{
    public class DepartamentService
    {
        private readonly SiteIreneEglerContext _context;
        public DepartamentService(SiteIreneEglerContext context)
        {
            _context = context;
        }
        public List<Departament> FinAll()
        {
            return _context.Departament.OrderBy
                (x => x.Name).ToList();
        }

        internal object FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
