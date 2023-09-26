using DuAnASPnetCore_storeDT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnASPnetCore_storeDT.Controllers
{
    public class ProductController : Controller
    {
        private readonly QLStoreCellPhoneContext db;

        public ProductController(QLStoreCellPhoneContext _db)
        {
            db = _db;
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int idprd)
        {
            var detailprd = db.Products.Find(idprd);
            return View(detailprd);
        }

        
    }
}
