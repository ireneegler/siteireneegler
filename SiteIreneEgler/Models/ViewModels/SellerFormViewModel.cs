using System;
using System.Linq;
using System.Collections.Generic;


namespace SiteIreneEgler.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
