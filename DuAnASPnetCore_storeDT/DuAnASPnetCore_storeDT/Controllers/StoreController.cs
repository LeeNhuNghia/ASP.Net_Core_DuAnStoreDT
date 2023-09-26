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
        public IActionResult PhanLoai(string idcat)
        {
            var obj = db.Products.Where(w => w.CategoryId == idcat).ToList();
            
            //var lstProduct = db.Products.ToList();
            return View(obj);
        }
        
    }
}
