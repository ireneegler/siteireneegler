using Microsoft.AspNetCore.Mvc;
using SiteIreneEgler.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SiteIreneEgler.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Sobre";
            ViewData["Message"] = "Mensagem teste";
            ViewData["Mail"] = "teste@teste.com";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Página de contato.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
