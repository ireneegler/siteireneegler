using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteIreneEgler.Models;

namespace SiteIreneEgler.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletronics" });
            list.Add(new Departament { Id = 2, Name = "Games" });

            return View(list);
        }
    }
}
