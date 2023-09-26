using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuAnASPnetCore_storeDT.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAnASPnetCore_storeDT.Controllers
{
    public class StoreController : Controller
    {
        private readonly QLStoreCellPhoneContext db;

        public StoreController(QLStoreCellPhoneContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Smartphones()
        {
            return View();
        }

        public IActionResult Laptops()
        {
            return View();
        }

        public IActionResult Accessories()
        {
            return View();
        }
    }
}
