using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        protected DatabaseContext db;
        public ProductController(DatabaseContext _db)
        {
            db = _db;
            // db = new DatbaseContext();
        }
        public IActionResult Index()
        {
            // List<Product> data = db.Products.ToList();
            //  List<Product> data = db.Products.Where(p => p.ProductId > 0).Select(p => p).Take(10).ToList();

            List<Product> data = (from prd in db.Products
                                  where prd.ProductId > 0
                                  select prd).Take(10).ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            ViewBag.CategoryList = db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            ModelState.Remove("ProductId");
            if (ModelState.IsValid)
            {
                db.Products.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            ViewBag.CategoryList = db.Categories.ToList();
            return View();
        }
    }
}