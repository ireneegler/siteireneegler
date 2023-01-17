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

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
