using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SiteIreneEgler.Models;
using SiteIreneEgler.Services;

namespace SiteIreneEgler.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            var result = _salesRecordService.FindByDateAsync(minDate, maxDate);
            return View();
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
