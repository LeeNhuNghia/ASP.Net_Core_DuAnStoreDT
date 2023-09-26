using DuAnASPnetCore_storeDT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnASPnetCore_storeDT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QLStoreCellPhoneContext db;

        public HomeController(ILogger<HomeController> logger, QLStoreCellPhoneContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index(string idcat)
        {
            var idTL = idcat == null ? "DT" : idcat;
            var lstCat = db.Products.Where(w => w.CategoryId == idTL).Take(5).ToList();
            return View(lstCat);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
