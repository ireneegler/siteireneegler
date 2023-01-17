using Microsoft.AspNetCore.Mvc;
using SiteIreneEgler.Models;
using SiteIreneEgler.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace SiteIreneEgler.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
