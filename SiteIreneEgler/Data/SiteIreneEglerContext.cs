using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteIreneEgler.Models;

namespace SiteIreneEgler.Data
{
    public class SiteIreneEglerContext : DbContext
    {
        public SiteIreneEglerContext (DbContextOptions<SiteIreneEglerContext> options)
            : base(options)
        {
        }

        public DbSet<SiteIreneEgler.Models.Departament> Departament { get; set; }
    }
}
